﻿using GameFormatReader.Common;
using OpenTK;
using System.ComponentModel;
using OpenTK.Graphics.OpenGL;
using WindEditor;
using J3DRenderer.ShaderGen;
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;

namespace J3DRenderer.JStudio
{
    public partial class JStudio3D : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Magic { get; protected set; }
        public string StudioType { get; protected set; }
        public string TotalFileSize { get { return string.Format("{0} bytes", m_totalFileSize); } }
        public INF1 INF1Tag { get; protected set; }
        public VTX1 VTX1Tag { get; protected set; }
        public MAT3 MAT3Tag { get; protected set; }
        public SHP1 SHP1Tag { get; protected set; }
        public JNT1 JNT1Tag { get; protected set; }
        public TEX1 TEX1Tag { get; private set; }
        public EVP1 EVP1Tag { get; private set; }
        public DRW1 DRW1Tag { get; private set; }

        private int m_totalFileSize;

        // Hack
        private Matrix4 m_viewMatrix;
        private Matrix4 m_projMatrix;
        private Matrix4 m_modelMatrix;
        private WLineBatcher m_lineBatcher;

        public void LoadFromStream(EndianBinaryReader reader)
        {
            m_lineBatcher = new WLineBatcher();


            // Read the J3D Header
            Magic = new string(reader.ReadChars(4));
            StudioType = new string(reader.ReadChars(4));
            m_totalFileSize = reader.ReadInt32();
            int tagCount = reader.ReadInt32();

            // Skip over an unused tag ("SVR3") which is consistent in all models.
            reader.Skip(16);

            LoadTagDataFromFile(reader, tagCount);
        }

        private void LoadTagDataFromFile(EndianBinaryReader reader, int tagCount)
        {
            for (int i = 0; i < tagCount; i++)
            {
                long tagStart = reader.BaseStream.Position;

                string tagName = reader.ReadString(4);
                int tagSize = reader.ReadInt32();

                switch (tagName)
                {
                    // INFO - Vertex Count, Scene Hierarchy
                    case "INF1":
                        INF1Tag = new INF1();
                        INF1Tag.LoadINF1FromStream(reader, tagStart);
                        break;
                    // VERTEX - Stores vertex arrays for pos/normal/color0/tex0 etc.
                    // Contains VertexAttributes which describe how the data is stored/laid out.
                    case "VTX1":
                        VTX1Tag = new VTX1();
                        VTX1Tag.LoadVTX1FromStream(reader, tagStart, tagSize);
                        break;
                    // ENVELOPES - Defines vertex weights for skinning
                    case "EVP1":
                        EVP1Tag = new EVP1();
                        EVP1Tag.LoadEVP1FromStream(reader, tagStart);
                        break;
                    // DRAW (Skeletal Animation Data) - Stores which matrices (?) are weighted, and which are used directly
                    case "DRW1":
                        DRW1Tag = new DRW1();
                        DRW1Tag.LoadDRW1FromStream(reader, tagStart);
                        break;
                    // JOINTS - Stores the skeletal joints (position, rotation, scale, etc...)
                    case "JNT1":
                        JNT1Tag = new JNT1();
                        JNT1Tag.LoadJNT1FromStream(reader, tagStart);
                        break;
                    // SHAPE - Face/Triangle information for model.
                    case "SHP1":
                        SHP1Tag = new SHP1();
                        SHP1Tag.ReadSHP1FromStream(reader, tagStart, VTX1Tag.VertexData);
                        break;
                    // MATERIAL - Stores materials (which describes how textures, etc. are drawn)
                    case "MAT3":
                        MAT3Tag = new MAT3();
                        MAT3Tag.LoadMAT3FromStream(reader, tagStart, tagSize);
                        break;
                    // TEXTURES - Stores binary texture images.
                    case "TEX1":
                        TEX1Tag = new TEX1();
                        TEX1Tag.LoadTEX1FromStream(reader, tagStart);
                        break;
                    // MODEL - Seems to be bypass commands for Materials and invokes GX registers directly.
                    case "MDL3":
                        break;
                }

                // Skip the stream reader to the start of the next tag since it gets moved around during loading.
                reader.BaseStream.Position = tagStart + tagSize;
            }

            // To generate shaders we need to know which vertex attributes need to be enabled for the shader. However,
            // the shader has no knowledge in our book as to what attributes are enabled. Theoretically we could enable
            // them on the fly as something requested it, but that'd involve more code that I don't want to do right now.
            // To resolve, we iterate once through the hierarchy to see which mesh is called after a material and bind the
            // vertex descriptions.
            Material dummyMat = null;
            AssignVertexAttributesToMaterialsRecursive(INF1Tag.HierarchyRoot, ref dummyMat);

            JNT1Tag.CalculateInverseBindPose(INF1Tag.HierarchyRoot, m_lineBatcher);


            // Upload our Lights
            GXLight[] lights = new GXLight[8];
            for (int i = 0; i < lights.Length; i++)
            {
                var light = new GXLight();
                // Upload to the GPU
                light.Position = i == 1 ? new Vector4(250, 200, 250, 0) : new Vector4(-5000, -5000, -5000, 0);
                light.Direction = -light.Position.Normalized();
                light.Color = i == 1 ? new Vector4(0f, 1, 0f, 1) : new Vector4(1, 1, 1, 1);
                light.CosAtten = new Vector4(1.075f, 0, 0, 0);
                light.DistAtten = new Vector4(1.075f, 0f, 0f, 0f);

                lights[i] = light;
            }

            

            m_lightBufferUniform = GL.GenBuffer();

            // Now that the vertex attributes are assigned to the materials, generate a shader from the data.
            foreach (var material in MAT3Tag.MaterialList)
            {
                if (material.VtxDesc == null)
                {
                    System.Console.WriteLine("Skipping generating Shader for Unreferenced Material: {0}", material);
                    continue;
                }
                material.Shader = TEVShaderGenerator.GenerateShader(material, MAT3Tag);
                m_psBlockUniform = GL.GenBuffer();

                int ubi = GL.GetUniformBlockIndex(material.Shader.Program, "LightBlock"); // Get the index of the Uniform Block in the Shader
                GL.UniformBlockBinding(material.Shader.Program, ubi, 0); // Bind our buffer to the Uniform Block.
                GL.BindBufferBase(BufferRangeTarget.UniformBuffer, 0, m_lightBufferUniform);
                GL.BufferData(BufferTarget.UniformBuffer, (IntPtr)(Marshal.SizeOf(lights[0]) * 8), lights, BufferUsageHint.DynamicDraw);

                PSBlock psBlock = new PSBlock();
                psBlock.Color = new Vector4[4];
                psBlock.kColor = new Vector4[4];

                //for (int i = 0; i < 4; i++)
                //    psBlock.Color[i] = new Vector4(MAT3Tag.TevColors[material.TevColorIndexes[i]].R, MAT3Tag.TevColors[material.TevColorIndexes[i]].G, MAT3Tag.TevColors[material.TevColorIndexes[i]].B, MAT3Tag.TevColors[material.TevColorIndexes[i]].A);

                //for (int i = 0; i < 4; i++)
                //    psBlock.kColor[i] = new Vector4(MAT3Tag.TevKonstColors[material.TevKonstColorIndexes[i]].R, MAT3Tag.TevKonstColors[material.TevKonstColorIndexes[i]].G, MAT3Tag.TevKonstColors[material.TevKonstColorIndexes[i]].B, MAT3Tag.TevKonstColors[material.TevKonstColorIndexes[i]].A);

                ubi = GL.GetUniformBlockIndex(material.Shader.Program, "PSBlock");
                GL.UniformBlockBinding(material.Shader.Program, ubi, 1);
                GL.BindBufferBase(BufferRangeTarget.UniformBuffer, 1, m_psBlockUniform);
                GL.BufferData(BufferTarget.UniformBuffer, (IntPtr)(16 * 4 * 2), ref psBlock, BufferUsageHint.DynamicDraw);   
            }

        }

        private void AssignVertexAttributesToMaterialsRecursive(HierarchyNode curNode, ref Material curMaterial)
        {
            switch (curNode.Type)
            {
                case HierarchyDataType.Material: curMaterial = MAT3Tag.MaterialList[MAT3Tag.MaterialRemapTable[curNode.Value]]; break;
                case HierarchyDataType.Batch: curMaterial.VtxDesc = SHP1Tag.Shapes[SHP1Tag.ShapeRemapTable[curNode.Value]].VertexDescription; break;
            }

            foreach (var child in curNode.Children)
                AssignVertexAttributesToMaterialsRecursive(child, ref curMaterial);
        }


        internal void Render(Matrix4 viewMatrix, Matrix4 projectionMatrix, Matrix4 modelMatrix)
        {
            m_viewMatrix = viewMatrix;
            m_projMatrix = projectionMatrix;
            m_modelMatrix = modelMatrix;
            m_lineBatcher.Render(viewMatrix, projectionMatrix);
            m_lineBatcher.Tick(1 / 60f);

            SkeletonJoint[] skeletonCopy = new SkeletonJoint[JNT1Tag.Joints.Count];
            for (int i = 0; i < skeletonCopy.Length; i++)
            {
                skeletonCopy[i] = new SkeletonJoint();
                skeletonCopy[i].Translation = JNT1Tag.Joints[i].Translation;
                skeletonCopy[i].Rotation = JNT1Tag.Joints[i].Rotation;
                skeletonCopy[i].ParentId = JNT1Tag.Joints[i].ParentId;
                skeletonCopy[i].Scale = JNT1Tag.Joints[i].Scale;
                skeletonCopy[i].Name = JNT1Tag.Joints[i].Name;
                skeletonCopy[i].BindPose = JNT1Tag.Joints[i].BindPose;
            }

            for (int i = 0; i < skeletonCopy.Length; i++)
            {
                SkeletonJoint joint = skeletonCopy[i];
                if (joint.ParentId >= 0)
                {
                    SkeletonJoint parentJoint = skeletonCopy[joint.ParentId];

                    Vector3 worldPos = parentJoint.Translation + Vector3.Transform(joint.Translation, parentJoint.Rotation);
                    Quaternion worldRot = (parentJoint.Rotation * joint.Rotation).Normalized(); // ToDo: Is the Normalized needed?

                    joint.Translation = worldPos;
                    joint.Rotation = worldRot;
                    joint.BindPose = Matrix4.CreateTranslation(worldPos) * Matrix4.CreateFromQuaternion(worldRot) * Matrix4.CreateScale(joint.Scale);


                    skeletonCopy[i] = joint;
                    //m_lineBatcher.DrawLine(parentJoint.Translation, joint.Translation, WLinearColor.Blue, 0, 1);
                }
            }

            foreach (var shape in SHP1Tag.Shapes)
            {
                var transformedVerts = new List<Vector3>(shape.VertexData.Position);
                List<WLinearColor> colorOverride = new List<WLinearColor>();

                for (int i = 0; i < shape.VertexData.Position.Count; i++)
                {
                    // This is relative to the vertex's original packet's matrix table.  
                    ushort posMtxIndex = (ushort)(shape.VertexData.PositionMatrixIndexes[i]);

                    // We need to calculate which packet data table that is.
                    int originalPacketIndex = 0;
                    for(int p = 0; p < shape.MatrixDataTable.Count; p++)
                    {
                        if(i >= shape.MatrixDataTable[p].FirstRelevantVertexIndex && i < shape.MatrixDataTable[p].LastRelevantVertexIndex)
                        {
                            originalPacketIndex = p; break;
                        }
                    }

                    // Now that we know which packet this vertex belongs to, we can get the index from it.
                    // If the Matrix Table index is 0xFFFF then it means "use previous", and we have to
                    // continue backwards until it is no longer 0xFFFF.
                    ushort matrixTableIndex;
                    do
                    {
                        matrixTableIndex = shape.MatrixDataTable[originalPacketIndex].MatrixTable[posMtxIndex];
                        originalPacketIndex--;
                    } while (matrixTableIndex == 0xFFFF);

                    bool isPartiallyWeighted = DRW1Tag.IsWeighted[matrixTableIndex];
                    ushort indexFromDRW1 = DRW1Tag.Indexes[matrixTableIndex];

                    if (isPartiallyWeighted)
                    {
                        ushort numBonesAffecting = EVP1Tag.NumBoneInfluences[indexFromDRW1];

                        // We need to figure out our offset into the arrays.
                        ushort firstBoneInfluence = 0;
                        for (ushort e = 0; e < indexFromDRW1; e++)
                        {
                            firstBoneInfluence += EVP1Tag.NumBoneInfluences[e];
                        }

                        Matrix4 finalTransform = Matrix4.Zero;
                        Vector4 transformedVertPos = Vector4.Zero;
                        for (int b = 0; b < numBonesAffecting; b++)
                        {
                            ushort boneIndex = EVP1Tag.IndexRemap[firstBoneInfluence + b];
                            float boneWeight = EVP1Tag.WeightList[firstBoneInfluence + b];

                            SkeletonJoint joint = skeletonCopy[boneIndex];
                            Matrix4 jointMtx = Matrix4.CreateScale(joint.Scale) * Matrix4.CreateFromQuaternion(joint.Rotation) * Matrix4.CreateTranslation(joint.Translation);
                            //Matrix4 jointMtx = Matrix4.CreateTranslation(joint.Translation) * Matrix4.CreateFromQuaternion(joint.Rotation) * Matrix4.CreateScale(joint.Scale);

                            Matrix4 sm1 = EVP1Tag.InverseBindPose[boneIndex];
                            Matrix4 sm2 = jointMtx;
                            sm1.Transpose();

                            //Console.WriteLine("jScale: {0} jRot: {1} jT: {2} jMtx: {3} sm1: {4}", joint.Scale, joint.Rotation, joint.Translation, jointMtx, sm1);
                            finalTransform = Mad(finalTransform, Matrix4.Mult(sm2, sm1), boneWeight);
                            //finalTransform += (jointMtx /** JNT1Tag.Joints[boneIndex].InverseBindPose*/) * boneWeight;

                            transformedVertPos += Vector4.Multiply(Vector4.Transform(new Vector4(transformedVerts[i], 1), Matrix4.Mult(sm1,sm2)), boneWeight);
                        }

                        transformedVertPos.X = transformedVertPos.X / transformedVertPos.W;
                        transformedVertPos.Y = transformedVertPos.Y / transformedVertPos.W;
                        transformedVertPos.Z = transformedVertPos.Z / transformedVertPos.W;
                        transformedVertPos.W = transformedVertPos.W / transformedVertPos.W;

                        //transformedVertPos = Vector4.Transform(new Vector4(transformedVerts[i],1), finalTransform);
                        transformedVerts[i] = transformedVertPos.Xyz;
                    }
                    else
                    {
                        // If the vertex is not weighted then we use a 1:1 movement with the bone matrix.
                        SkeletonJoint joint = skeletonCopy[indexFromDRW1];
                        Matrix4 finalTransform = Matrix4.CreateScale(joint.Scale) * Matrix4.CreateFromQuaternion(joint.Rotation) * Matrix4.CreateTranslation(joint.Translation);
                        //Matrix4 finalTransform = Matrix4.CreateTranslation(joint.Translation) * Matrix4.CreateFromQuaternion(joint.Rotation) * Matrix4.CreateScale(joint.Scale);
                        Vector3 transformedVertPos = Vector3.Transform(transformedVerts[i], finalTransform);
                        transformedVerts[i] = transformedVertPos;
                    }

                    colorOverride.Add(isPartiallyWeighted ? WLinearColor.Black : WLinearColor.White);
                }

                // Re-upload to the GPU.
                shape.OverrideVertPos = transformedVerts;
                shape.VertexData.Color0 = colorOverride;
                shape.UploadBuffersToGPU();
            }

            RenderMeshRecursive(INF1Tag.HierarchyRoot);
        }

        private Matrix4 Mad(Matrix4 r, Matrix4 m, float f)
        {
            for (int j = 0; j < 3; j++)
                for (int k = 0; k < 4; k++)
                    r[j,k] += f * m[j,k];

            return r;
        }

        private void RenderMeshRecursive(HierarchyNode curNode)
        {
            switch (curNode.Type)
            {
                case HierarchyDataType.Material:
                    BindMaterialByIndex(curNode.Value);
                    break;

                case HierarchyDataType.Batch:
                    RenderBatchByIndex(curNode.Value);
                    break;
            }

            foreach (var child in curNode.Children)
                RenderMeshRecursive(child);
        }

        private void BindMaterialByIndex(ushort index)
        {
            Material material = MAT3Tag.MaterialList[MAT3Tag.MaterialRemapTable[index]];
            material.Bind();

            Shader shader = material.Shader;

            GL.UniformMatrix4(shader.UniformModelMtx, false, ref m_modelMatrix);
            GL.UniformMatrix4(shader.UniformViewMtx, false, ref m_viewMatrix);
            GL.UniformMatrix4(shader.UniformProjMtx, false, ref m_projMatrix);

            for (int i = 0; i < 8; i++)
            {
                int idx = material.TextureIndexes[i];
                if (idx < 0)
                    continue;

                idx = MAT3Tag.TextureRemapTable[idx];

                int glTextureIndex = GL.GetUniformLocation(shader.Program, string.Format("Texture{0}", i));
                GL.Uniform1(glTextureIndex, i);
                TEX1Tag.Textures[idx].Bind(i);
            }

            if (shader.UniformTexMtx >= 0)
            {
                for (int i = 0; i < material.TexMatrixIndexes.Length; i++)
                {
                    int idx = material.TexMatrixIndexes[i];
                    if (idx < 0)
                        continue;

                    Matrix4 matrix = MAT3Tag.TexMatrixInfos[idx].Matrix;
                    GL.UniformMatrix4(GL.GetUniformLocation(shader.Program, string.Format("TexMtx[{0}]", i)), false, ref matrix);
                }
            }

            var color0Amb = MAT3Tag.AmbientColors[material.AmbientColorIndexes[0]];
            var color0Mat = MAT3Tag.MaterialColors[material.MaterialColorIndexes[0]];
            var color1Amb = MAT3Tag.AmbientColors[material.AmbientColorIndexes[1]];
            var color1Mat = MAT3Tag.MaterialColors[material.MaterialColorIndexes[1]];

            if (shader.UniformColor0Amb >= 0) GL.Uniform4(shader.UniformColor0Amb, color0Amb.R, color0Amb.G, color0Amb.B, color0Amb.A);
            if (shader.UniformColor0Mat >= 0) GL.Uniform4(shader.UniformColor0Mat, color0Mat.R, color0Mat.G, color0Mat.B, color0Mat.A);
            if (shader.UniformColor1Amb >= 0) GL.Uniform4(shader.UniformColor1Amb, color1Amb.R, color1Amb.G, color1Amb.B, color1Amb.A);
            if (shader.UniformColor1Mat >= 0) GL.Uniform4(shader.UniformColor1Mat, color1Mat.R, color1Mat.G, color1Mat.B, color1Mat.A);

            int ubi = GL.GetUniformBlockIndex(material.Shader.Program, "LightBlock");
            GL.UniformBlockBinding(material.Shader.Program, ubi, 0);
        }

        private int m_lightBufferUniform;
        private int m_psBlockUniform;

        [Serializable][StructLayout(LayoutKind.Sequential)]
        struct GXLight
        {
            public Vector4 Position;
            public Vector4 Direction;
            public Vector4 Color;
            public Vector4 CosAtten;
            public Vector4 DistAtten;
        }

        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        struct PSBlock
        {
            public Vector4[] Color;
            public Vector4[] kColor;
        }

        private void RenderBatchByIndex(ushort index)
        {
            GL.CullFace(CullFaceMode.Back);
            GL.FrontFace(FrontFaceDirection.Cw);
            GL.Enable(EnableCap.DepthTest);
            GL.Enable(EnableCap.CullFace);
            //GL.Enable(EnableCap.Blend);
            //GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);

            SHP1.Shape shape = SHP1Tag.Shapes[SHP1Tag.ShapeRemapTable[index]];
            shape.Bind();
            shape.Draw();
            shape.Unbind();
        }


        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}

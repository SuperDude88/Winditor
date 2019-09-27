﻿using GameFormatReader.Common;
using JStudio.OpenGL;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Assimp;

namespace WindEditor.Collision
{
    public class WCollisionMesh : WDOMNode, IRenderable
    {
        private int m_vbo, m_cbo, m_ebo;
        private Shader m_primitiveShader;
        private int m_triangleCount;

        private FAABox m_aaBox;

        private Vector3[] m_Vertices;
        private Vector4[] m_Colors;
        private Vector4[] m_Colors_Black;
        private int[] m_Indices;
        private CollisionGroupNode[] m_Nodes;
        private CollisionGroupNode m_RootNode;
        public CollisionProperty[] m_Properties;

        public string FileName { get; set; }

        public CollisionGroupNode RootNode
        {
            get { return m_RootNode; }
            set
            {
                if (value != m_RootNode)
                {
                    m_RootNode = value;
                    OnPropertyChanged("RootNode");
                }
            }
        }

        public CollisionTriangle[] Triangles { get; private set; }

        public WCollisionMesh(WWorld world) : base(world)
        {
            IsRendered = true;
            CreateShader();
        }

        public WCollisionMesh(WWorld world, Scene sc) :base(world)
        {
            IsRendered = true;
            CreateShader();
            LoadFromScene(sc);
        }

        private void CreateShader()
        {
            m_primitiveShader = new Shader("UnselectedCollision");
            m_primitiveShader.CompileSource(File.ReadAllText("resources/shaders/UnselectedCollision.vert"), ShaderType.VertexShader);
            m_primitiveShader.CompileSource(File.ReadAllText("resources/shaders/UnselectedCollision.frag"), ShaderType.FragmentShader);
            m_primitiveShader.LinkShader();
        }

        public void Load(EndianBinaryReader stream)
        {
            int vertexCount = stream.ReadInt32();
            int vertexOffset = stream.ReadInt32();
            int triangleCount = stream.ReadInt32();
            int triangleOffset = stream.ReadInt32();
            stream.SkipInt32(); // Number of octree indices
            stream.SkipInt32(); // Octree indices
            stream.SkipInt32(); // Number of octree nodes
            stream.SkipInt32(); // Octree nodes
            int groupCount = stream.ReadInt32();
            int groupOffset = stream.ReadInt32();
            int propertyCount = stream.ReadInt32();
            int propertyOffset = stream.ReadInt32();

            LoadVertices(stream, vertexOffset, vertexCount);
            LoadGroups(stream, groupOffset, groupCount);
            LoadProperties(stream, propertyOffset, propertyCount);
            LoadTriangles(stream, triangleOffset, triangleCount);

            m_triangleCount = triangleCount;
            int vertex_count = m_triangleCount * 3;

            m_Vertices = new Vector3[vertex_count];
            m_Indices = new int[vertex_count];
            m_Colors_Black = new Vector4[vertex_count];

            for (int i = 0; i < m_Colors_Black.Length; i++)
            {
                m_Colors_Black[i] = new Vector4(0, 0, 0, 1);
            }

            m_Colors = GetVertexColors();

            for (int i = 0; i < Triangles.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int cur_index = (i * 3) + j;
                    m_Indices[cur_index] = cur_index;
                    m_Vertices[cur_index] = Triangles[i].Vertices[j];
                }
            }

            SetupGL();
        }

        private void LoadVertices(EndianBinaryReader reader, int offset, int count)
        {
            m_Vertices = new Vector3[count];
            reader.BaseStream.Position = offset;

            for (int i = 0; i < count; i++)
            {
                m_Vertices[i] = new Vector3(reader.ReadSingle(), reader.ReadSingle(), reader.ReadSingle());
            }

            m_aaBox = CalculateAABB(m_Vertices);
        }

        private void LoadGroups(EndianBinaryReader reader, int offset, int count)
        {
            m_Nodes = new CollisionGroupNode[count];
            reader.BaseStream.Position = offset;

            for (int i = 0; i < count; i++)
            {
                CollisionGroupNode new_node = new CollisionGroupNode(reader);
                m_Nodes[i] = new_node;
            }

            RootNode = m_Nodes[0];
            RootNode.InflateHierarchyRecursive(null, m_Nodes);
        }

        private void LoadProperties(EndianBinaryReader reader, int offset, int count)
        {
            m_Properties = new CollisionProperty[count];
            reader.BaseStream.Position = offset;

            for (int i = 0; i < count; i++)
            {
                CollisionProperty new_prop = new CollisionProperty(reader);
                m_Properties[i] = new_prop;
            }
        }

        private void LoadTriangles(EndianBinaryReader reader, int offset, int count)
        {
            Triangles = new CollisionTriangle[count];
            reader.BaseStream.Position = offset;

            for (int i = 0; i < count; i++)
            {
                CollisionTriangle new_tri = new CollisionTriangle(reader, m_Vertices, m_Nodes, m_Properties);
                Triangles[i] = new_tri;
            }
        }

        private FAABox CalculateAABB(Vector3[] vertices)
        {
            Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
            Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

            for (int i = 0; i < vertices.Length; i++)
            {
                if (vertices[i].X < min.X) min.X = vertices[i].X;
                if (vertices[i].Y < min.Y) min.Y = vertices[i].Y;
                if (vertices[i].Z < min.Z) min.Z = vertices[i].Z;

                if (vertices[i].X > max.X) max.X = vertices[i].X;
                if (vertices[i].Y > max.Y) max.Y = vertices[i].Y;
                if (vertices[i].Z > max.Z) max.Z = vertices[i].Z;
            }

            return new FAABox(min, max);
        }

        private Vector4[] GetVertexColors()
        {
            List<Vector4> colors = new List<Vector4>();

            foreach (CollisionTriangle tri in Triangles)
            {
                Vector4 tri_color = new Vector4(tri.VertexColor.R, tri.VertexColor.G, tri.VertexColor.B, tri.VertexColor.A);

                colors.Add(tri_color);
                colors.Add(tri_color);
                colors.Add(tri_color);
            }

            return colors.ToArray();
        }

        private void SetupGL()
        {
            GL.GenBuffers(1, out m_vbo);
            GL.GenBuffers(1, out m_ebo);
            GL.GenBuffers(1, out m_cbo);

            // Upload Verts
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(12 * m_Vertices.Length), m_Vertices, BufferUsageHint.StaticDraw);

            // Upload initial colors
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_cbo);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(16 * m_Colors.Length), m_Colors, BufferUsageHint.DynamicDraw);

            // Upload eBO
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, m_ebo);
            GL.BufferData(BufferTarget.ElementArrayBuffer, (IntPtr)(4 * m_Indices.Length), m_Indices, BufferUsageHint.StaticDraw);
        }

        public void ReleaseResources()
        {
            m_primitiveShader.Dispose();
            GL.DeleteBuffer(m_ebo);
            GL.DeleteBuffer(m_vbo);
            GL.DeleteBuffer(m_cbo);
        }

        public void ToDZBFile(string file_name)
        {
            using (FileStream s = new FileStream(file_name, FileMode.Create, FileAccess.Write))
            {
                byte[] data = ToDZBArray();
                s.Write(data, 0, data.Length);

                s.Flush();
            }
        }

        public byte[] ToDZBArray()
        {
            byte[] data = null;

            using (MemoryStream m = new MemoryStream())
            {
                EndianBinaryWriter writer = new EndianBinaryWriter(m, Endian.Big);
                WriteDZB(writer);

                data = m.ToArray();
            }

            return data;
        }

        public void ToOBJFile(string file_name)
        {
            using (FileStream s = new FileStream(file_name, FileMode.Create, FileAccess.Write))
            {
                using (StringWriter sw = new StringWriter())
                {
                    foreach (Vector3 v in m_Vertices)
                    {
                        sw.WriteLine($"v {v.X} {v.Y} {v.Z}");
                    }

                    sw.WriteLine();

                    RootNode.ToOBJFile(sw, m_Vertices);

                    byte[] file_bytes = System.Text.Encoding.ASCII.GetBytes(sw.ToString());

                    s.Write(file_bytes, 0, file_bytes.Length);
                    s.Flush();
                }
            }
        }

        public void ToDAEFile(string file_name)
        {
            AssimpContext cont = new AssimpContext();
            cont.ExportFile(BuildDAEScene(), file_name, "collada", 0);
        }

        private Scene BuildDAEScene()
        {
            Scene sc = new Scene();

            sc.Materials.Add(new Material());
            sc.Meshes.AddRange(GetAssimpMeshes());
            sc.RootNode = new Node("col_root");
            sc.RootNode.Children.Add(RootNode.GetAssimpNodesRecursive(sc.Meshes));

            return sc;
        }

        private List<Mesh> GetAssimpMeshes()
        {
            List<Mesh> meshes = new List<Mesh>();

            foreach (CollisionGroupNode n in m_Nodes)
            {
                if (n.Triangles.Count <= 0)
                {
                    continue;
                }

                Mesh m = new Mesh(n.Name);
                m.PrimitiveType = Assimp.PrimitiveType.Triangle;

                foreach (CollisionTriangle t in n.Triangles)
                {
                    Vector3D v1 = new Vector3D(t.Vertices[0].X, t.Vertices[0].Y, t.Vertices[0].Z);
                    Vector3D v2 = new Vector3D(t.Vertices[1].X, t.Vertices[1].Y, t.Vertices[1].Z);
                    Vector3D v3 = new Vector3D(t.Vertices[2].X, t.Vertices[2].Y, t.Vertices[2].Z);

                    if (!m.Vertices.Contains(v1))
                        m.Vertices.Add(v1);
                    if (!m.Vertices.Contains(v2))
                        m.Vertices.Add(v2);
                    if (!m.Vertices.Contains(v3))
                        m.Vertices.Add(v3);

                    m.Faces.Add(new Face(new int[]{ m.Vertices.IndexOf(v1), m.Vertices.IndexOf(v2), m.Vertices.IndexOf(v3) }));
                }

                meshes.Add(m);
            }

            return meshes;
        }

        public static WCollisionMesh FromDAEFile(WWorld world, string file_name)
        {
            AssimpContext cont = new AssimpContext();
            Scene scn = cont.ImportFile(file_name);

            return new WCollisionMesh(world, scn);
        }

        private void LoadFromScene(Scene scn)
        {
            RootNode = GetCollisionNodesRecursive(scn.RootNode);
        }

        private CollisionGroupNode GetCollisionNodesRecursive(Node node)
        {
            CollisionGroupNode new_node = new CollisionGroupNode(node.Name);

            foreach (Node n in node.Children)
            {
                new_node.Children.Add(GetCollisionNodesRecursive(n));
            }

            return new_node;
        }

        private void WriteDZB(EndianBinaryWriter writer)
        {

        }

        public override string ToString()
        {
            return FileName;
        }

        #region IRenderable
        void IRenderable.AddToRenderer(WSceneView view)
        {
            view.AddTransparentMesh(this);
        }

        void IRenderable.Draw(WSceneView view)
        {
            m_Colors = GetVertexColors();

            Matrix4 modelMatrix = Matrix4.Identity;
            Matrix4 viewMatrix = view.ViewMatrix;
            Matrix4 projMatrix = view.ProjMatrix;

            m_primitiveShader.Bind();
            GL.UniformMatrix4(m_primitiveShader.UniformModelMtx, false, ref modelMatrix);
            GL.UniformMatrix4(m_primitiveShader.UniformViewMtx, false, ref viewMatrix);
            GL.UniformMatrix4(m_primitiveShader.UniformProjMtx, false, ref projMatrix);

            // VBO
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_vbo);
            GL.EnableVertexAttribArray((int)ShaderAttributeIds.Position);
            GL.VertexAttribPointer((int)ShaderAttributeIds.Position, 3, VertexAttribPointerType.Float, false, 12, 0);

            // CBO
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_cbo);
            GL.EnableVertexAttribArray((int)ShaderAttributeIds.Color0);
            GL.VertexAttribPointer((int)ShaderAttributeIds.Color0, 4, VertexAttribPointerType.Float, false, 16, 0);

            // EBO
            GL.BindBuffer(BufferTarget.ElementArrayBuffer, m_ebo);

            GL.DepthMask(false);

            DrawTris();
            DrawLines();

            GL.DepthMask(true);

            GL.DisableVertexAttribArray((int)ShaderAttributeIds.Position);
            GL.DisableVertexAttribArray((int)ShaderAttributeIds.Color0);
        }

        private void DrawTris()
        {
            // Enable stuff
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Enable(EnableCap.Blend);
            GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);
            GL.FrontFace(FrontFaceDirection.Ccw);

            GL.Enable(EnableCap.PolygonOffsetFill);
            GL.PolygonOffset(-5f, 1f);

            // CBO
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_cbo);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(16 * m_Colors.Length), m_Colors, BufferUsageHint.DynamicDraw);

            // Draw!
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);
            GL.DrawElements(BeginMode.Triangles, m_triangleCount * 3, DrawElementsType.UnsignedInt, 0);

            // Disable stuff
            GL.Disable(EnableCap.Blend);
            GL.Disable(EnableCap.CullFace);

            GL.Disable(EnableCap.PolygonOffsetFill);
            GL.PolygonOffset(0f, 0f);
        }

        private void DrawLines()
        {
            // Enable stuff
            GL.Disable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Enable(EnableCap.CullFace);
            GL.CullFace(CullFaceMode.Back);
            GL.FrontFace(FrontFaceDirection.Ccw);

            GL.Enable(EnableCap.PolygonOffsetLine);
            GL.PolygonOffset(-10f, 1f);

            // CBO
            GL.BindBuffer(BufferTarget.ArrayBuffer, m_cbo);
            GL.BufferData(BufferTarget.ArrayBuffer, (IntPtr)(16 * m_Colors_Black.Length), m_Colors_Black, BufferUsageHint.DynamicDraw);

            // Draw!
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Line);
            GL.DrawElements(BeginMode.Triangles, m_triangleCount * 3, DrawElementsType.UnsignedInt, 0);
            GL.PolygonMode(MaterialFace.FrontAndBack, PolygonMode.Fill);

            // Disable stuff
            GL.Disable(EnableCap.CullFace);

            GL.Disable(EnableCap.PolygonOffsetLine);
            GL.PolygonOffset(0f, 0f);
        }

        Vector3 IRenderable.GetPosition()
        {
            return m_aaBox.Center;
        }

        float IRenderable.GetBoundingRadius()
        {
            return m_aaBox.Max.Length; // ToDo: This isn't correct.
        }
        #endregion
    }
}

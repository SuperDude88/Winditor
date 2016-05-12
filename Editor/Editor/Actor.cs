﻿namespace WindEditor
{
    abstract public class WActor : ITickableObject
    {
        public WTransform Transform { get; protected set; }

        private WWorld m_world;

        public WActor()
        {
            Transform = new WTransform();
        }

        public virtual void Tick(float deltaTime) { }

        public virtual AABox GetAABB()
        {
            return new AABox();
        }

        public void SetWorld(WWorld world)
        {
            m_world = world;
        }

        public WWorld GetWorld()
        {
            return m_world;
        }
    }
}

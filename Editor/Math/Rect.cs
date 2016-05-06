﻿namespace Editor
{
    struct WRect
    {
        public float X, Y, Width, Height;

        public WRect(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format("X: {0} Y: {1} Width: {2} Height: {3}", X, Y, Width, Height);
        }
    }
}

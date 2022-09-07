using System;


namespace Point
{
    struct PointStruct
    {
        public int X;
        public int Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}

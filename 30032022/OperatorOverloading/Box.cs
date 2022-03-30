using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    internal class Box
    {
        public Box(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }
        public int Width;
        public int Height;

        public static Box operator+(Box box1,Box box2)
        {
            return new Box(box1.Width+box2.Width,box1.Height+box2.Height);    
        }

        public static Box operator +(Box box1, int num)
        {
            return new Box(box1.Width+num,box1.Height+num);
        }
    }
}

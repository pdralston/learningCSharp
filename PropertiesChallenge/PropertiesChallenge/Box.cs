using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesChallenge
{
    class Box
    {
        private int height;
        private int width;
        private int length;
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value > 0 ? value : -value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value > 0 ? value : -value;
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value > 0 ? value : -value;
            }
        }
        public int Volume
        {
            get
            {
                return Height * Width * Length;
            }
        }
        public int FaceArea
        {
            get
            {
                return Height * Width;
            }
        }

        public Box(int height = 1, int width = 1, int length = 1)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public override string ToString()
        {
            return $"Box Dimensions\nHeight: {Height}\nWidth: {Width}\nLength: {Length}\nFaceArea: {FaceArea}\nVolume: {Volume}";
        }
    }
}

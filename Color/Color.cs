using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class Color
    {
        private int _a;
        private int _r;
        private int _b;
        private int _g;

        public int R
        {
            get
            {
                return _r;
            }
            set
            {
                _r = value;
            }
        }

        public int B
        {
            get
            {
                return _b;
            }
            set
            {
                _b = value;
            }
        }

        public int G
        {
            get
            {
                return _g;
            }
            set
            {
                _g = value;
            }
        }

        public int A
        {
            get
            {
                return _a;
            }
            set
            {
                _a = value;
            }
        }

        public void AssignValue(Byte r, Byte g, Byte b, Byte a)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        public bool Equals(Color c)
        {
            return R == c.R && G == c.G && B == c.B && A == c.A;
        }

        public static Color CreateFromRGB(Byte r, Byte g, Byte b)
        {
            Color result = new Color();
            result.R = r;
            result.G = g;
            result.B = b;
            result.A = 255;
            return result;
        }

        public static Color CreateFromRGBA(Byte r, Byte g, Byte b, Byte a)
        {
            Color result = CreateFromRGB(r, g, b);
            result.A = a;
            return result;
        }
    }
}

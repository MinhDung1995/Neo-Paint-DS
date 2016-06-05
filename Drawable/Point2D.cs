using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public class Point2D
    {
        private Int32 _x;
        private Int32 _y;

        public Int32 X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public Int32 Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public Point2D()
        {
            _x = 0;
            _y = 0;
        }

        public Point2D(Int32 x, Int32 y)
        {
            _x = x;
            _y = y;
        }

        public Point2D(Point2D point)
        {
            _x = point.X;
            _y = point.Y;
        }

        public Boolean Equal(Point2D point)
        {
            if (_x == point.X && _y == point.Y)
                return true;

            return false;
        }

        public void AssignValue(Point2D point)
        {
            _x = point.X;
            _y = point.Y;
        }
    }
}

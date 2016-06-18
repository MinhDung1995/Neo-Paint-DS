using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class Point2D
    {
        private double _x;
        private double _y;

        public double X
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

        public double Y
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

        public Point2D(double x, double y)
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

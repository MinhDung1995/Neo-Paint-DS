using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class RadialBrush : GradientBrush
    {
        private Point2D _center;
        private Point2D _gradientOrigin;
        private double _radiusX;
        private double _radiusY;

        public Point2D Center
        {
            get
            {
                return _center;
            }

            set
            {
                _center = value;
            }
        }

        public Point2D GradientOrigin
        {
            get
            {
                return _gradientOrigin;
            }

            set
            {
                _gradientOrigin = value;
            }
        }

        public double RadiusX
        {
            get
            {
                return _radiusX;
            }

            set
            {
                _radiusX = value;
            }
        }

        public double RadiusY
        {
            get
            {
                return _radiusY;
            }

            set
            {
                _radiusY = value;
            }
        }

        public RadialBrush() : base()
        {
            _center = new Point2D(0.5, 0.5);
            _gradientOrigin = new Point2D(0.5, 0.5);
            _radiusX = 0.5;
            _radiusY = 0.5;
        }

        public RadialBrush(List<GradientStop> stops) : base(stops)
        {
            _center = new Point2D(0.5, 0.5);
            _gradientOrigin = new Point2D(0.5, 0.5);
            _radiusX = 0.5;
            _radiusY = 0.5;
        }

        public RadialBrush(List<GradientStop> stops, Point2D center, Point2D origin, double x, double y) 
            : base(stops)
        {
            _center = center;
            _gradientOrigin = origin;
            _radiusX = x;
            _radiusY = y;
        }
    }
}

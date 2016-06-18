using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    class LinearGradientBrush : GradientBrush
    {
        private double _angle;

        public double Angle
        {
            get
            {
                return _angle;
            }

            set
            {
                _angle = value;
            }
        }

        public LinearGradientBrush() : base()
        {
            _angle = 0;
        }

        public LinearGradientBrush(List<GradientStop> stops) : base(stops)
        {
            _angle = 0;
        }

        public LinearGradientBrush(List<GradientStop> stops, double angle) : base(stops)
        {
            _angle = angle;
        }


    }
}

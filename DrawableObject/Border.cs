using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class Border
    {
        private double _thickness;
        private Brush _brush;
        private BorderStyle _style;

        public Brush Brush
        {
            get
            {
                return _brush;
            }

            set
            {
                _brush = value;
            }
        }

        public BorderStyle Style
        {
            get
            {
                return _style;
            }
            set
            {
                _style = value;
            }
        }

        public double Thickness
        {
            get
            {
                return _thickness;
            }
            set
            {
                _thickness = value;
            }
        }

        public Border()
        {
            _thickness = 1;
            _brush = new SolidBrush(Color.CreateFromRGB(0, 0 ,0));
            _style = BorderStyle.Solid;
        }

        public Border(Border border)
        {
            _thickness = border.Thickness;
            _brush = border.Brush;
            _style = border.Style;
        }

        public Border(double thickness, Brush brush, BorderStyle style)
        {
            _thickness = thickness;
            _brush = brush;
            _style = style;
        }
    }
}

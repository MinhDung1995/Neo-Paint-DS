using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public class SolidBrush : Brush
    {
        private Color _color;

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public SolidBrush(Color c)
        {
            _color = c;
        }
    }
}

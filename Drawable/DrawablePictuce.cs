using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public abstract class DrawablePicture : DrawableObject, BorderChangable, ImageChangable
    {
        protected int _bitmap;
        protected double _opacity;
        protected DrawableShape _frame;

        public int Bitmap
        {
            get
            {
                return _bitmap;
            }

            set
            {
                _bitmap = value;
            }
        }

        public DrawableShape Frame
        {
            get
            {
                return _frame;
            }
        }

        public double Opacity
        {
            get
            {
                return _opacity;
            }
            set
            {
                if (_opacity >= 0)
                    _opacity = value;
            }
        }

        public void ChangeBorder(DrawableShape frame)
        {
            _frame = frame;
        }

        public void ChangeImage(int bitmap)
        {
        }
    }
}

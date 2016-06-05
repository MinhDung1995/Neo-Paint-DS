using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public abstract class DrawablePicture : DrawableObject, BorderChangable, ImageChangable
    {
        private int _bitmap;
        private int _opacity;

        public int Bitmap
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DrawableShape Frame
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Opacity
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void ChangeBorder()
        {
            throw new NotImplementedException();
        }

        public void ChangeImage()
        {
            throw new NotImplementedException();
        }
    }
}

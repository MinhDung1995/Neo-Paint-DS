using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public abstract class DrawableObject : Drawable, Clonable, BorderBrushChangable, BorderThicknessChangable, BorderStyleChangable, BackgroundBrushChangable
    {
        private Point2D _startPoint;
        private Point2D _endPoint;
        private Brush _backgroundBrush;
        private Border _border;

        public Brush BackgroundBrush
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Border Border
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public List<Point2D> Draw(int startX, int startY, int endX, int endY)
        {
            throw new NotImplementedException();
        }

        public void Clone()
        {
            throw new NotImplementedException();
        }

        public void GetOriginalInstance()
        {
            throw new NotImplementedException();
        }

        public void ChangeBorderBrush()
        {
            throw new NotImplementedException();
        }

        public void ChangeBorderThickness()
        {
            throw new NotImplementedException();
        }

        public void ChangeBorderStyle()
        {
            throw new NotImplementedException();
        }

        public void ChangeBackgroundBrush()
        {
            throw new NotImplementedException();
        }

        public void GetDrawableType()
        {
            throw new System.NotImplementedException();
        }
    }
}

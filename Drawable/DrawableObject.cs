using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public abstract class DrawableObject : Drawable, Clonable, BorderBrushChangable, 
        BorderThicknessChangable, BorderStyleChangable, BackgroundBrushChangable
    {
        private Point2D _startPoint;
        private Point2D _endPoint;
        private Brush _backgroundBrush;
        private Border _border;

        public Brush BackgroundBrush
        {
            get
            {
                return _backgroundBrush;
            }
            set
            {
                _backgroundBrush = value;
            }
        }

        public Border Border
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
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

        public void ChangeBorderBrush(int newBrush)
        {
            _border.Brush = newBrush;
        }

        public void ChangeBorderThickness(int newThickness)
        {
            _border.Thickness = newThickness;
        }

        public void ChangeBorderStyle(int newStyle)
        {
            _border.Style = newStyle;
        }

        public void ChangeBackgroundBrush(Brush newBrush)
        {
            _backgroundBrush = newBrush;
        }

        public string GetDrawableType()
        {
            return "DrawableObject";
        }
    }
}

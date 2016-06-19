using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class DrawableRectangle : DrawableShape
    {
        public DrawableRectangle() { }

        public DrawableRectangle(Point2D startPoint, Point2D endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }


        public DrawableRectangle(Point2D startPoint, Point2D endPoint, 
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableRectangle(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            return new List<Point2D>()
            {
                new Point2D(startX, startY),
                new Point2D(startX, endY),
                new Point2D(endX, endY),
                new Point2D(endX, startY),
            };
        }

        public override Clonable Clone()
        {
            return new DrawableRectangle(_startPoint, _endPoint, _backgroundBrush, _border);
        }       

        public override Clonable GetOriginalInstance()
        {
            return new DrawableRectangle(_backgroundBrush, _border);
        }

        public override string GetDrawableType()
        {
            return "Drawable Rectangle";
        }

        public override string ToString()
        {
            return "Rectangle";
        }
    }
}

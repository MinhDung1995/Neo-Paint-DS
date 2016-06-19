using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class DrawableEllipse : DrawableShape
    {
        public DrawableEllipse() { }

        public DrawableEllipse(Point2D startPoint, Point2D endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public DrawableEllipse(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableEllipse(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawableEllipse(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            double height = Math.Abs(endY - startY);
            double width = Math.Abs(endX - startX);
            return new List<Point2D>()
            {
                new Point2D((startX + endX)/2, (startY + endY)/ 2), // tâm
                new Point2D(width, height) // kích thước 
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawableEllipse(_backgroundBrush, _border);
        }

        public override string GetDrawableType()
        {
            return "Drawable Ellipse";
        }

        public override string ToString()
        {
            return "Ellipse";
        }
    }
}

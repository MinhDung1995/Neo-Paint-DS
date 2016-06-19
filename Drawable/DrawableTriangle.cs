using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class DrawableTriangle : DrawableShape
    {
        public DrawableTriangle() { }

        public DrawableTriangle(Point2D startPoint, Point2D endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }


        public DrawableTriangle(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableTriangle(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawableTriangle(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            return new List<Point2D>()
            {
                new Point2D((startX + endX)/2, startY),
                new Point2D(endX, endY),
                new Point2D(startX, endY)
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawableTriangle(_backgroundBrush, _border);
        }

        public override string GetDrawableType()
        {
            return "Drawable Triangle";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class DrawablePentagon : DrawableShape
    {
        public DrawablePentagon() { }

        public DrawablePentagon(Point2D startPoint, Point2D endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public DrawablePentagon(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawablePentagon(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawablePentagon(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            double dX = endX - startX;
            double dY = endY - startY;

            return new List<Point2D>()
            {
                new Point2D((endX + startX) / 2, startY),
                new Point2D(endX, startY + 0.4 * dY),
                new Point2D(startX + 0.8 * dX, endY),
                new Point2D(startX + 0.2 * dX, endY),
                new Point2D(startX, startY + 0.4 * dY),
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawablePentagon(_backgroundBrush, _border);
        }

        public override string GetDrawableType()
        {
            return "Drawable Pentagon";
        }

        public override string ToString()
        {
            return "Pentagon";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class DrawableStar : DrawableShape
    {
        public DrawableStar() { }

        public DrawableStar(Point2D startPoint, Point2D endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public DrawableStar(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableStar(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawableStar(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            double dX = endX - startX;
            double dY = _endPoint.Y - startY;

            return new List<Point2D>() {
                new Point2D((endX + startX) / 2, startY),
                new Point2D(startX + 0.62 * dX, startY + 0.4 * dY),
                new Point2D(endX, startY + 0.4 * dY),
                new Point2D(startX + 0.7 * dX, startY + 0.62 * dY),
                new Point2D(startX + 0.8 * dX, _endPoint.Y),
                new Point2D((endX + startX) / 2, startY + 0.8 * dY),
                new Point2D(startX + 0.2 * dX, _endPoint.Y),
                new Point2D(startX + 0.3 * dX, startY + 0.62 * dY),
                new Point2D(startX, startY + 0.4 * dY),
                new Point2D(startX + 0.38 * dX, startY + 0.4 * dY),
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawableStar(_backgroundBrush, _border);
        }

        public override string GetDrawableType()
        {
            return "Drawable Star";
        }

        public override string ToString()
        {
            return "Star";
        }
    }
}

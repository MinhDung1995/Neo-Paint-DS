using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public class DrawableVerticalArrow : DrawableShape
    {
        public DrawableVerticalArrow(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableVerticalArrow(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawableVerticalArrow(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            double dX = endX - startX;
            double dY = endY - startY;

            return new List<Point2D>() {
                new Point2D((endX + startX) / 2, startY),
                new Point2D(endX, (startY + endY) / 2),
                new Point2D(startX + 0.75 * dX, (startY + endY) / 2),
                new Point2D(startX + 0.75 * dX, endY),
                new Point2D(startX + 0.25 * dX, endY),
                new Point2D(startX + 0.25 * dX, (startY + endY) / 2),
                new Point2D(startX, (startY + endY) / 2),
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawableVerticalArrow(_backgroundBrush, _border);
        }
    }
}

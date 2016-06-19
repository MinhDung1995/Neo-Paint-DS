using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class DrawableHexagram : DrawableShape
    {
        public DrawableHexagram() { }

        public DrawableHexagram(Point2D startPoint, Point2D endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public DrawableHexagram(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableHexagram(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawableHexagram(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            double dX = endX - startX;
            double dY = _endPoint.Y - startY;

            return new List<Point2D>()
            {
                new Point2D(startX, (_endPoint.Y + startY) / 2),
                new Point2D(startX + 0.25 * dX, startY + 2 * dY / 3),
                new Point2D(startX + 0.25 * dX, _endPoint.Y),
                new Point2D((endX + startX) / 2, startY + 5 * dY / 6),
                new Point2D(startX + 0.75 * dX, _endPoint.Y),
                new Point2D(startX + 0.75 * dX, startY + 2 * dY / 3),
                new Point2D(endX, (_endPoint.Y + startY) / 2),
                new Point2D(startX + 0.75 * dX, startY + dY / 3),
                new Point2D(startX + 0.75 * dX, startY),
                new Point2D((endX + startX) / 2, startY + dY / 6),
                new Point2D(startX + 0.25 * dX, startY),
                new Point2D(startX + 0.25 * dX, startY + dY / 3)
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawableHexagram(_backgroundBrush, _border);
        }

        public override string GetDrawableType()
        {
            return "Drawable Hexagram";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class DrawableHexagon : DrawableShape
    {
        public DrawableHexagon() { }

        public DrawableHexagon(Point2D startPoint, Point2D endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public DrawableHexagon(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableHexagon(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawableHexagon(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            double dX = endX - startX;
            double dY = endY - startY;

            return new List<Point2D>() {
                new Point2D((endX + startX) / 2, startY),
                new Point2D(endX, startY + 0.25 * dY),
                new Point2D(endX, startY + 0.75 * dY),
                new Point2D((endX + startX) / 2, endY),
                new Point2D(startX, startY + 0.75 * dY),
                new Point2D(startX, startY + 0.25 * dY)
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawableHexagon(_backgroundBrush, _border);
        }

        public override string GetDrawableType()
        {
            return "Drawable Hexagon";
        }
    }
}

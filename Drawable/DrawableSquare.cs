using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public class DrawableSquare : DrawableShape
    {
        public DrawableSquare(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableSquare(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawableSquare(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            double height = Math.Abs(endY - startY);
            double width = Math.Abs(endX - startX);

            Point2D end;
            if (height > width)
            {
                if (endY < startY)
                    end = new Point2D(endX, endY + (height - width));
                else
                    end = new Point2D(endX, endY - (height - width));
            }
            else
            {
                if (endX < startX)
                    end = new Point2D(endX + (width - height), endY);
                else
                    end = new Point2D(endX - (width - height), endY);
            }

            return new List<Point2D>()
            {
                new Point2D(startX, startY),
                new Point2D(startX, end.Y),
                end,
                new Point2D(end.X, startY)
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawableSquare(_backgroundBrush, _border);
        }
    }
}

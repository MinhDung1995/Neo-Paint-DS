﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class DrawableHorizontalArrow : DrawableShape
    {
        public DrawableHorizontalArrow() { }

        public DrawableHorizontalArrow(Point2D startPoint, Point2D endPoint)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
        }

        public DrawableHorizontalArrow(Point2D startPoint, Point2D endPoint,
            Brush backgroundBrush, Border border)
        {
            _startPoint = startPoint;
            _endPoint = endPoint;
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public DrawableHorizontalArrow(Brush backgroundBrush, Border border)
        {
            _backgroundBrush = backgroundBrush;
            _border = border;
        }

        public override Clonable Clone()
        {
            return new DrawableHorizontalArrow(_startPoint, _endPoint, _backgroundBrush, _border);
        }

        public override List<Point2D> Draw(double startX, double startY, double endX, double endY)
        {
            double dX = endX - startX;
            double dY = endY - startY;

            return new List<Point2D>() {
                new Point2D((endX + startX) / 2, startY),
                new Point2D(endX, (startY + endY) / 2),
                new Point2D((endX + startX) / 2, endY),
                new Point2D((endX + startX) / 2, startY + dY * 0.75),
                new Point2D(startX, startY + dY * 0.75),
                new Point2D(startX, startY + dY * 0.25),
                new Point2D((endX + startX) / 2, startY + dY * 0.25),
            };
        }

        public override Clonable GetOriginalInstance()
        {
            return new DrawableHorizontalArrow(_backgroundBrush, _border);
        }

        public override string GetDrawableType()
        {
            return "Drawable Horizontal Arrow";
        }

        public override string ToString()
        {
            return "Horizontal Arrow";
        }
    }
}

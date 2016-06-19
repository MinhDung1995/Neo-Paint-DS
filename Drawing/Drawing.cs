using NeoDrawable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace NeoDrawable
{
    public abstract class Drawing
    {
        public abstract void Draw(Canvas canvas, DrawableObject obj);

        public Polygon PolygonFromPoints(List<Point2D> points)
        {
            Polygon pg = new Polygon();
            pg.IsHitTestVisible = false;
            pg.Stroke = Brushes.Black;
            foreach (Point2D p in points)
            {
                pg.Points.Add(new Point(p.X, p.Y));
            }
            return pg;
        } 
    }
}

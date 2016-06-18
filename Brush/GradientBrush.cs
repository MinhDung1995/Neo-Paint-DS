using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class GradientBrush : Brush
    {
        protected List<GradientStop> _gradientStops;

        public List<GradientStop> GradientStops
        {
            get
            {
                return _gradientStops;
            }

            set
            {
                _gradientStops = value;
            }
        }

        public GradientBrush()
        {
            _gradientStops = new List<GradientStop>();
        }

        public GradientBrush(List<GradientStop> stops)
        {
            _gradientStops = stops;
        }       

        public void AddGradientStop(GradientStop gs)
        {
            _gradientStops.Add(gs);
            _gradientStops = _gradientStops.OrderBy(st => st.Offset).ToList();
        }

        public bool RemoveGradientStopAt(int index)
        {
            if (index < 0 || index > _gradientStops.Count)
                return false;
            _gradientStops.RemoveAt(index);
            return true;
        }

        public bool SetStopAt(int index, GradientStop stop)
        {
            if (index < 0 || index > _gradientStops.Count)
                return false;
            _gradientStops[index] = stop;
            return true;
        }

    }

    public sealed class GradientStop
    {
        private Color _color;
        private double _offset;

        public Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public double Offset
        {
            get
            {
                return _offset;
            }

            set
            {
                _offset = value;
            }
        }
    }
}

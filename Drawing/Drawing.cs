using NeoDrawable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NeoDrawable
{
    public interface Drawing
    {
        void Draw(Canvas canvas, DrawableObject obj);
    }
}

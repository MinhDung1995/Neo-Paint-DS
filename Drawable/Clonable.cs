using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IDrawable
{
    public interface Clonable
    {
        Clonable Clone();

        Clonable GetOriginalInstance();
    }
}

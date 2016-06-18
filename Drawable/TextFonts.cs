using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;

namespace NeoDrawable
{
    public class TextFonts
    {
        private static List<TextFont> _fontList;

        public static List<TextFont> GetFontList()
        {
            if (_fontList == null)
            {
                InstalledFontCollection installedFontCollection = new InstalledFontCollection();
                FontFamily[] families = installedFontCollection.Families;
                _fontList = new List<TextFont>();
                foreach (FontFamily ff in families)
                {
                    TextFont tf = new TextFont(ff.Name);
                    _fontList.Add(tf);
                }
            }

            return _fontList;
        }
    }
}

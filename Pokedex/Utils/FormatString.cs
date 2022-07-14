using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Utils
{
    internal class FormatString
    {
        public static string Capitalize(string s) 
        {
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            return ti.ToTitleCase(s.Replace('-', ' '));
        }
    }
}

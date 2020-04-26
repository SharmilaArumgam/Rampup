using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Sample
{
    class ProperNoun : Word
    {
       public  ProperNoun(string w, string def, string t) : base(w, def, t)

        {
            word = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(w);

        }
    }
}

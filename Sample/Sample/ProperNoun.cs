using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class ProperNoun : Word
    {
        public ProperNoun(string w, string def) : base(w, def)
        {
            word = char.ToUpper(w[0]) + w.Substring(1).ToLower();
            definition = char.ToUpper(def[0]) + def.Substring(1).ToLower();
        }
    }
}

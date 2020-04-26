using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
   public class Word
    {
         public string word { get; set; }
         public string definition { get; set; }
        public string type { get; set; }

        public Word(string w, string def, string t)
        {
            word = w;
            definition = def;
            type = t;
        }

        }
    }
 
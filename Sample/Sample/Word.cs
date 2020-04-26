using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Word
    {
         public string word { get; set; }
         public string definition { get; set; }

        public Word(string w, string def)
        {
            word = w;
            definition = def;
        }

        }
    }

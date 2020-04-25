using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Word
    {
        protected string word { get; set; }
        protected string definition { get; set; }

        public Word(string w, string def)
        {
            word = w;
            definition = def;
        }

        }
    }

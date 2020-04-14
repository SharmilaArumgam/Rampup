using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Adverb : Word
    {
        List<string> AdvList = new List<string>();

        public Adverb (string w, string def) : base(w, def)
        {
            AdvList.Add(word);
            AdvList.Add(definition);
        }

        public void print()
        {
            foreach (var x in AdvList)
            {
                Console.WriteLine(x);
            }
        }
    }
}

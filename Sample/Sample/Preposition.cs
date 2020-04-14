using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Preposition : Word
    {
        List<string> PreList = new List<string>();

        public Preposition(string w, string def) : base(w, def)
        {
            PreList.Add(word);
            PreList.Add(definition);
        }

        public void print()
        {
            foreach (var x in PreList)
            {
                Console.WriteLine(x);
            }
        }
    }
}

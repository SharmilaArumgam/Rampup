using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class ProperNoun : Word
    {
        List<string> ProList = new List<string>();

        public ProperNoun(string w, string def) : base(w, def)
        {
            ProList.Add(word);
            ProList.Add(definition);
        }

        public void print()
        {
            foreach (var x in ProList)
            {
                Console.WriteLine(x);
            }
        }
    }
}

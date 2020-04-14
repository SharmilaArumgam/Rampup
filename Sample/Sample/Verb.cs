using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Verb : Word
    {
        List<string> VerbList = new List<string>();

        public Verb(string w, string def) : base(w, def)
        {
            VerbList.Add(word);
            VerbList.Add(definition);
        }

        public void print()
        {
            foreach (var x in VerbList)
            {
                Console.WriteLine(x);
            }
        }
    }
}

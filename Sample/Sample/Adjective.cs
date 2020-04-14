using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Adjective : Word
    {
        List<string> AdjList = new List<string>();

        public Adjective(string w, string def) : base(w, def)
        {
            AdjList.Add(word);
            AdjList.Add(definition);
        }

        public void print()
        {
            foreach (var x in AdjList)
            {
                Console.WriteLine(x);
            }
        }
    }
}

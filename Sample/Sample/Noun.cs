using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Noun : Word
    {

        List<string> NounList = new List<string>();

        public Noun(string w, string def) : base(w,def)
        {
            NounList.Add(word);
            NounList.Add(definition);
        }

        public void print()
        { 
        foreach (var x in NounList)
            { 
                Console.WriteLine(x);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Miscellaneous : Word
    {
        List<string> MiscList = new List<string>();

        public Miscellaneous(string w, string def) : base(w, def)
        {
            MiscList.Add(word);
            MiscList.Add(definition);
        }

        public void print()
        {
            foreach (var x in MiscList)
            {
                Console.WriteLine(x);
            }
        }
    }
}

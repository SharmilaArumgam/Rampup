using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Miscellaneous : IWord
    {
        string word;
        string definition;
        List<string> MiscList = new List<string>();

        public void Word(string w, string def)
        {
            word = w;
            definition = def;
            MiscList.Add(word);
            MiscList.Add(definition);
        }
    }
}

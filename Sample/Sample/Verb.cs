using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Verb : IWord
    {
        string word;
        string definition;
        List<string> VList = new List<string>();

        public void Word(string w, string def)
        {
            word = w;
            definition = def;
            VList.Add(word);
            VList.Add(definition);
        }
    }
}

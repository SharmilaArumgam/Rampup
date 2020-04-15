using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class ProperNoun : IWord
    {
        string word;
        string definition;
        List<string> ProList = new List<string>();

        public void Word(string w, string def)
        {
            word = w;
            definition = def;
            ProList.Add(word);
            ProList.Add(definition);
        }
    }
}

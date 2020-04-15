using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Preposition : IWord
    {
        string word;
        string definition;
        List<string> PreList = new List<string>();

        public void Word(string w, string def)
        {
            word = w;
            definition = def;
            PreList.Add(word);
            PreList.Add(definition);
        }
    }
}

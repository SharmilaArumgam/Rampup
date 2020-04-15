using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Adverb : IWord
    {
        string word;
        string definition;
        List<string> AdvList = new List<string>();

        public void Word(string w, string def)
        {
            word = w;
            definition = def;
            AdvList.Add(word);
            AdvList.Add(definition);
        }
    }
}

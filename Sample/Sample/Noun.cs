using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Noun : IWord
    {
        string word;
        string definition;
        List<string> NounList = new List<string>();

        public void Word(string w, string def)
        {
            word = w;
            definition = def;
            NounList.Add(word);
            NounList.Add(definition);
        }

    }
}

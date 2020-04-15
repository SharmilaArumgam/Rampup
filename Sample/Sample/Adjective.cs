using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Adjective : IWord
    {
        string word;
        string definition;
        List<string> AdjList = new List<string>();

        public void Word(string w, string def)
        {
            word = w;
            definition = def;
            AdjList.Add(word);
            AdjList.Add(definition);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Sample
{
    class Word
    {
        protected string word;
        protected string definition;
        List<string> list = new List<string>();

        public Word(string w, string def)
        {
            word = w;
            definition = def;
        }

        static void Main(string[] args)
        {
          List<string> wordlist = Dictionary.LoadWord();
            int i = 0;
            


            foreach (string line in wordlist)
            {
                string word = line;
                //Console.WriteLine(word);
                i++;

                switch (word)
                {
                    case "n":
                        string n = wordlist[i - 3];
                        string n1 = wordlist[i - 2];
                        Noun no = new Noun(n,n1);
                        no.print();
                        break;


                    case "misc":
                        string misc = wordlist[i - 3];
                        string misc1 = wordlist[i - 2];
                        Miscellaneous mis = new Miscellaneous(misc, misc1);
                        mis.print();
                        break;


                    case "adj":
                        string adj = wordlist[i - 3];
                        string adj1 = wordlist[i - 2];
                        Adjective ad = new Adjective(adj, adj1);
                        ad.print();
                        break;


                    case "v":
                        string v = wordlist[i - 3];
                        string v1 = wordlist[i - 2];
                        Verb ve = new Verb(v, v1);
                        ve.print();
                        break;

                    case "pn":
                        string pn = wordlist[i - 3];
                        string pn1 = wordlist[i - 2];
                        ProperNoun p = new ProperNoun(pn, pn1);
                        p.print();
                        break;

                    case "pr":
                        string pr = wordlist[i - 3];
                        string pr1 = wordlist[i - 2];
                        Preposition pe = new Preposition(pr, pr1);
                        pe.print();
                        break;

                    case "adv":
                        string adv = wordlist[i - 3];
                        string adv1 = wordlist[i - 2];
                        Adverb ae = new Adverb(adv, adv1);
                        ae.print();
                        break;
                }

            }
        }
    }
}
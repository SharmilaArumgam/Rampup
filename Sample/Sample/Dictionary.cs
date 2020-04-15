using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sample
{
    public class Dictionary
    {
        public static void Main(string[] args)
        {
            string filePath = @"D:\Test\test.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            int i = 0;

            foreach (string line in lines)
            {
                string word = line;
                //Console.WriteLine(word);
                i++;

                switch (word)
                {
                    case "n":
                        string n = lines[i - 3];
                        string n1 = lines[i - 2];
                        IWord no = new Noun();
                        no.Word(n,n1);
                        break;


                    case "misc":
                        string misc = lines[i - 3];
                        string misc1 = lines[i - 2];
                        IWord mis = new Miscellaneous();
                        mis.Word(misc, misc1);
                        break;


                    case "adj":
                        string adj = lines[i - 3];
                        string adj1 = lines[i - 2];
                        IWord ad = new Adjective();
                        ad.Word(adj, adj1);
                        break;


                    case "v":
                        string v = lines[i - 3];
                        string v1 = lines[i - 2];
                        IWord ve = new Verb();
                        ve.Word(v, v1);
                        break;

                    case "pn":
                        string pn = lines[i - 3];
                        string pn1 = lines[i - 2];
                        IWord p = new ProperNoun();
                        p.Word(pn, pn1);
                        break;

                    case "pr":
                        string pr = lines[i - 3];
                        string pr1 = lines[i - 2];
                        IWord pe = new Preposition();
                        pe.Word(pr, pr1);
                        break;

                    case "adv":
                        string adv = lines[i - 3];
                        string adv1 = lines[i - 2];
                        IWord ae = new Adverb();
                        ae.Word(adv, adv1);
                        break;
                }

            }
        }
    }
}
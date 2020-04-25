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

            List<Word> collection = new List<Word>();
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
                        Noun no = new Noun(n,n1);
                        collection.Add(no);
                        break;


                    case "misc":
                        string misc = lines[i - 3];
                        string misc1 = lines[i - 2];
                        Miscellaneous mis = new Miscellaneous(misc, misc1);
                        collection.Add(mis);
                        break;


                    case "adj":
                        string adj = lines[i - 3];
                        string adj1 = lines[i - 2];
                        Adjective ad = new Adjective(adj, adj1);
                        collection.Add(ad);
                        break;


                    case "v":
                        string v = lines[i - 3];
                        string v1 = lines[i - 2];
                        Verb ve = new Verb(v, v1);
                        collection.Add(ve);
                        break;

                    case "pn":
                        string pn = lines[i - 3];
                        string pn1 = lines[i - 2];
                        ProperNoun p = new ProperNoun(pn, pn1);
                        collection.Add(p);
                        break;

                    case "pr":
                        string pr = lines[i - 3];
                        string pr1 = lines[i - 2];
                        Preposition pe = new Preposition(pr, pr1);
                        collection.Add(pe);
                        break;

                    case "adv":
                        string adv = lines[i - 3];
                        string adv1 = lines[i - 2];
                        Adverb ae = new Adverb(adv, adv1);
                        collection.Add(ae);
                        break;
                }

            }
        }
    }
}
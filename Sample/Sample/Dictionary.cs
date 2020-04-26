using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sample
{
    public static class Dictionary
    {
            static string filePath = @"D:\Test\dictionary.txt";
            static List<string> lines = File.ReadAllLines(filePath).ToList();
            

      public static List<Word> LoadWord()
        { 
            int i = 0;
            List<Word> collection = new List<Word>();
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
                        string n2 = lines[i - 1];
                        // Noun no = new Noun(n,n1);
                        collection.Add(new Word(n, n1, n2));
                        break;


                    case "misc":
                        string misc = lines[i - 3];
                        string misc1 = lines[i - 2];
                        string misc2= lines[i - 1];
                        Miscellaneous mis = new Miscellaneous(misc, misc1, misc2);
                        collection.Add(mis);
                        break;


                    case "adj":
                        string adj = lines[i - 3];
                        string adj1 = lines[i - 2];
                        string adj2= lines[i - 1];
                        Adjective ad = new Adjective(adj, adj1, adj2);
                        collection.Add(ad);
                        break;


                    case "v":
                        string v = lines[i - 3];
                        string v1 = lines[i - 2];
                        string v2= lines[i - 1];
                        Verb ve = new Verb(v, v1, v2);
                        collection.Add(ve);
                        break;

                    case "pn":
                        string pn = lines[i - 3];
                        string pn1 = lines[i - 2];
                        string pn2= lines[i - 1];
                        ProperNoun p = new ProperNoun(pn, pn1, pn2);
                        collection.Add(p);
                        break;

                    case "pr":
                        string pr = lines[i - 3];
                        string pr1 = lines[i - 2];
                         string pr2= lines[i - 1];
                        Preposition pe = new Preposition(pr, pr1, pr2);
                        collection.Add(pe);
                        break;

                    case "adv":
                        string adv = lines[i - 3];
                        string adv1 = lines[i - 2];
                        string adv2= lines[i - 1];
                        Adverb ae = new Adverb(adv, adv1, adv2);
                        collection.Add(ae);
                        break;
                }

            }
            return collection;
        }
    }
}
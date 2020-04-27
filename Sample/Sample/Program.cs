﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Sample
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an option from 1-4");
            int choice = Convert.ToInt32(Console.ReadLine());
            List<Word> collection = Dictionary.LoadWord();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a word to search in dictionary:");
                    string res = Console.ReadLine().ToLower();
                    IEnumerable<Word> result = collection.Where(s => s.word.ToLower().Contains(res));
                    foreach (var s in result)
                    {
                        Console.WriteLine("{0}", s.word);
                        Console.WriteLine("{0}", s.definition);
                        Console.WriteLine("{0}", s.type);
                    }
                    break;
                case 2:
                        Console.WriteLine("Number of words in each type:");
                        IEnumerable<Word> ncount = collection.Where(s => s.type == "n");
                        Console.WriteLine("Noun:{0}", ncount.Count());
                        IEnumerable<Word> pncount = collection.Where(s => s.type == "pn");
                        Console.WriteLine("Proper Noun:{0}", pncount.Count());
                        IEnumerable<Word> mcount = collection.Where(s => s.type == "misc");
                        Console.WriteLine("Miscellaneous:{0}", mcount.Count());
                        IEnumerable<Word> adjcount = collection.Where(s => s.type == "adj");
                        Console.WriteLine("Adjective:{0}", adjcount.Count());
                        IEnumerable<Word> vcount = collection.Where(s => s.type == "v");
                        Console.WriteLine("Verb:{0}", vcount.Count());
                        IEnumerable<Word> prcount = collection.Where(s => s.type == "prep");
                        Console.WriteLine("Preposition:{0}", prcount.Count());
                        IEnumerable<Word> adcount = collection.Where(s => s.type == "adv");
                        Console.WriteLine("Adverb:{0}", adcount.Count());
                    break;

            }
            
            
        }
    }
}
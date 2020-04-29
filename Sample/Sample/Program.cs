using System;
using System.Linq;
using System.Collections.Generic;

namespace Sample
{

    class Program
    {
        public static void getAnagram(string str, int f, int l)
        {
            if (f == l)
            {
                Console.WriteLine(str);
            }
            else
            {
                for (int i = f; i <= l; i++)
                {
                    str = swap(str, f, i);
                    getAnagram(str, f + 1, l);
                   // str = swap(str, f, i);
                }
            }
        }
            public static String swap(String a,
                              int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                string s = new string(charArray);
                return s;
            }

            public static void Main(string[] args)
        {
            List<Word> collection = Dictionary.LoadWord();
            Console.WriteLine("Enter an option from 1-4");
            Console.WriteLine("1) Definition of a word");
            Console.WriteLine("2) Number of words of each type");
            Console.WriteLine("3) Anagram of a word");
            Console.WriteLine("4) Scrabble Score for a word");
            int choice = Convert.ToInt32(Console.ReadLine());
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

                case 3:
                    Console.WriteLine("Enter a word to find anagrams:");
                    string word = Console.ReadLine();
                    int n = word.Length;
                    //Console.WriteLine(n);
                    getAnagram(word, 0, n - 1);
                    break;

                case 4:
                    Console.WriteLine("Enter a word to find the scrabble score:");
                    break;

            }
            
            
        }
    }
}
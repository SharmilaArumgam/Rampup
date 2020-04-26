using System;
using System.Linq;
using System.Collections.Generic;

namespace Sample
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to search in Dictionary:");
            string res = Console.ReadLine();
            IEnumerable<Word> result = Dictionary.LoadWord().Where(s => s.word == res);
            foreach (var s in result)
            {
                Console.WriteLine("{0}", s.word);
                Console.WriteLine("{0}", s.definition);
                Console.WriteLine("{0}", s.type);
            }
            
        }
    }
}
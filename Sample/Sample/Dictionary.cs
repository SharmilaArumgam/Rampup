using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Sample
{
    static class Dictionary
    {

        public static List<string> LoadWord()
        {
            string filePath = @"D:\Test\dictionary.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            return lines;
        }
    }
}
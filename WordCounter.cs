using System;
using System.Linq;

namespace Programm4711
{
    public class WordCounter
    {
        public int CountWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            input = input.Replace(" -", " ");
            input = input.Replace("\r\n", " ");

            var k = input.Split('_', ' ', ',', '!', '?').Where(elem => elem != "").ToArray();

            return k.Length;
        }
    }
}
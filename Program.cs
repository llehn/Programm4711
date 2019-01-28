using System;
using System.IO;
using System.Linq;

namespace Programm4711
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = args.First();
            string readText = File.ReadAllText(path);
            var sut = new WordCounter();
            var wordCount = sut.CountWords(readText);
            System.Console.WriteLine($"Es sind {wordCount} Wörter");
        }
    }
}
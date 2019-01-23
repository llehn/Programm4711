using System;
using System.IO;

namespace Programm4711
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "lol.txt";
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);
        }
    }
}

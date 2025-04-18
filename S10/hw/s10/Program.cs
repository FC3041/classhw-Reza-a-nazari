namespace s10;

using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length > 2 || args.Length < 1)
        {
            Console.WriteLine("Usage: program.exe <input_file> [out_file]");
            return;
        }

        string outFile = null;
        if (args.Length > 1)
        {
            outFile = args[1];
        }

        int lineCount = 0, charCount = 0, wordCount = 0;
        StringBuilder sb = new StringBuilder();

        foreach (string line in File.ReadLines(args[0]))
        {
            lineCount++;
            charCount += line.Length;
            wordCount += line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        }

        Console.WriteLine($"{lineCount} {wordCount} {charCount}");

    }
}

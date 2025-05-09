namespace S10con; //using /streamreader / streamwriter / stopwatch / thread / GC.collect() / RAII / {get ; set ;}

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int linecount = 0;
        int charCount = 0;
        int wordCount = 0;
        string line;

        // مسیر فایل را مشخص کنید
        string filePath = "mtext.txt";
        
        StreamReader reader = null;
        try
        {
            reader = new StreamReader(filePath);
            while ((line = reader.ReadLine()) != null)
            {
                linecount++;
                foreach (string s in line.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                {
                    wordCount++;
                    charCount += s.Length;
                }
            }
        }
        finally
        {
            if (reader != null)
            {
                reader.Dispose();
            }
        }

        System.Console.WriteLine($"Lines: {linecount}, Words: {wordCount}, Characters: {charCount}");
    }
}

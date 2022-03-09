using ExHashSet.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace ExHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                        
                    }
                    Console.Write($"Total users: {set.Count}");
                }

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
    }
}

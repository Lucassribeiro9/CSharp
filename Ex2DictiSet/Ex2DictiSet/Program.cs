using System;
using System.Collections.Generic;
using System.IO;

namespace Ex2DictiSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    while (!sr.EndOfStream)
                    {
                        string[] irRecord = sr.ReadLine().Split(',');
                        string functionary = irRecord[0];
                        int declarations = int.Parse(irRecord[1]);
                        if (dictionary.ContainsKey(functionary))
                        {
                            dictionary[functionary] += declarations;
                        }
                        else
                        {
                            dictionary[functionary] = declarations;
                        }
                    }
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                }

            }
            catch (IOException err)
            {
                Console.WriteLine($"An error occured: {err.Message}");
            }
        }
    }
}

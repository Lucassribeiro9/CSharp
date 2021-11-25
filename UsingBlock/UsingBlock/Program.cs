using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\ESD\teste.txt";
            try
            {

                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }

            }
            catch (IOException err)
            {
                Console.WriteLine($"Ocorreu um erro. Erro: {err.Message}");
            }

        }
    }
}

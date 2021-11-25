using System;
using System.IO;

namespace Streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\ESD\teste.txt";
            string targetPath = @"C:\ESD\teste3.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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

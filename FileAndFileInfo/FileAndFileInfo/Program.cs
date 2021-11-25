using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\ESD\teste.txt"; // origem
            string targetPath = @"C:\ESD\teste2.txt"; // destino
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException err)
            {

                Console.WriteLine($"Um erro ocorreu! Erro: {err.Message}");
            }
        }
    }
}

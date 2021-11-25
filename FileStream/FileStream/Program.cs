using System;
using System.IO;

namespace FileStreamfs
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\ESD\teste.txt";
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) // para ler todas as linhas do arquivo
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
               
            }
            catch (IOException err)
            {
                Console.WriteLine($"Ocorreu um erro! Erro: {err.Message}");

            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}

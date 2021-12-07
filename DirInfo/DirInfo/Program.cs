using System;
using System.IO;
using System.Collections.Generic;

namespace DirInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\ESD";
            try
            {
                // lista as pastas
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders"); 
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                // lista os arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                foreach (string t in files) 
                {
                    Console.WriteLine(t);
                }
                // cria a pasta
                Directory.CreateDirectory(path + @"\Nova"); 
            }
            catch (IOException err)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(err.Message);
            }
        }
    }
}

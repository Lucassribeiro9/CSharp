using System;
using System.IO;

namespace PathProj
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\ESD\teste.txt";
            Console.WriteLine(Path.DirectorySeparatorChar); // caractere de separação
            Console.WriteLine($"Get Directory name: {Path.GetDirectoryName(path)}"); // nome do diretório
            Console.WriteLine("Path separator: " + Path.PathSeparator); // separador
            Console.WriteLine(Path.GetFileName(path)); // nome do arquivo
            Console.WriteLine(Path.GetFileNameWithoutExtension(path)); // sem extensão
            Console.WriteLine(Path.GetExtension(path)); // extensão
            Console.WriteLine(Path.GetFullPath(path));
            Console.WriteLine(Path.GetTempPath());
        }
    }
}

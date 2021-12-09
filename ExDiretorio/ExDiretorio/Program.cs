using ExDiretorio.Entities;
using System;
using System.Globalization;
using System.IO;

namespace ExDiretorio
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\ESD\docs\planilha.csv";

            try
            {
                string[] lines = File.ReadAllLines(path);
                var sourceFolderPath = Path.GetDirectoryName(path);
                var targetFolderPath = sourceFolderPath + @"\out";
                var targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = Convert.ToDouble(fields[1], CultureInfo.InvariantCulture);
                        int quantity = Convert.ToInt32(fields[2]);

                        Product prod = new Product(name, price, quantity);
                        sw.WriteLine($"{prod.Name}, {prod.Price.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }
            }
            catch (IOException err)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(err.Message);
            }
        }
    }
}

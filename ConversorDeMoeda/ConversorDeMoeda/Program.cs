using System;
using System.Globalization;

namespace ConversorDeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dólares você quer comprar?: ");
            double quantia = double.Parse(Console.ReadLine());

            double result = Conversor.Converter(quantia, cotacao);

            Console.WriteLine($"Valor a ser pago em reais: {result.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

using System;
using System.Globalization;

namespace ExMoeda2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolár: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos você vai comprar: ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ValorConvertido = Conversor.ConverterMoeda(dolar, quantidade);

            Console.Write($"Valor a ser pago em reais: ${ValorConvertido.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

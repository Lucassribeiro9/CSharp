using System;
using System.Globalization;

namespace Ex05Seq
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1, peca2, cod1, cod2;
            double ValorTotal, val1, val2;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            peca1 = int.Parse(valores[1]);
            val1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            peca2 = int.Parse(valores[1]);
            val2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            ValorTotal = val1 * peca1 + val2 * peca2;

            Console.WriteLine($"Valor a pagar: R$ {ValorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}

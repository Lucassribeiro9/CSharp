using System;
using System.Globalization;

namespace ExStaticMembers
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine($"Dados: {circ.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {volume.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        
    }
}

using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calcular.Circunferencia(raio);
            double volume = Calcular.Volume(raio);

            Console.WriteLine($"PI: {Calcular.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Raio: {circ.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

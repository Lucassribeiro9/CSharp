using System;
using System.Globalization;

namespace ClassTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangulo tri = new Triangulo();
            Console.WriteLine("Entre com a largura e altura do triangulo:");
            tri.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            tri.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Área: {tri.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro: {tri.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal: {tri.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

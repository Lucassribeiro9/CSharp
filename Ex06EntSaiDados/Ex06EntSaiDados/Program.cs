using System;
using System.Globalization;

namespace Ex06EntSaiDados
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, trapezio, triangulo, circulo, quadrado, retangulo;

            string[] valores = Console.ReadLine().Split(' '); // da SPACE e digite todos os números, senão dará erro
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2.0;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine($"Triangulo: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        }
    }
}

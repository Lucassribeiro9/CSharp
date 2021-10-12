using System;

namespace ExClassTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo p = new Triangulo();
            Triangulo a = new Triangulo();
            Console.WriteLine("Entre com largura e altura do triângulo: ");
            a.Largura = double.Parse(Console.ReadLine());
            a.Altura = double.Parse(Console.ReadLine());



            Console.WriteLine();
            Console.WriteLine($"Area: {a.Area()}");

            Console.WriteLine();
            Console.WriteLine("Entre com os lados do triângulo: ");
            p.LadoA = double.Parse(Console.ReadLine());
            p.LadoB = double.Parse(Console.ReadLine());
            p.LadoC = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Perímetro: {p.Perimetro()}");
            Console.WriteLine($"Diagonal: {a.Diagonal()}");

        }
    }
}

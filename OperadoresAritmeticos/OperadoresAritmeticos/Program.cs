using System;

namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0;
            double b = -3.0;
            double c = -4.0;

            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine("Equação de 2º grau");


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }
    }
}

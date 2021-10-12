using System;

namespace ClassReturnStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();
            double areaX, areaY, p;

            Console.WriteLine("Calcule a área dos triangulos!");
            Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = Convert.ToDouble(Console.ReadLine());
            x.B = Convert.ToDouble(Console.ReadLine());
            x.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = Convert.ToDouble(Console.ReadLine());
            y.B = Convert.ToDouble(Console.ReadLine());
            y.C = Convert.ToDouble(Console.ReadLine());

            p = (x.A + x.B + x.C) / 2;
            areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            if (areaX > areaY)
            {
                Console.WriteLine($"O triangulo X tem a área maior! Tamanho da área: {areaX}");
            }
            else
            {
                Console.WriteLine($"O triangulo Y tem a área maior! Tamanho da área: {areaY}");

            }
        }
    }
}

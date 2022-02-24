using HerancaInterface.Model.Entities;
using HerancaInterface.Model.Enums;
using System;

namespace HerancaInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle() { Radius = 2, Color = Color.White };
            IShape rectangle = new Rectangle() { Height = 3, Width = 4, Color = Color.Black };
            Console.WriteLine(circle);
            Console.WriteLine(rectangle);
        }
    }
}

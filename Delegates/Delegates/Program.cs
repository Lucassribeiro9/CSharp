using System;
using Delegates.Services;

namespace Delegates
{
    class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2); // referencia da função
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServices.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}

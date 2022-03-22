using System;
using Delegates.Services;

namespace Delegates
{
    class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2); // referencia da função
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServices.ShowSum;
            op += CalculationServices.ShowMax; // delegate agora guarda a referencia para duas funções
            op.Invoke(a, b);
            
        }
    }
}

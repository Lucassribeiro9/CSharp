using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Nullable<double> x; // valor nulo da variavel

            double? x = null; // o ? indica que a variavel é opcional
            double? y = 10;
            double z = x ?? 1; // operador de coalescência nula: se x não for nulo, a variavel recebe o valor, se for, é atribuido o valor colocado após o sinal

            Console.WriteLine(x.GetValueOrDefault()); // mostra valor atribuido a variavel ou valor padrao
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // mostra se há um valor na variavel
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
            Console.WriteLine(x.Value); //pega o valor da variavel (dara erro se chamar a partir de um objeto nulo)
            else
            Console.WriteLine("X é nulo");

            Console.WriteLine(z);
        }
    }
}

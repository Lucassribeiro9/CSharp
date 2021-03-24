using System;

namespace Ex04EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Código do funcionário: ");
            int codfunc = int.Parse(Console.ReadLine());
            Console.Write("Número de horas trabalhadas: ");
            double HorasTrab = double.Parse(Console.ReadLine());
            Console.Write("Valor da hora trabalhada: ");
            double ValorHora = double.Parse(Console.ReadLine());

            double salario = HorasTrab * ValorHora;

            Console.WriteLine($"Dados do funcionário nº {codfunc} :");
            Console.WriteLine($"Horas trabalhadas: {HorasTrab}");
            Console.WriteLine("Salário: " + salario.ToString("F2") + " reais");
        }
    }
}

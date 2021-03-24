using System;
using System.Globalization;

namespace ClassSalarioEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Salario s = new Salario();
            Console.WriteLine("Entre com os dados do funcionário: ");
            Console.Write("Nome: ");
            s.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            s.SalBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            s.Imposto = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Dados do funcionário: {s}");
            Console.WriteLine("Digite a porcentagem de aumento de salário: ");
            double bonus = double.Parse(Console.ReadLine());
            s.AumentarSalario(bonus);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + s);
        }
    }
}

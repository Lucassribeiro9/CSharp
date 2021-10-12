using System;

namespace ExClassSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Salario func = new Salario();
            Console.WriteLine("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Descontos: ");
            func.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Funcionário: {func.Nome}, {func.SalarioLiquido()}");
            Console.WriteLine("Digite a porcentagem de aumento: ");
            double percent = double.Parse(Console.ReadLine());
            func.AumentoSalario(percent);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {func.Nome}, {func.SalarioLiquido()}");

        }
    }
}

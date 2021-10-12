using System;
using System.Collections.Generic;
using System.Globalization;

namespace NewListaPtBr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos empregados você deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());
            List<Empregado> list = new List<Empregado>();

            for (int i = 1; i <= n ; i++)
            {
                Console.WriteLine($"Empregado #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregado(id, nome, salario));

            }

            Console.WriteLine();
            Console.Write("Entre com o ID do empregado que terá um aumento: ");
            int buscaId = int.Parse(Console.ReadLine());
            Empregado emp = list.Find(x => x.ID == buscaId);
            if (emp != null)
            {
                Console.Write("Entre com a porcentagem de aumento: ");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoSalario(quantia);
            }
            else
            {
                Console.WriteLine("O ID não existe!");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de empregados:");
            foreach (Empregado func in list)
            {
                Console.WriteLine(func);
            }
        }
    }
}

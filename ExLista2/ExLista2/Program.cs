using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExLista2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Quantos funcionários você irá registrar?");
            int n = int.Parse(Console.ReadLine());
            List<Empregados> list = new List<Empregados>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Empregado #{i}: ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Empregados(id, nome, salario));
                Console.WriteLine();
            }
            // char op = 'N';
            // while (op == 'S')
          //  {
                Console.WriteLine("Digite o ID do funcionário que terá reajuste salarial: ");
                int searchId = int.Parse(Console.ReadLine());
                Empregados emp = list.Find(x => x.Id == searchId);
                if (emp != null)
                {
                    Console.WriteLine("Você deseja aumentar o salário? S/N: ");
                    char opcao = char.Parse(Console.ReadLine());
                    if (opcao == 'S')
                    {
                        Console.WriteLine("Digite a porcentagem de aumento: ");
                        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        emp.AumentoSalario(porcentagem);
                    }
                    else
                    {
                        Console.WriteLine("Digite a porcentagem de desconto: ");
                        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        emp.Descontos(porcentagem);
                    }
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("O ID não existe!");
                }
                Console.WriteLine();

                Console.WriteLine("Lista de empregados atualizada: ");
                foreach (Empregados obj in list)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
                Console.WriteLine("Deseja atualizar os dados salariais de outro funcionário? S/N");
                // to tentando fazer com que o bloco todo se repitachar op = char.Parse(Console.ReadLine(op));

           // }

        }
    }
}

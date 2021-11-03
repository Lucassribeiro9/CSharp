using ExHerancaPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PagadorImposto> list = new List<PagadorImposto>(); 
            
            Console.Write("Entre com o número de pagadores de impostos: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Pagador #{i}:");
                Console.WriteLine("Pessoa física ou jurídica (pf/pj)? ");
                string tipo = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (tipo == "pf")
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                }
                else
                {
                    Console.Write("Número de empregados ");
                    int qteFunc = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(nome, rendaAnual, qteFunc));

                }
                
            }
            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("Pagadores de impostos: ");
            foreach (PagadorImposto p in list)
            {
                double tax = p.Imposto();
                Console.WriteLine($"{p.Nome}: ${p.Imposto().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine($"Total de taxas: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

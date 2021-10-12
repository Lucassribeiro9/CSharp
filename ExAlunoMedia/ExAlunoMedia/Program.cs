using System;

namespace ExAlunoMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            if (aluno.NotaFinal() >= 60)
            {
                Console.WriteLine();
                Console.WriteLine($"Nota final: {aluno.NotaFinal()}");
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine($"Nota final: {aluno.NotaFinal()}");
                Console.WriteLine("REPROVADO!");
                Console.WriteLine($"Faltaram {60 - aluno.NotaFinal()} pontos");
            }
        }
    }
}

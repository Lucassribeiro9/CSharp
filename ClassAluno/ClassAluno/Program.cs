using System;
using System.Globalization;


namespace ClassAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.PriTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.SegTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.TerTrimestre = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nota final: {aluno.MediaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (aluno.Aprovado())
            {
                Console.WriteLine("APROVADO!");
            }
            else
            {
                Console.WriteLine($"REPROVADO! Faltaram {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} pontos.");
            }
        }
    }
}

using System;

namespace Ex04Cond
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int HoraInicial = int.Parse(valores[0]);
            int HoraFinal = int.Parse(valores[1]);

            int duracao;
            if(HoraInicial < HoraFinal)
            {
                duracao = HoraFinal - HoraInicial;
            }
            else
            {
                duracao = 24 - HoraInicial + HoraFinal;
            }
            Console.WriteLine($"O jogo durou {duracao} hora(s)!");
        }
    }
}

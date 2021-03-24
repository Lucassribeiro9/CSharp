using System;
using System.Globalization;

namespace EntSaiDados
{
    class Program
    {
        static void Main(string[] args)
        {
           // int n1 = int.Parse(Console.Readline()); - pra converter os dados digitados
            
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Boa noite!");
            Console.WriteLine("Esses são os nossos produtos!");
            Console.WriteLine($"{produto1}, cujo o preço é ${preco1}");
            Console.WriteLine($"{produto2}, cujo o preço é ${preco2}");
            Console.WriteLine($"Registro: {idade} anos, código {codigo} e gênero: {genero}");
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado: " + medida.ToString("F3"));
            Console.WriteLine("Separador de decimal: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

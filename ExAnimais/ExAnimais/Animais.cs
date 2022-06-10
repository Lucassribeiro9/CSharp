using System;
using System.Collections.Generic;
using System.Text;

namespace ExAnimais
{
    class Animais
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        public Animais()
        {
        }

        public Animais(string nome, string especie)
        {
            Nome = nome;
            Especie = especie;
        }

        public void VerificarEspecie()
        {
            if (Especie == "Gato" || Especie == "Cachorro")
            {
                Console.WriteLine(Especie);
            }
            else
            {
                Console.WriteLine("É um peixe");
            }
        }
    }

}

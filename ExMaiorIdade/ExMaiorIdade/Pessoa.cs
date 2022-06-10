using System;
using System.Collections.Generic;
using System.Text;

namespace ExMaiorIdade
{
    class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;
        }
        public override string ToString()
        {
            return "Nome: " + Nome + ", Idade: " + Idade;
        }
    }


}

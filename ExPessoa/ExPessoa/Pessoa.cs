using System;
using System.Collections.Generic;
using System.Text;

namespace ExPessoa
{
    class Pessoa
    {
        public string Nome;
        public DateTime DataNasc { get; set; }
        public float Altura { get; set; }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - DataNasc.Year;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExHerancaPolimorfismo.Entities
{
    abstract class PagadorImposto
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public PagadorImposto()
        {
        }

        public PagadorImposto(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double Imposto();
       
    }
}

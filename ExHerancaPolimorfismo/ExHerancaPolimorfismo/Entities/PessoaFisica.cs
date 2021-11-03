using System;
using System.Collections.Generic;
using System.Text;

namespace ExHerancaPolimorfismo.Entities
{
    class PessoaFisica : PagadorImposto
    {
        
        public double GastosSaude { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
           
            GastosSaude = gastosSaude;
        }

       

        public override double Imposto()
        {
            if (RendaAnual < 20000)
            {
                return RendaAnual * 0.15 - GastosSaude * 0.5;
            }
            else
            {
                return RendaAnual * 0.25 - GastosSaude * 0.5;
            }
        }
    }
}

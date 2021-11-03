using System;
using System.Collections.Generic;
using System.Text;

namespace ExHerancaPolimorfismo.Entities
{
    class PessoaJuridica : PagadorImposto
    {
        public int QteFunc { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int qteFunc) : base(nome, rendaAnual)
        {
            QteFunc = qteFunc;
        }
        public override double Imposto()
        {
             
            
            if (QteFunc > 10)
            {
                
                return RendaAnual * 0.14;
            }
            else
            {
                
                return RendaAnual * 0.16;
            }
            
        }
    }
}

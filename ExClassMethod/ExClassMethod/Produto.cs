using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExClassMethod
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

       
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        } 
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, " +
            "Total: $"  + ValorTotalEmEstoque();
        }
    }
}

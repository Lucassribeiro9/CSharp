using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ClassProduto
{
    class Produto
    {
        // nome de classe e atributo começa com letra maiuscula
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos (int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade
                + " unidades, Total: $ " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

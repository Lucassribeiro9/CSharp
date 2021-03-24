using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConstrutorThis
{
    class Properties
    {
        public string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Properties()
        {
            
        }
        public Properties(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome // aqui você constrói a classe encapsulada e chama o atributo por completo
                           // value seria o parametro
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        /*é possível criar lógicas a partir do encapsulamento, como o exemplo abaixo,
        onde foi criado a condição para não alterar o atributo se o valor for nulo ou menor que 1
        você consegue limitar o que o programa imprime*/






        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Preco
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

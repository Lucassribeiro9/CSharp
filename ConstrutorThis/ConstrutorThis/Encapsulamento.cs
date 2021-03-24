using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConstrutorThis
{
    class Encapsulamento
    {
        public string _nome;
        public double _preco;
        public int _quantidade;

        public Encapsulamento()
        {
            _quantidade = 0;
        }
        public Encapsulamento(string nome, double preco) : this() // construtor aproveitando o outro construtor
        {
            _nome = nome;
            _preco = preco;
        }
        
        public string Nome // aqui você constrói a classe encapsulada e chama o atributo por completo
            // value seria o parametro
        {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        
        public string GetNome()
        {
            return _nome;
        }
        /*é possível criar lógicas a partir do encapsulamento, como o exemplo abaixo,
        onde foi criado a condição para não alterar o atributo se o valor for nulo ou menor que 1
        você consegue limitar o que o programa imprime*/

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
                
        }
        public double Preco
        {
            get { return _preco; }
        }
        
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQte()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _preco
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

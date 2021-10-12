using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExConstrutorNew
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Conta(int conta, string nome)
        {
            NumConta = conta;
            Nome = nome;

        }

        public Conta(int numConta, string nome, double depositoInicial) : this(numConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
           Saldo += quantia;
        }
        public void Saque(double quantia)
        {
           Saldo -= quantia + 5; // ou Saldo -= 5 na linha de baixo
        }

        public override string ToString()
        {
            return "Conta " + NumConta
            + ", Titular: "
            + Nome
            + ", Saldo: $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBanco
{
    class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        public int NumConta { get; private set; }


        public Conta(string titular, int numero)
        {
            Titular = titular;
            NumConta = numero;
        }
        public Conta(string titular, int numero, double depositoInicial) : this(titular, numero)
        {
           Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
        public void Saque(double quantia)
        {
            Saldo -= quantia - 5;
        }
        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

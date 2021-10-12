using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NewListaPtBr
{
    class Empregado
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregado(int iD, string nome, double salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario (double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public override string ToString()
        {
            return ID + ", "+ Nome + ", "+ Salario.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}

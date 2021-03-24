using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace ExLista2
{
    class Empregados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregados(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * porcentagem / 100;
        }

        public void Descontos(double porcentagem) 
        {
            Salario -= Salario * porcentagem / 100;
        }
        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

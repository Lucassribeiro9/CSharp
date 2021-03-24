using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ClassSalarioEx
{
    class Salario
    {
        // nome de classe e atributo começa com letra maiuscula
        public string Nome;
        public double SalBruto;
        public int Imposto;

        public double SalarioLiquido()
        {
            return SalBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalBruto = SalBruto + (SalBruto * porcentagem / 100);
        }
        
        public override string ToString()
        {
            return Nome + ", Salário Líquido: $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

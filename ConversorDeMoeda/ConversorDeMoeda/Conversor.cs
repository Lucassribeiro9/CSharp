using System;
using System.Collections.Generic;
using System.Text;

namespace ConversorDeMoeda
{
    class Conversor
    {
        public static double Iof = 6.0;

        public static double Converter(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}

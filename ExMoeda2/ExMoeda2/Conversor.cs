using System;
using System.Collections.Generic;
using System.Text;

namespace ExMoeda2
{
    class Conversor
    {
        public static double IoF = 6;
        

        public static double ConverterMoeda(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IoF / 100;
            
        }
    }

}

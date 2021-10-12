using System;
using System.Collections.Generic;
using System.Text;

namespace ExClassTriangulo
{
    class Triangulo
    {
        public double Largura;
        public double Altura;
        public double LadoA;
        public double LadoB;
        public double LadoC;


        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return LadoA + LadoB + LadoC;
        }
        
        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
        
    }
}

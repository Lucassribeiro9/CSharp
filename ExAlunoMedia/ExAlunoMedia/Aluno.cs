﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExAlunoMedia
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
    }
}
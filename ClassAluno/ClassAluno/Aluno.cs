using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ClassAluno
{
    class Aluno
    {
        public string Nome;
        public double PriTrimestre;
        public double SegTrimestre;
        public double TerTrimestre;

        public double MediaFinal()
        {
            return PriTrimestre + SegTrimestre + TerTrimestre;
        }
        public bool Aprovado()
        {
            if (MediaFinal() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60.0 - MediaFinal();
            }
        }
    }
}

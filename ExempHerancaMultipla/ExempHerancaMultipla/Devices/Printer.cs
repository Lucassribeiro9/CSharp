using System;
using System.Collections.Generic;
using System.Text;

namespace ExempHerancaMultipla.Devices
{
    class Printer : Device
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Printer processing: " + doc);
        }

        public void Print(string doc)
        {
            Console.WriteLine("Printer print " + doc);
        }
    }
}

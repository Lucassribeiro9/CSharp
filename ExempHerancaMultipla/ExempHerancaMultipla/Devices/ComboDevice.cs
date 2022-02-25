using System;
using System.Collections.Generic;
using System.Text;

namespace ExempHerancaMultipla.Devices
{
    class ComboDevice : Device, IScanner, IPrinter
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Combo Device processing " + doc);
        }
        public string Scan()
        {
            return "Combo Device scan result";
        }
        public void Print(string doc)
        {
            Console.WriteLine("Combo Device print" + doc);
        }
    }
}

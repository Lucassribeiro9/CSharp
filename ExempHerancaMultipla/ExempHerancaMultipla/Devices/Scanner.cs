using System;
using System.Collections.Generic;
using System.Text;

namespace ExempHerancaMultipla.Devices
{
    class Scanner : Device
    {
        public override void ProcessDoc(string doc)
        {
            Console.WriteLine("Scanner processing: " + doc);
        }

        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}

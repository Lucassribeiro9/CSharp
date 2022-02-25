using System;
using System.Collections.Generic;
using System.Text;

namespace ExempHerancaMultipla.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc); 
    }
}

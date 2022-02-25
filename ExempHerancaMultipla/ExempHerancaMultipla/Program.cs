using ExempHerancaMultipla.Devices;
using System;

namespace ExempHerancaMultipla
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("My letter");
            Scanner s = new Scanner() { SerialNumber = 200 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace NewVectEx3
{
    class Runners
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public Runners(string name, string country)
        {
            Name = name;
            Country = country;
        }
        public override string ToString()
        {
            return Name + ", " + Country;
        }
    }
}

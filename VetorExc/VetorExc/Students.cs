using System;
using System.Collections.Generic;
using System.Text;

namespace VetorExc
{
    class Students
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Students(string nome, string email)
        {
            Name = nome;
            Email = email;

        }
        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}

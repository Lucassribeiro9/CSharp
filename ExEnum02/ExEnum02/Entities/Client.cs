using System;
using System.Collections.Generic;
using System.Text;

namespace ExEnum02.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client() // construtor padrão
        {

        }

        public Client(string name, string email, DateTime birthDate) // com sobrecarga
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
            return Name
                + ", ("
                + BirthDate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}

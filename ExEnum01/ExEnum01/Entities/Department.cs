﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExEnum01.Entities
{
    class Department
    {
        public string Name { get; set; }

        public Department() // construtor padrão
        {

        }

        public Department(string name) // construtor com argumentos
        {
            Name = name;
        }
    }
}

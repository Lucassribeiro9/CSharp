using HerancaInterface.Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HerancaInterface.Model.Entities
{
   abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}

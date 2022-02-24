using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HerancaInterface.Model.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return "Rectangle color = " + Color + ", Area = " + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

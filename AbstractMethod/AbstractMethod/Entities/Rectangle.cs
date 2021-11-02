using AbstractMethod.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractMethod.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height) : base (color)
        {
            Width = width;
            Height = height;
        }

        public override double Area() // no caso do método abstrato, o override é automático
        {
          return Width * Height;
        }
    }
}

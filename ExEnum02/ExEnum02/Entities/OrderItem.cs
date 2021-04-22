using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExEnum02.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        public OrderItem() // construtor padrão
        {

        }

        public OrderItem(int quantity, double price, Product product) // com sobrecarga
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal() // não houve necessidade de colocar os argumentos dentro de parenteses neste caso
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

using NewEnum.Entities;
using NewEnum.Entities.Enums;
using System;

// mesmos exercícios, devido ao hiato dos estudos

namespace NewEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order // input dos dados
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.Processing.ToString(); // converter para string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // de string para enumerado
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}

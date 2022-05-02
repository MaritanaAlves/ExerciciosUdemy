using System;
using _24_Exercicio_Enumeracoes.Entities;
using _24_Exercicio_Enumeracoes.Entities.Enums;

namespace _24_Exercicio_Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
        }
    }
}

﻿using CourseN.Entities;
using CourseN.Entities.Enums;
using System;

namespace CourseN
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PedingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}

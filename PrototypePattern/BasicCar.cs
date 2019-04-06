﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public abstract class BasicCar
    {
        public string ModelName {get;set;}
        public int Price { get; set; }

        public static int SetPrice()
        {
            var price = 0;
            var random = new Random();
            var p = random.Next(200000, 500000);
            price = p;
            return price;
        }

        public abstract BasicCar Clone();

    }
}

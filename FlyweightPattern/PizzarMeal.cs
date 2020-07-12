using System;
using System.Collections.Generic;

namespace FlyweightPattern
{
    public class PizzarMeal : IMealFlyweight
    {
        public PizzarMeal()
        {
            Name = "Pizza Meals";
        }

        public string Name { get; }

        public void Serve(string size)
        {
            Console.WriteLine($"Served {Name} - {size}");
        }
    }
}
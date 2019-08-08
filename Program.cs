using System;
using System.Collections.Generic;

namespace Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitchen = new Kitchen(); //initiating the kitchen, basement (object, because the class/blueprint exist elsewhere)
            var basement = new Basement();      


            Console.WriteLine(kitchen.Bake(new Pot( " the small pot"), 350));
            Console.WriteLine(kitchen.Wash(new Soap(" lavender")));

            var foods = new List<Food>();
            foods.Add(new Food("Pizza"));
            foods.Add(new Food("Cheese"));

            kitchen.Chill(foods);
            


            
            //kitchen.Chill(new List<Food>()
            //      { new Food("Pizza"),
            //       new Food("Sandwich") });
        
        }
    }
}

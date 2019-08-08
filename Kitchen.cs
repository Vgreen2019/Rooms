using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    class Kitchen : ISink, IOven, IFridge
    {
        public string Bake(Pot pot, int temp)
        {
            return $"Cooking{pot.Name} at {temp}";
        }

        public void Chill(IList<Food> foods)
        {
            foreach (var food in foods)
            {
                Console.WriteLine($"I am chilling {food.Name}");
            }
        }

        public string Wash(Soap soap)
        {
            return $"I am washing my hands with {soap.Name}.";
        }
    }
}

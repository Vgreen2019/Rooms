using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    class Basement : IFridge, ISink, IWashingMachine
    {
        public void Chill(IList<Food> foods)
        {
            foreach (var food in foods)
            {
                Console.WriteLine($"I am chilling {food.Name}");
            }
        }

        public string Wash(Soap soap)
        {
            return ($"I am washing clothes with {soap}");
        }

        public void WashClothes(List<Clothes> clothes)
        {
            foreach (var _clothes in clothes)
            {
                Console.WriteLine($"The {_clothes} have been washed!");
            }
        }
    }
}

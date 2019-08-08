using System;
using System.Collections.Generic;
using System.Text;

namespace Room
{
    interface IFridge
    {
        void Chill(IList<Food> foods);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCounter.BLL
{
    class FoodValidator
    {
        public bool IsNameValid(Food food)
        {
            return food.Name != null && food.Name.Length > 0;
        }

        public bool IsAmountValid(Food food)
        {
            return food.Amount > 0;
        }
    }
}

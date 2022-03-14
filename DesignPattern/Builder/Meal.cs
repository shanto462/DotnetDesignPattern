using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public class Meal
    {
        private List<IFood> foods = new List<IFood>();

        public void AddFood(IFood food)
        {
            foods.Add(food);
        }

        public double GetCost()
        {
            return foods.Sum(x => x.Price());
        }

        public void ShowFoods()
        {
            foreach (IFood food in foods)
            {
                Console.WriteLine(food.GetName());
            }
        }
    }
}

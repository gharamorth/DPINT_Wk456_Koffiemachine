using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    //base class for other Drinks.
    //not abstract, as you need to instantiate it.
    public class Drink :IDrink
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public Amount MilkAmount { get; set; }
        public Amount SugarAmount { get; set; }
        public Strength Strength { get; set; }

        public Drink(String name, Amount milkAmount, Amount sugarAmount, Strength strength)
        {
            Name = name;
            //Price = price;
            MilkAmount = milkAmount;
            SugarAmount = sugarAmount;
            Strength = strength;
        }

        public void LogDrinkMaking(ICollection<string> log)
        {
            log.Add($"Making {Name}...");
            log.Add("Heating up...");
        }
    }
}

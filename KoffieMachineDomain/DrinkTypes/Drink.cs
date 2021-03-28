using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public abstract class Drink :IDrink
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public Amount MilkAmount { get; set; }
        public Amount SugarAmount { get; set; }


        public Drink()
        {
            Price = 1.0;
            Name = "Coffee";
        }

        public double GetPrice()
        {
            return Price;
        }        

        public virtual ICollection<String> LogDrinkMaking(ICollection<string> log)
        {
            log.Add($"Making {Name}...");
            log.Add($"Heating up...");
            return log;
        }
    }
}

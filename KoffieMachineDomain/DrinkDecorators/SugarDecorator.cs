using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkDecorators
{
    public class SugarDecorator :BaseDrinkDecorator
    {

        public SugarDecorator(IDrink drink) : base(drink)
        {
            drink.Price += 0.10;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add($"Setting sugar amount to {SugarAmount}.");
            log.Add("Adding sugar...");
        }
    }
}

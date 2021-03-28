using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkTypes
{
    public class IrishCoffee : BaseDrinkDecorator
    {
        public IrishCoffee(IDrink drink) : base(drink)
        {
            Name = "Irish Coffee";
            Price = 3.0;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add($"Making {Name}");
            log.Add("Adding Whisky");
        }
    }
}

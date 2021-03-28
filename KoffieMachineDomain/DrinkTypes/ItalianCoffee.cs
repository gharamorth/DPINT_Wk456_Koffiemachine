using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkTypes
{
    public class ItalianCoffee : BaseDrinkDecorator
    {
        public ItalianCoffee(IDrink drink) : base(drink)
        {
            Name = "Italian Coffee";
            Price = 4.0;//stuff is expensive
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add($"Making {Name}.");
            log.Add("Adding Amaretto.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkTypes
{
    public class SpanishCoffee : BaseDrinkDecorator
    {
        public SpanishCoffee(IDrink drink) : base(drink)
        {
            Name = "Spanish Coffee";
            Price = 3.80;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add($"Making {Name}.");
            log.Add("Adding Cointrue (personally prefer Liquor 43 though)");
            log.Add("Adding Cognac.");
            //this is why I don't just use a CognacDecorator and a CointrueDecorator.
        }
    }
}

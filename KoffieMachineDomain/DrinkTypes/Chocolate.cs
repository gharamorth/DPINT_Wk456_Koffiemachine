using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkTypes
{
    public class Chocolate : BaseDrinkDecorator
    {
        public Chocolate(IDrink drink) : base(drink)
        {
            Name = "Hot chocolate";
            Price = 1.0;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add($"Making {Name}.");
            log.Add($"Finished making {Name}");

        }
    }
}

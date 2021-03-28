using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class Coffee : BaseDrinkDecorator
    {
        public Coffee(IDrink drink) : base(drink)
        {
            Price = 1;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add($"Setting coffee strength to {Strength}.");
            log.Add("Filling with coffee...");
            //log.Add($"Finished making {Name}");
        }
    }
}

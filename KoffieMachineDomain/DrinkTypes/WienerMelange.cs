using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    //originally a subtype of Cappuccino...
    public class WienerMelange : BaseDrinkDecorator
    {

        public WienerMelange(IDrink drink) : base(drink)
        {
            Name = "Wiener Melagne";
            Price = 2.0;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);

            log.Add($"Setting coffee strength to {Strength}.");
            log.Add("Filling with coffee...");
            log.Add("Creaming milk...");
            log.Add("Adding milk to coffee...");
            log.Add($"Finished making {Name}");
        }
    }
}

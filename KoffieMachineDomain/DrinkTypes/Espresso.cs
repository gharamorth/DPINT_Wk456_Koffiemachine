using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class Espresso : BaseDrinkDecorator
    {

        public Espresso(IDrink drink) : base(drink)
        {
            Name = "Espresso";
            Price = 1.7;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            log.Add($"Setting coffee strength to {Strength.Strong}.");
            log.Add($"Setting coffee amount to {Amount.Few}.");
            log.Add("Filling with coffee...");
            //log.Add("Creaming milk...");
            //log.Add("Adding milk to coffee...");//That's just a capuccino.
            log.Add($"Finished making {Name}");
        }
    }
}

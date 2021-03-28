using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkTypes
{
    public class Tea : BaseDrinkDecorator
    {
        public Tea(IDrink drink) : base(drink)
        {
            Price = 0.5;
            Name = "Tea";
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add("Making tea...");
            log.Add("Finishing brewing tea");
        }
    }
}

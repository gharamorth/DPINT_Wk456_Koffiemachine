using KoffieMachineDomain.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkTypes
{
    public class Chocolate : ChocolateAdapter
    {
        public Chocolate(IDrink drink, bool isDeluxe = false) : base(drink)
        {//default false, otherwise I must pass this non-optional parameter...
            if (isDeluxe) chocolate.MakeDeluxe();
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
        }
    }
}

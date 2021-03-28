using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkDecorators
{
    public class MilkDecorator : BaseDrinkDecorator
    {

        public MilkDecorator(IDrink drink) :base(drink)
        {
            _nextDrink.Price += 0.15;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add($"Setting milk to {MilkAmount}.");
            log.Add("Adding milk...");
        }
    }
}

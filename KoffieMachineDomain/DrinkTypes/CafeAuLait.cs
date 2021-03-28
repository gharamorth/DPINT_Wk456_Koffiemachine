using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class CafeAuLait : BaseDrinkDecorator
    {
        public CafeAuLait(IDrink drink): base(drink)
        {
            Name = "Café au Lait";
        }

        public override double GetPrice()
        {
            return BaseDrinkPrice + 0.5;
        }

        public override ICollection<String> LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add("Filling half with coffee...");
            log.Add("Filling other half with milk...");
            log.Add($"Finished making {Name}");
            return log;
        }
    }
}

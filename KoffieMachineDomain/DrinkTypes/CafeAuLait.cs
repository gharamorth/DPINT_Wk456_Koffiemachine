using System.Collections.Generic;

namespace KoffieMachineDomain
{
    public class CafeAuLait : BaseDrinkDecorator
    {
        public CafeAuLait(IDrink drink): base(drink)
        {
            Name = "Café au Lait";
            Price = 1.50;
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add("Filling half with coffee...");
            log.Add("Filling other half with milk...");
            log.Add($"Finished making {Name}");
        }
    }
}

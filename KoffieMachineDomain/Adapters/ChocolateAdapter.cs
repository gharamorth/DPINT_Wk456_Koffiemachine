using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaAndChocoLibrary;

namespace KoffieMachineDomain.Adapters
{
    public class ChocolateAdapter : BaseDrinkDecorator
    {
        protected HotChocolate chocolate;

        public ChocolateAdapter(IDrink drink) : base(drink)
        {
            chocolate = new HotChocolate();
            Price = chocolate.Cost();
            Name = chocolate.GetNameOfDrink();
        }


        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            var steps = chocolate.GetBuildSteps().ToList();
            foreach(var step in steps)
            {
                log.Add(step);
            }
        }

    }
}

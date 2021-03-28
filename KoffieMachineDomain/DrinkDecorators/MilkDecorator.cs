using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkDecorators
{
    public class MilkDecorator : BaseDrinkDecorator
    {

        public MilkDecorator(IDrink drink, Amount milkAmount)
        {
            _nextDrink = drink;
            _nextDrink.Price += 0.15;

        }
    }
}

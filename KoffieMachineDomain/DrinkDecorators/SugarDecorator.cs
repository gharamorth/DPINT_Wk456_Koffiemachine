using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkDecorators
{
    public class SugarDecorator :BaseDrinkDecorator
    {

        public SugarDecorator(IDrink drink)
        {
            drink.Price += 0.10;
        }
    }
}

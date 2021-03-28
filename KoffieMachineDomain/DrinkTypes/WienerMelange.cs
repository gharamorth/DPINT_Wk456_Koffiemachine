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

        public WienerMelange()
        {
            Name = "Wiener Melagne";
        }

        public override double GetPrice()
        {
            return BaseDrinkPrice * 2;
        }
    }
}

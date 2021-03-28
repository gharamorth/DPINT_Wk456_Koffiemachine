using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain.DrinkDecorators
{
    public class CreamDecorator : BaseDrinkDecorator
    {
        //class used for speciality coffees (coffees with liquor and other ingredients)
        public CreamDecorator(IDrink drink) : base(drink)
        {
            //DPInt_Wk456.pdf does not mention cream price
        }

        public override void LogDrinkMaking(ICollection<string> log)
        {
            base.LogDrinkMaking(log);
            log.Add("Adding cream...");
        }
    }
}

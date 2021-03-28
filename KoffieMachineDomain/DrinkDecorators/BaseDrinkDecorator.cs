using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class BaseDrinkDecorator
    {
        protected IDrink _nextDrink;

        public virtual String Name { get => _nextDrink.Name; set => _nextDrink.Name = value; }
        public virtual double BaseDrinkPrice { get => _nextDrink.Price; set =>_nextDrink.Price = value; }
        public virtual Strength Strength { get; set; }
        public virtual Amount MilkAmount { get; set; }
        public virtual Amount SugarAmount { get; set; }

        public BaseDrinkDecorator(IDrink drink)
        {
            _nextDrink = drink;
        }

        public virtual double GetPrice()
        {
            return _nextDrink.GetPrice();
        }

        public virtual ICollection<String> LogDrinkMaking(ICollection<string> log)
        {
            return _nextDrink.LogDrinkMaking(log);
        }
    }
}

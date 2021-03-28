using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public class BaseDrinkDecorator :IDrink
    {
        protected IDrink _nextDrink;

        public virtual String Name { get => _nextDrink.Name; set => _nextDrink.Name = value; }
        public virtual Strength Strength { get => _nextDrink.Strength; set => _nextDrink.Strength = value; }
        public virtual Amount MilkAmount { get => _nextDrink.MilkAmount; set => _nextDrink.MilkAmount = value; }
        public virtual Amount SugarAmount { get => _nextDrink.SugarAmount; set => _nextDrink.SugarAmount = value; }
        public virtual double Price { get => _nextDrink.Price; set => _nextDrink.Price = value; }

        public BaseDrinkDecorator(IDrink drink)
        {
            _nextDrink = drink;
        }

        public virtual void LogDrinkMaking(ICollection<string> log)
        {
            _nextDrink.LogDrinkMaking(log);
        }
    }
}

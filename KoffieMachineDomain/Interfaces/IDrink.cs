﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoffieMachineDomain
{
    public interface IDrink
    {
        string Name { get; set; }
        double Price { get; set; }
        Amount MilkAmount { get; set; }
        Amount SugarAmount { get; set; }

        double GetPrice();

        ICollection<String> LogDrinkMaking(ICollection<string> log);
    }
}

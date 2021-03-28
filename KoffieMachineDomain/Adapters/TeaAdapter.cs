using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaAndChocoLibrary;

namespace KoffieMachineDomain.Adapters
{
    public class TeaAdapter : BaseDrinkDecorator
    {
        protected Tea tea;

        public TeaAdapter(IDrink drink) : base(drink)
        {
            Name = "Plain Tea";
            Price = 0.50;
            SugarAmount = (Amount)tea.AmountOfSugar;
        }

        //public List<String> getTeaNames()
        //{
        //    return (List<string>)new TeaBlendRepository().BlendNames;
        //}
    }
}

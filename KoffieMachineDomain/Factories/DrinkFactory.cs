using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoffieMachineDomain.DrinkDecorators;
using KoffieMachineDomain.DrinkTypes;

namespace KoffieMachineDomain.Factories
{
    public class DrinkFactory
    {
        //switches and such go here.    
        //no dictionary necessary as the unlike in the numberConverter project with a dropdown menu they're selected through buttons..
        //nothing instantiated like in the NUmberConverterFactory, so no constructor. The application does not keep a list of ready drinks.

        public IDrink CreateDrink(String name, Amount milkAmount, Amount sugarAmount, Strength strength)
        {//changed from BaseDrinkDecorator to IDrink due to speciality drinks
            IDrink drink = new Drink(name, milkAmount, sugarAmount, strength);

            switch (name)
            {
                case "Cafe au Lait":
                    return new CafeAuLait(drink);
                case "Capuccino":
                    return new Capuccino(drink);
                case "Coffee":
                    return new Coffee(drink);
                case "Hot Chocolate":
                    return new Chocolate(drink);
                case "Espresso":
                    return new Espresso(drink);
                case "Irish Coffee":
                    drink = new Coffee(drink);
                    drink = new IrishCoffee(drink);
                    drink = new CreamDecorator(drink);
                    drink = new SugarDecorator(drink);
                    return drink;
                case "Italian Coffee":
                    drink = new Coffee(drink);
                    drink = new ItalianCoffee(drink);
                    drink = new CreamDecorator(drink);
                    drink = new SugarDecorator(drink);
                    return drink;
                case "Spanish Coffee":
                    drink = new Coffee(drink);
                    drink = new SpanishCoffee(drink);
                    drink = new CreamDecorator(drink);
                    drink = new SugarDecorator(drink);
                    return drink;
                case "Wiener Melagne":
                    return new WienerMelange(drink);

                //InvalidArgument would make more sense but that requires some specific package.
                default: throw new InvalidOperationException("Invalid drink name argument argument passed to KoffiemachineDomain.Factories.DrinkFactory.CreateDrink");
            }

        }

        public IDrink AddSugar(IDrink drink)
        {
            return new SugarDecorator(drink);
        }

        public IDrink AddMilk(IDrink drink)
        {
            return new MilkDecorator(drink);
        }

        public IDrink AddSugarAndMilk(IDrink drink)
        {
            return AddMilk(AddSugar(drink));
        }
    }
}

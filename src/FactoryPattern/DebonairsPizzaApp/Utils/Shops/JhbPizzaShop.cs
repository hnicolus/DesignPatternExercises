using DebonairsPizzaApp.Utils.Common.Interfaces;
using DebonairsPizzaApp.Utils.Ingredients;
using DebonairsPizzaApp.Utils.Ingredients.Sauces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebonairsPizzaApp.Utils.Shops
{
    public class JhbPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new NickCheese();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new SekwadiSauce();
        }

        public string[] CreateVeggies()
        {
            return new[] { "Onions" };
        }
    }

    public class JhbPizzaShop : PizzaShop
    {
        public JhbPizzaShop()
        {
            Factory = new JhbPizzaIngredientFactory();
        }
    }
}

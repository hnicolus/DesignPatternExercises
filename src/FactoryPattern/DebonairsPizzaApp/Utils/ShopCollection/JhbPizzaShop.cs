using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebonairsPizzaApp.Utils.ShopCollection
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

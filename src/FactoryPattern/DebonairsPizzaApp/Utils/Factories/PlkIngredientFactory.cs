using DebonairsPizzaApp.Utils.Common.Interfaces;
using DebonairsPizzaApp.Utils.Ingredients;
using DebonairsPizzaApp.Utils.Ingredients.Sauces;

namespace DebonairsPizzaApp.Utils.Factory
{
    public class PlkIngredientFactory : IPizzaIngredientFactory
    {

        public Cheese CreateCheese()
        {
            return new SuzanneKingCheese();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new SekwadiSauce();
        }

        public string[] CreateVeggies()
        {
            return new[] { "Onions", "beans", "Carrots" };
        }
    }
}

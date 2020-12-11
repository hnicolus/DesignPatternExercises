using DebonairsPizzaApp.Utils.Ingredients;
using DebonairsPizzaApp.Utils.Ingredients.Sauces;

namespace DebonairsPizzaApp.Utils.Common.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        string[] CreateVeggies();
        Cheese CreateCheese();

    }
}

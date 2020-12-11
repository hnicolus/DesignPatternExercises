using DebonairsPizzaApp.Utils.Common.Interfaces;

namespace DebonairsPizzaApp.Utils.PizzaCollection
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory factory)
            : base(factory)
        {

            Name = "Cheese Pizza";
        }


    }


}

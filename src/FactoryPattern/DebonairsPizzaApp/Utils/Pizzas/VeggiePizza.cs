using DebonairsPizzaApp.Utils.Common.Interfaces;

namespace DebonairsPizzaApp.Utils.PizzaCollection
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory factory) : base(factory)
        {
            Name = "Veggie Pizza";
        }

    }


}

namespace DebonairsPizzaApp.Utils.PizzaCollection
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IPizzaIngredientFactory factory) : base(factory)
        {
            Name = "Pepperoni Pizza";
        }


    }


}

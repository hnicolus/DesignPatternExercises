namespace DebonairsPizzaApp.Utils
{
    public class GYIPizzangredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new NickCheese();
        }

        public Dough CreateDough()
        {
            return new VeryThinDough();
        }

        public Sauce CreateSauce()
        {
            return new GYSauce();
        }

        public string[] CreateVeggies()
        {
            return new[] { "Onions", "Beans" };
        }
    }
}

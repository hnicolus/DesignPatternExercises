namespace DebonairsPizzaApp.Utils
{
    public class MalIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            return new TomatoeSauce();
        }

        public string[] CreateVeggies()
        {
            return new[] { "Tomatoe", "Onions" };
        }
    }
}

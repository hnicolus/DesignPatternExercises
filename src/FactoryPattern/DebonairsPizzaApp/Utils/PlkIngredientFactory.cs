namespace DebonairsPizzaApp.Utils
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

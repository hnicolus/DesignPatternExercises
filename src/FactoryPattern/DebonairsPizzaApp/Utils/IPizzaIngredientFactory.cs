namespace DebonairsPizzaApp.Utils
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        string[] CreateVeggies();
        Cheese CreateCheese();

    }
}

using DebonairsPizzaApp.Utils.Factory;
namespace DebonairsPizzaApp.Utils.Shops
{
    public class MalPizzaShop : PizzaShop
    {
        public MalPizzaShop()
        {
            Factory = new MalIngredientFactory();

        }
    }

}

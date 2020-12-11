using DebonairsPizzaApp.Utils.Factory;
namespace DebonairsPizzaApp.Utils.Shops
{
    public class PLKPizzaShop : PizzaShop
    {
        public PLKPizzaShop()
        {
            Factory = new PlkIngredientFactory();
        }
    }

}

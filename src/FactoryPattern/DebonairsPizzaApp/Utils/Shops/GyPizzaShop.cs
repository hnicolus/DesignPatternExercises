using DebonairsPizzaApp.Utils.Factory;
namespace DebonairsPizzaApp.Utils.Shops
{
    public class GyPizzaShop : PizzaShop
    {
        public GyPizzaShop()
        {
            Factory = new GYIPizzangredientFactory();
        }
    }

}

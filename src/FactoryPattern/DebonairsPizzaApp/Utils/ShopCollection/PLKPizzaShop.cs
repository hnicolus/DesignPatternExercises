using DebonairsPizzaApp.Utils.PizzaCollection;

namespace DebonairsPizzaApp.Utils
{
    public class PLKPizzaShop : PizzaShop
    {
        public PLKPizzaShop()
        {
            Factory = new PlkIngredientFactory();
        }
    }

    public class MalPizzaShop : PizzaShop
    {
        public MalPizzaShop()
        {
            Factory = new MalIngredientFactory();

        }
    }

    public class GyPizzaShop : PizzaShop
    {
        public GyPizzaShop()
        {
            Factory =new GYIPizzangredientFactory();
        }
    }

}

using DebonairsPizzaApp.Utils.PizzaCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebonairsPizzaApp.Utils
{

    public enum PizzaType
    {
        CheesePizza,
        PepperoniPizza,
        VeggiPizza
    }
    public abstract class PizzaShop
    {
        protected IPizzaIngredientFactory Factory;

        public Pizza Pizza { get; set; }

        public  void OrderPizza(PizzaType type)
        {
            if (type == PizzaType.CheesePizza)
            {
                Pizza = new CheesePizza(Factory);
            }
            else if (type == PizzaType.PepperoniPizza)
            {
                Pizza = new PepperoniPizza(Factory);
            }
            else if (type == PizzaType.VeggiPizza)
            {
                Pizza = new VeggiePizza(Factory);
            }
        }

        public void CreatePizza()
        {
            Pizza.Prepare();
            Pizza.Bake();
            Pizza.Cut();
            Pizza.Box();
        }

        public void Deliver()
        {
            Console.WriteLine("Delivering Pizza...");
            Console.WriteLine(Pizza.ToString());
        }

    }

}

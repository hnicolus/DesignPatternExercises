using DebonairsPizzaApp.Utils.Common.Enums;
using DebonairsPizzaApp.Utils.Common.Interfaces;
using DebonairsPizzaApp.Utils.PizzaCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebonairsPizzaApp.Utils.Shops
{
    public abstract class PizzaShop
    {
        protected IPizzaIngredientFactory Factory;

        public Pizza Pizza { get; set; }

        public void OrderPizza(PizzaType type)
        {
            var pizzaOptions = new Dictionary<PizzaType, Action>();

            RegisterPizzaOptions(pizzaOptions);

            pizzaOptions[type]();

            CreatePizza();
        }

        private  void RegisterPizzaOptions(Dictionary<PizzaType, Action> pizzaOptions)
        {
            pizzaOptions.Add(PizzaType.CheesePizza, () => Pizza = new CheesePizza(Factory));
            pizzaOptions.Add(PizzaType.PepperoniPizza, () => Pizza = new PepperoniPizza(Factory));
            pizzaOptions.Add(PizzaType.VeggiPizza, () => Pizza = new VeggiePizza(Factory));
        }

        public void CreatePizza()
        {
            Pizza.Prepare();
            Pizza.Bake();
            Pizza.Cut();
            Pizza.Box();
            Deliver();
        }

        public virtual void Deliver()
        {
            Console.WriteLine("Delivering Pizza...");
            Console.WriteLine(Pizza.ToString());
        }

    }

}

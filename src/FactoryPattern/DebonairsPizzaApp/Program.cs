using DebonairsPizzaApp.Utils;
using DebonairsPizzaApp.Utils.ShopCollection;
using System;
using System.Collections.Generic;

namespace DebonairsPizzaApp
{
    //Choose Type of Shop then choose type of meal

    class Program
    {
        static void Main(string[] args)
        {
            var plkshop = new PLKPizzaShop();
            var malShop = new MalPizzaShop();
            var gyPizzaShop = new GyPizzaShop();
            var jhbShop = new JhbPizzaShop();

            var shops = new List<PizzaShop>();

            shops.Add(plkshop);
            shops.Add(malShop);
            shops.Add(gyPizzaShop);
            shops.Add(jhbShop);

            Console.WriteLine("Polokwane Pizza Shop");

            plkshop.OrderPizza(PizzaType.PepperoniPizza);
            plkshop.CreatePizza();
            plkshop.Deliver();

            plkshop.OrderPizza(PizzaType.CheesePizza);
            plkshop.CreatePizza();
            plkshop.Deliver();

            plkshop.OrderPizza(PizzaType.VeggiPizza);
            plkshop.CreatePizza();
            plkshop.Deliver();
            Console.WriteLine(new String('=', 0));

            Console.WriteLine("Malamulele Pizza Shop");
            malShop.OrderPizza(PizzaType.PepperoniPizza);
            malShop.CreatePizza();
            malShop.Deliver();
            malShop.OrderPizza(PizzaType.CheesePizza);
            malShop.CreatePizza();
            malShop.Deliver();
            malShop.OrderPizza(PizzaType.VeggiPizza);
            malShop.CreatePizza();
            malShop.Deliver();
            Console.WriteLine(new String('=', 40));

            Console.WriteLine("Giyani Pizza Shop");
            gyPizzaShop.OrderPizza(PizzaType.PepperoniPizza);
            gyPizzaShop.CreatePizza();
            gyPizzaShop.Deliver();
            gyPizzaShop.OrderPizza(PizzaType.CheesePizza);
            gyPizzaShop.CreatePizza();
            gyPizzaShop.Deliver();
            gyPizzaShop.OrderPizza(PizzaType.VeggiPizza);
            gyPizzaShop.CreatePizza();
            gyPizzaShop.Deliver();
            Console.WriteLine(new String('=', 40));

            Console.WriteLine("Johannesburg Pizza Shop");
            jhbShop.OrderPizza(PizzaType.PepperoniPizza);
            jhbShop.CreatePizza();
            jhbShop.Deliver();
            jhbShop.OrderPizza(PizzaType.CheesePizza);
            jhbShop.CreatePizza();
            jhbShop.Deliver();
            jhbShop.OrderPizza(PizzaType.VeggiPizza);
            jhbShop.CreatePizza();
            jhbShop.Deliver();
            Console.WriteLine(new String('=', 50));
        }
    }
}

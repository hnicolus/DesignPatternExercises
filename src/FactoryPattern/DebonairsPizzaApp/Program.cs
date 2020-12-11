using DebonairsPizzaApp.Utils.Common.Enums;
using DebonairsPizzaApp.Utils.Shops;
using System;
using System.Collections.Generic;

namespace DebonairsPizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new List<PizzaShop>();

            shops.AddRange(new List<PizzaShop>()
            {
                new PLKPizzaShop(),
                new MalPizzaShop(),
                new GyPizzaShop(),
                new JhbPizzaShop()
            });

            CreateMultipleOrdersOnEachShop(shops);
        }

        private static void CreateMultipleOrdersOnEachShop(List<PizzaShop> shops)
        {
            foreach (var shop in shops)
            {
                Console.WriteLine(shop.GetType().Name);
                Console.WriteLine(new string('-', 40));
                shop.OrderPizza(PizzaType.PepperoniPizza);
                shop.OrderPizza(PizzaType.CheesePizza);
                shop.OrderPizza(PizzaType.VeggiPizza);
                Console.WriteLine(new string('=', 40));
            }
        }
    }
}

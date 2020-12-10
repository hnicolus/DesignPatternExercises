using System;

namespace CoffeeShop
{

    class Program
    {
        static void Main(string[] args)
        {
            var darkRoast = new DarkRoast();

            var milk = new Milk(darkRoast);
            var soybeans = new Soy(milk);

            var milk2 = new Milk(soybeans);
            var totalCost = milk2.Cost();
            Console.WriteLine(Math.Round(totalCost,2));
            Console.WriteLine(milk2.Description);
        }
    }

}

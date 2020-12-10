using DuckDuckie.Models;
using System;
using DuckDuckie.Models.Common;
using System.Collections.Generic;
namespace DuckDuckie
{
    class Program
    {
        static void Main(string[] args)
        {

            var mallardDuck = new MallardDuck();
            var combDuck = new CombDuck();
            var plasticDuck = new PlasticDuck();

            var mandarinDuck = new MandarinDuck();
            List<DuckBase> ducks = new List<DuckBase>();

            ducks.Add(mallardDuck);
            ducks.Add(combDuck);
            ducks.Add(plasticDuck);
            ducks.Add(mandarinDuck);

            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.Name);
                duck.Fly();
                duck.Swim();
                duck.Quack();
            }
        }
    }
}

using DebonairsPizzaApp.Utils.Common.Interfaces;
using DebonairsPizzaApp.Utils.Ingredients;
using DebonairsPizzaApp.Utils.Ingredients.Sauces;
using System;
using System.Linq;
using System.Text;

namespace DebonairsPizzaApp.Utils.PizzaCollection
{
    public abstract class Pizza
    {


        protected IPizzaIngredientFactory _ingredientFactory;
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Cheese Cheese { get; set; }
        public string[] Veggies { get; set; }

        public Pizza(IPizzaIngredientFactory factory)
        {
            _ingredientFactory = factory;
        }

        public void Prepare()
        {
            Cheese = _ingredientFactory.CreateCheese();
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Veggies = _ingredientFactory.CreateVeggies();

        }
        public void Bake()
        {
            Console.WriteLine("Baking Pizza..");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Pizza...");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Pizza..");
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            var divider = new string('-', 40);
            sb.AppendLine().AppendLine($"Name : {Name}").AppendLine("")
                .AppendLine($"Ingredients")
                .AppendLine($"*{Dough.Name}\n*{Sauce.Name}\n*{Cheese.Name}");

            for (int i = 0; i < Veggies.Length; i++)
            {
                sb.Append(Veggies[i]);

                if (i +1 != Veggies.Length)
                {
                    sb.Append(",");
                }
            }
            sb.AppendLine("").AppendLine(divider);

            return sb.ToString();
        }
    }


}

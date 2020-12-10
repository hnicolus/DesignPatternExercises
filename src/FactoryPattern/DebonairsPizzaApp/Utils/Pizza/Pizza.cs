using System;
using System.Linq;
using System.Text;

namespace DebonairsPizzaApp.Utils.PizzaCollection
{
    public abstract class Pizza
    {
        public Pizza(IPizzaIngredientFactory factory)
        {
            _ingredientFactory = factory;
        }
        protected IPizzaIngredientFactory _ingredientFactory;
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Cheese Cheese { get; set; }
        public string[] Veggies { get; set; }



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

            var divider = new string('=', 40);
            sb.AppendLine();
            sb.AppendLine($"Name : {Name}");
            sb.AppendLine($"Ingredients");
            sb.AppendLine(divider);
            sb.AppendLine($"*{Dough.Name}\n*{Sauce.Name}\n*{Cheese.Name}\n");

            for (int i = 0; i < Veggies.Length; i++)
            {
                sb.Append(Veggies[i]);

                if (i != Veggies.Length)
                {
                    sb.Append(",");
                }
            }
            return sb.ToString();
        }
    }


}

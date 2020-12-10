namespace CoffeeShop
{
    public class Espresso : IBerverage
    {
        private string _description = "warm chocolate Espresso";
        public string Description { get => _description; set => _description = value; }

        public double Cost()
        {
            return 21.50;
        }
    }

}

namespace CoffeeShop
{
    public class DarkRoast : IBerverage
    {
        private string _description;
        public string Description { get => "smooth extra ordinary Dark Roast"; set => _description = value; }

        public double Cost()
        {
            return 25.00;
        }
    }

}

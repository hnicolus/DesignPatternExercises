namespace CoffeeShop
{
    public class HouseBlend : IBerverage
    {
        private string _description = "House blend";

     
        public string Description { get; set; }

        public double Cost()
        {
            return 30.50;
        }
    }

}

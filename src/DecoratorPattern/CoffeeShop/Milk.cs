namespace CoffeeShop
{
    public class Milk : CodimentDecorator
    {
        private string _description;

        public override string Description { get => _description; set => _description = value; }

        public Milk(IBerverage berverage)
        {
            _berverage = berverage;
            _description = "Milk" + " with " + _berverage.Description;
        }
        public override double Cost() => _berverage.Cost() + 12.50;
    }

}

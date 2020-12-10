namespace CoffeeShop
{
    public class Mocha : CodimentDecorator
    {
        public string _description;
        public override string Description { get => _description; set => _description = value; }

        public Mocha(IBerverage berverage)
        {
            _description = "Mocha" + " with " + _berverage.Description;
            _berverage = berverage;
            
        }
        public override double Cost() => _berverage.Cost() + 10.50;
    }

}

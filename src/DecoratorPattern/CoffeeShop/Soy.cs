namespace CoffeeShop
{
    public class Soy : CodimentDecorator
    {
        public override string Description { get; set; }

        public Soy(IBerverage berverage)
        {
            _berverage = berverage;
            Description = "Soy with " + _berverage.Description;
        }
        public override double Cost() => _berverage.Cost() + .50;
    }

}

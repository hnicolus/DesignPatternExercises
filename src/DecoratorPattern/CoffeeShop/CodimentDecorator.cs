namespace CoffeeShop
{
    public abstract class CodimentDecorator : IBerverage
    {
        protected IBerverage _berverage;

        public abstract string Description { get; set; }

        public abstract double Cost();
    }

}

namespace DuckDuckie
{
    public interface IFlyBehavior
    {
        void Fly();
    }


    public class NoFlying : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("😥 Cannot Fly");
        }
    }

    public class FlyWithoutWings : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine(" Flying with out wings");
        }
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            System.Console.WriteLine("FLying with Wings");
        }
    }
}
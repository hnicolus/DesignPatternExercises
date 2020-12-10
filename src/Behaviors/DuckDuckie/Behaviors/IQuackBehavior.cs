namespace DuckDuckie
{
    public interface IQuackBehavior
    {
        void Quack();
    }


    public class MutedQuack : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Muted Quack");
        }
    }

    public class QuackWithCreek : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Quacking with Creek");
        }
    }

    public class QuackSoundWithSqeaker : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Quacking with Speakerss");
        }
    }
}
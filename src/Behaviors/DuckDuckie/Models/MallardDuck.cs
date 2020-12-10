using DuckDuckie.Models.Common;

namespace DuckDuckie.Models
{
    public class MallardDuck : DuckBase
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackWithCreek();

        }
        public override string Name => "Mallard Duck";


    }
}

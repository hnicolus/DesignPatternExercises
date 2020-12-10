using DuckDuckie.Models.Common;

namespace DuckDuckie.Models
{
    public class MandarinDuck : DuckBase
    {
        public MandarinDuck()
        {
            FlyBehavior = new FlyWithoutWings();
            QuackBehavior = new QuackWithCreek();
        }
        public override string Name => "Madarin Duck";

    }
}

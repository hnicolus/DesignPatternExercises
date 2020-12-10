using DuckDuckie.Models.Common;

namespace DuckDuckie
{
    public class CombDuck : DuckBase
    {
        public CombDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackWithCreek();
        }
        public override string Name => "Comb Duck";

    }
}

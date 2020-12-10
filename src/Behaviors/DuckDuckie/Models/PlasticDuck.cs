using DuckDuckie.Models.Common;

namespace DuckDuckie.Models
{
    public class PlasticDuck : DuckBase
    {
        public PlasticDuck()
        {
            FlyBehavior = new NoFlying();
            QuackBehavior = new QuackSoundWithSqeaker();
        }

        public override string Name => "Plastic Duck";
    }
}

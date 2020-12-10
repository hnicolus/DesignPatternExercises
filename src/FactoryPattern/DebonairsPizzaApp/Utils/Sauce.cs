namespace DebonairsPizzaApp.Utils
{
    public abstract class Sauce
    {
        public string Name { get; set; }

    }
    public class SekwadiSauce : Sauce
    {
        public SekwadiSauce()
        {
            Name = "Sekwadi Sauce";
        }
    }
    public class TomatoeSauce : Sauce
    {
        public TomatoeSauce()
        {
            Name = "Tomatoe Sauce";
        }
    }
    public class GYSauce : Sauce
    {
        public GYSauce()
        {
            Name = "GY Sauce";
        }
    }



}
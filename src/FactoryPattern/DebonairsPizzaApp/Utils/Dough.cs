namespace DebonairsPizzaApp.Utils
{
    public abstract class Dough
    {
        public string Name { get; set; }
    }

    public class ThickCrustDough : Dough
    {
        public ThickCrustDough()
        {
            Name = "Thick Crust Dough";
        }
    }
    public class ThinCrustDough : Dough 
    {
        public ThinCrustDough()
        {
            Name = "Thin Crust Dough";
        }
    }
    public class VeryThinDough : Dough
    {
        public VeryThinDough()
        {
            Name = "Very Thin Dough";
        }
    }


}
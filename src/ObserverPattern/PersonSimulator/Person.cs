using System;
namespace PersonSimulator
{
    public class Person
    {
        public event EventHandler<CatchColdEventArg> GetsSick;
        public string Name { get; set; }

        public void CatchCold()
        {
            var args = new CatchColdEventArg();
            args.Symptoms = new[] { "Sweating", "Dry Cough", "Nausea" };

            GetsSick?.Invoke(this, args);
        }
    }
}

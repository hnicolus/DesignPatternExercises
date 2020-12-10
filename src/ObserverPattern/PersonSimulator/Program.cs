using System;
using System.Collections.Generic;
namespace PersonSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "Joe"};

            person.GetsSick += CallDoctor;

            person.CatchCold();
        }

        private static void CallDoctor(object sender, CatchColdEventArg e)
        {
            var person = (Person)sender;
            Console.WriteLine("Calling Doctor...");
            Console.WriteLine($"{person.Name} has catched a cold and He/She Displays the following Symptoms" +
                $"\n"+new string('=',40));

            foreach (var symptom in e.Symptoms)
            {
                Console.WriteLine("{0}", symptom);
            }
        }
    }
}

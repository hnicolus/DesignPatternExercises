using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckDuckie.Models.Common
{
    public abstract class DuckBase
    {
        public virtual string Name { get; set; } 
        protected  IFlyBehavior FlyBehavior { get; set; }
        protected IQuackBehavior QuackBehavior { get; set; }

        public virtual void Fly()
        {
            FlyBehavior.Fly();
        }

        public virtual void Quack()
        {
            QuackBehavior.Quack();
        }
        public virtual void Swim()
        {
            Console.WriteLine($"{Name} Duck is Swimming");
        }
    }
}

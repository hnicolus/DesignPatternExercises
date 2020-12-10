using System;
namespace PersonSimulator
{
    public class CatchColdEventArg : EventArgs
    {
        public string[] Symptoms { get; set; }
    }
}

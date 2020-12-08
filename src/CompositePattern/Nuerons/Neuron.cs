using System;
using System.Collections;
using System.Collections.Generic;

namespace Nuerons
{
    public class Neuron : IEnumerable<Neuron>
    {
        public float value;

        public List<Neuron> In, Out;

        public void ConnectTo(Neuron other)
        {
            other.In.Add(this);
            Out.Add(other);
        }

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

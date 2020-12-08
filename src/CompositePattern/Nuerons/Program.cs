namespace Nuerons
{
    class Program
    {
        static void Main(string[] args)
        {

            Neuron neuron1 = new Neuron();
            Neuron neuron2 = new Neuron();
            
            NeuronLayer layer1 = new NeuronLayer();
            Neuron neuron3 = new Neuron();
            Neuron neuron4 = new Neuron();

            layer1.Add(neuron3);
            layer1.Add(neuron4);

            neuron1.ConnectTo(neuron2);
            neuron2.ConnectTo(layer1);

        }
    }
}

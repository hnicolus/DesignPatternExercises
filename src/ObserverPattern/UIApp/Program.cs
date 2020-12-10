using System;
using System.ComponentModel;

namespace UIApp
{

   public class Market
    {
        public BindingList<float> Prices = new BindingList<float>();
        public void AddPrice(float price) => Prices.Add(price);
    }
    class Program
    {
        static void Main(string[] args)
        {
            var market = new Market();

            market.Prices.ListChanged += PriceAdded;

            market.AddPrice(345);
            market.Prices.ListChanged -= PriceAdded;
        }

        private static void PriceAdded(object sender, ListChangedEventArgs e)
        {
            if(e.ListChangedType == ListChangedType.ItemAdded)
            {
                float price = ((BindingList<float>)sender)[e.NewIndex];
                Console.WriteLine("NEw Price {0} added ", price);
            }
        }
    }
}

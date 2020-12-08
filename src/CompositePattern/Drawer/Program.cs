using System;

namespace Drawer
{
    class Program
    {
        static void Main(string[] args)
        {
            var drawing = new DrawObject();

            drawing.Children.Add(new Square { color = "Green" });
            drawing.Children.Add(new Circle { color = "Red" });
            drawing.Children.Add(new Rectangle { color = "Yellow" });
            drawing.Children.Add(new Rectangle { color = "Blue" });

            var drawing2 = new DrawObject();
            drawing2.Children.Add(new Circle { color = "Orange" });
            drawing2.Children.Add(new Circle { color = "Purple" });
            drawing2.Children.Add(new Circle { color = "Pink" });
            drawing2.Children.Add(new Circle { color = "Blue" });

            drawing.Children.Add(drawing2);

            Console.WriteLine(drawing);
        }
    }
}

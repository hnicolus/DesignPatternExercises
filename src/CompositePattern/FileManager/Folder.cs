using System;
using System.Collections.Generic;

namespace FileManager
{
    internal class Folder : Component
    {
        public Folder(string name) : base(name) { }

        private List<Component> _children = new List<Component>();

        public override void Add(Component component) => _children.Add(component);
        
        public override void Remove(Component component) => _children.Remove(component);

        public override void DisplayAll(int index= 1)
        {
            Console.WriteLine($"{new String('>', index)} - {this.Name}");

            foreach (var file in _children)
            {
                file.DisplayAll(index+1);
            }
        }

    }
}

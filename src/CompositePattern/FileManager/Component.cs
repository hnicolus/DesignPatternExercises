namespace FileManager
{
    public abstract class Component
    {
        public string Name { get; set; }
        public Component(string name)
        {
            Name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void DisplayAll(int index);
    }
}

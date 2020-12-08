namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder rootFolder = InitialiseFolders();

            rootFolder.DisplayAll(1);
        }

        private static Folder InitialiseFolders()
        {
            Folder folder = new Folder("First Folder");
            folder.Add(new Folder("Second Folder"));
            folder.Add(new Folder("Third Folder"));
            var folder2 = new Folder("Fourth Folder");
            folder2.Add(new Folder("Fifth Folder"));
            folder2.Add(new Folder("Sixth Folder"));
            folder2.Add(new Folder("Seventh Folder"));

            folder.Add(folder2);
            return folder;
        }
    }
}

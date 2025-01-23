
namespace CompositePattern
{
    public class File : IFileSystemComponent
    {
        public string Name { get; private set; }
        private int Size;

        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }
        public void Display(string indent)
        {
            Console.WriteLine($"{indent}{GetName()}");
        }

        public string GetName()
        {
            return Name;
        }

        public double GetSize()
        {
            return Size;
        }
    }
}

namespace VisitorPattern
{
    public class Folder : IElement
    {
        public List<IElement> Elements;
        public string Name;

        public Folder(string name)
        {
            Name = name;
            Elements = new();
        }
        public void Add(File file)
        {
            Elements.Add(file);
        }

        public void Add(Folder folder)
        {
            Elements.Add(folder);
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFolder(this);
        }
    }
}
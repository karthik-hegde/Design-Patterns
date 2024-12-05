
namespace VisitorPattern
{
    public class SizeCalculator : IVisitor
    {
        public int TotalSize = 0;
        public void VisitFile(File file)
        {
            TotalSize += file.Size;
        }

        public void VisitFolder(Folder folder)
        {
            folder.Elements.ForEach((element) =>
            {
                element.Accept(this);
            });

        }
    }
}
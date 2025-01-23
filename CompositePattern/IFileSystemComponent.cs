public interface IFileSystemComponent
{
    string GetName();
    void Display(string indent);

    double GetSize();
}
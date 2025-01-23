using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Directory : IFileSystemComponent
    {
        private List<IFileSystemComponent> ComponentList;
        public string Name;
        public Directory(string name)
        {
            Name = name;
            ComponentList = new();
        }

        public void Add(IFileSystemComponent component)
        {
            ComponentList.Add(component);
        }

        public void Remove(IFileSystemComponent component)
        {
            if (ComponentList.Contains(component))
            {
                ComponentList.Remove(component);
            }
            else
            {
                throw new InvalidOperationException($"{component.GetType()} not found");
            }
        }
        public void Display(string indent)
        {
            Console.WriteLine($"{indent}{GetName()}");
            foreach (IFileSystemComponent component in ComponentList)
            {
                if (component is Directory)
                {
                    string currentIndent = indent + indent;
                    component.Display(currentIndent);
                }
                else
                {
                    component.Display(indent);
                }
            }
        }

        public string GetName()
        {
            return Name;
        }

        public double GetSize()
        {
            double totalSize = 0;
            foreach (IFileSystemComponent component in ComponentList)
            {
                totalSize += component.GetSize();
            }
            return totalSize;
        }
    }
}
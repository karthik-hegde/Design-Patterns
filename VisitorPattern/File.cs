using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class File : IElement
    {
        public int Size;
        public string Name;

        public File(string name, int size)
        {
            Name = name;
            Size = size;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFile(this);
        }
    }
}
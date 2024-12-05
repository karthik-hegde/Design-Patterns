using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class ContentLister : IVisitor
    {
        private int _indentLevel = 0;

        public void VisitFile(File file)
        {
            Console.WriteLine($"{new string(' ', _indentLevel * 2)}- {file.Name}");
        }

        public void VisitFolder(Folder folder)
        {
            Console.WriteLine($"{new string(' ', _indentLevel * 2)}- {folder.Name}/");

            _indentLevel++;

            foreach (var element in folder.Elements)
            {
                element.Accept(this);
            }

            _indentLevel--;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IVisitor
    {
        public void VisitFile(File file);

        public void VisitFolder(Folder folder);
    }
}
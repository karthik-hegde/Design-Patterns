using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public interface IElement
    {
        public void Accept(IVisitor visitor);
    }
}
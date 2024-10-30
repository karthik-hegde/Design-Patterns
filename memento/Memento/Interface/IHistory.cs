using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memento.Interface
{
    public interface IHistory
    {
        void Undo();
        void Redo();
    }
}
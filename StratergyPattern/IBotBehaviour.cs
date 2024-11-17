using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StratergyPattern
{
    public interface IBotBehaviour
    {
        void Execute(Bot bot);
    }
}
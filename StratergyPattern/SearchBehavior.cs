using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StratergyPattern
{
    public class SearchBehaviour : IBotBehaviour
    {
        public void Execute(Bot bot)
        {
            Console.WriteLine($"{bot.Name}: is searching");
        }
    }
}
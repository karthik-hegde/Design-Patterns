using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StratergyPattern
{
    public class DefensiveBehaviour : IBotBehaviour
    {
        public void Execute(Bot bot)
        {
            Console.WriteLine($"{bot.Name}: is now defensive");
            bot.Health += 5;
        }
    }
}
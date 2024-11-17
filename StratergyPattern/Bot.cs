using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StratergyPattern
{
    public class Bot
    {

        public string Name { get; }
        public int Health { get; set; }

        public int EnemyHealth { get; set; }
        public IBotBehaviour CurrentBehaviour { get; set; }
        public Bot(string name, int health, IBotBehaviour initBehaviour)
        {
            CurrentBehaviour = initBehaviour;
            Name = name;
            Health = health;
            EnemyHealth = 100;
        }

        public void SetBehaviour(IBotBehaviour behaviour)
        {
            CurrentBehaviour = behaviour;
        }

        public void PerformAction()
        {
            CurrentBehaviour.Execute(this);
        }
    }
}
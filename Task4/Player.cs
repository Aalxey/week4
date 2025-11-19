using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Player
    {
        public string playerName;

        public int level;

        public String health;

        public Player()
        {
            Console.WriteLine("Player has been called");
        }

        public Player(string playerName, int level, string health)
        {
            this.playerName = playerName;
            this.level = level;
            this.health = health;
        }
    }
}

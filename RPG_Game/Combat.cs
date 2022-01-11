using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class Combat
    {
        private Player player;
        private Enemy enemy;

        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        public Enemy Enemy
        {
            get { return enemy; }
            set { enemy = value; }
        }
    }
}
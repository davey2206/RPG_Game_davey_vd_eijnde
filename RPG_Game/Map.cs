using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    internal class Map
    {
        private List<Enemy> enemies = new List<Enemy>();
        private Player player;
        private Random rng = new Random();

        public void CreatePlayer(Gender g, string n)
        {
            player = new Player(n, g);
        }

        public Player Player
        {
            get { return player; }
        }

        public void createEnemy()
        {
            for (int i = 0; i < 5; i++)
            {
                int x = rng.Next(100, 750);
                int y = rng.Next(50, 450);
                switch (rng.Next(1, 4))
                {
                    case 1:
                        enemies.Add(new Enemy(MonsterName.Slime, 10, 1, x, y, Properties.Resources.slime));
                        break;

                    case 2:
                        enemies.Add(new Enemy(MonsterName.Bandit, 25, 3, x, y, Properties.Resources.bandit));
                        break;

                    case 3:
                        enemies.Add(new Enemy(MonsterName.Goblin, 15, 2, x, y, Properties.Resources.goblin));
                        break;
                }
            }
        }

        public List<Enemy> Enemies
        {
            get { return enemies; }
        }
    }
}
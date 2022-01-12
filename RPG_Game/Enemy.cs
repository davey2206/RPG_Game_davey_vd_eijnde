using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RPG_Game
{
    public enum MonsterName
    {
        Slime,
        Goblin,
        Bandit
    }

    internal class Enemy
    {
        #region private variables

        private MonsterName name;
        private int health;
        private int minAttack;
        private int maxAttack;
        private int location_x;
        private int location_y;
        private Image picture;
        private Random rng = new Random();

        #endregion private variables

        public Enemy(MonsterName n, int h, int minA, int maxA, int x, int y, Image p)
        {
            name = n;
            health = h;
            minAttack = minA;
            maxAttack = maxA;
            location_x = x;
            location_y = y;
            picture = p;
        }

        #region public variables

        public MonsterName Name
        {
            get { return name; }
        }

        public int Health
        {
            get { return health; }
        }

        public int MinAttack
        {
            get { return minAttack; }
        }

        public int MaxAttack
        {
            get { return maxAttack; }
        }

        public int Location_x
        {
            get { return location_x; }
        }

        public int Location_y
        {
            get { return location_y; }
        }

        public Image Picture
        {
            get { return picture; }
        }

        #endregion public variables

        public string Takedamage(Player player)
        {
            int atk = rng.Next(player.MinAttack, player.MaxAttack);
            health = health - atk;
            return atk.ToString();
        }

        public override string ToString()
        {
            return name + "  |  " + health + " HP";
        }
    }
}
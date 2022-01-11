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
        private int heath;
        private int attack;
        private int location_x;
        private int location_y;
        private Image picture;

        #endregion private variables

        public Enemy(MonsterName n, int h, int a, int x, int y, Image p)
        {
            name = n;
            heath = h;
            attack = a;
            location_x = x;
            location_y = y;
            picture = p;
        }

        #region public variables

        public MonsterName Name
        {
            get { return name; }
        }

        public int Heath
        {
            get { return heath; }
        }

        public int Attack
        {
            get { return attack; }
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

        public void Takedamage(Player player)
        {
            heath = heath - player.Attack;

            if (heath <= 0)
            {
                //dead
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RPG_Game
{
    public enum Gender
    {
        female,
        male
    }

    internal class Player
    {
        #region private variables

        private string name;
        private int health = 75;
        private int minAttack = 5;
        private int maxAttack = 10;
        private Gender gender;
        private Image picture;
        private Random rng = new Random();

        #endregion private variables

        public Player(string n, Gender g)
        {
            name = n;
            gender = g;
            if (g == Gender.female)
            {
                picture = Properties.Resources.Player_girl;
            }
            else
            {
                picture = Properties.Resources.Player_boy;
            }
        }

        #region public variables

        public string Name
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

        public Gender Gender
        {
            get { return gender; }
        }

        public Image Picture
        {
            get { return picture; }
        }

        #endregion public variables

        public string Takedamage(Enemy enemy)
        {
            int atk = rng.Next(enemy.MinAttack, enemy.MaxAttack);
            health = health - atk;
            return atk.ToString();
        }

        public override string ToString()
        {
            return name + "  |  " + health + " HP";
        }
    }
}
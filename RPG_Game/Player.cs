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
        private int heath = 100;
        private int attack = 5;
        private Gender gender;
        private Image picture;

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

        public int Heath
        {
            get { return heath; }
        }

        public int Attack
        {
            get { return attack; }
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

        public void Takedamage(Enemy enemy)
        {
            heath = heath - enemy.Attack;
            if (heath <= 0)
            {
                //dead
            }
        }
    }
}
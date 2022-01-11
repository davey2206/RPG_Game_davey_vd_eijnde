using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Game
{
    public partial class MapForm : Form
    {
        private int posX = 7;
        private int posY = 374;
        private Map map = new Map();

        public MapForm(Gender gender, string name)
        {
            InitializeComponent();
            map.createEnemy();
            map.CreatePlayer(gender, name);
            PlayerBox.Image = map.Player.Picture;
            setEnemeys();
        }

        private void setEnemeys()
        {
            EnemyBox1.Image = map.Enemies[0].Picture;
            EnemyBox2.Image = map.Enemies[1].Picture;
            EnemyBox3.Image = map.Enemies[2].Picture;
            EnemyBox4.Image = map.Enemies[3].Picture;
            EnemyBox5.Image = map.Enemies[4].Picture;

            EnemyBox1.Location = new Point(map.Enemies[0].Location_x, map.Enemies[0].Location_y);
            EnemyBox2.Location = new Point(map.Enemies[1].Location_x, map.Enemies[1].Location_y);
            EnemyBox3.Location = new Point(map.Enemies[2].Location_x, map.Enemies[2].Location_y);
            EnemyBox4.Location = new Point(map.Enemies[3].Location_x, map.Enemies[3].Location_y);
            EnemyBox5.Location = new Point(map.Enemies[4].Location_x, map.Enemies[4].Location_y);
        }

        private void MapForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                posY -= 5;
            }
            else if (e.KeyCode == Keys.D)
            {
                posX += 5;
            }
            else if (e.KeyCode == Keys.S)
            {
                posY += 5;
            }
            else if (e.KeyCode == Keys.A)
            {
                posX -= 5;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            PlayerBox.Location = new Point(posX, posY);

            foreach (Control enemy in this.Controls)
            {
                if (enemy is PictureBox && (string)enemy.Tag == "Enemy")
                {
                    if (PlayerBox.Bounds.IntersectsWith(enemy.Bounds))
                    {
                        CombatForm cf = new CombatForm();
                        enemy.Location = new Point(1000, 1000);
                        switch (enemy.Name)
                        {
                            case "EnemyBox1":
                                cf.combat.Player = map.Player;
                                cf.combat.Enemy = map.Enemies[0];
                                cf.ShowDialog();
                                break;

                            case "EnemyBox2":
                                cf.combat.Player = map.Player;
                                cf.combat.Enemy = map.Enemies[1];
                                cf.ShowDialog();
                                break;

                            case "EnemyBox3":
                                cf.combat.Player = map.Player;
                                cf.combat.Enemy = map.Enemies[2];
                                cf.ShowDialog();
                                break;

                            case "EnemyBox4":
                                cf.combat.Player = map.Player;
                                cf.combat.Enemy = map.Enemies[3];
                                cf.ShowDialog();
                                break;

                            case "EnemyBox5":
                                cf.combat.Player = map.Player;
                                cf.combat.Enemy = map.Enemies[4];
                                cf.ShowDialog();
                                break;
                        }
                    }
                }
            }
        }
    }
}
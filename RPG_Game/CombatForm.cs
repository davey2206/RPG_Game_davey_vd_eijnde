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
    public partial class CombatForm : Form
    {
        internal Combat combat = new Combat();

        public CombatForm()
        {
            InitializeComponent();
        }

        private void CombatForm_Load(object sender, EventArgs e)
        {
            EnemyBox.Image = combat.Enemy.Picture;
            PlayerBox.Image = combat.Player.Picture;
            lbEnemy.Text = combat.Enemy.ToString();
            lbPlayer.Text = combat.Player.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            txtPlayer.Text = combat.PlayerAttack();
            txtEnemy.Text = combat.EnemyAttack();
            lbEnemy.Text = combat.Enemy.ToString();
            lbPlayer.Text = combat.Player.ToString();
            if (combat.Enemy.Health <= 0)
            {
                btnAttack.Enabled = false;
                btnBack.Visible = true;
            }
            else if (combat.Player.Health <= 0)
            {
                btnAttack.Enabled = false;
                lbGame.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
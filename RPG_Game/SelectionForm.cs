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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gender gender;
            if (rbMan.Checked)
            {
                gender = Gender.male;
            }
            else
            {
                gender = Gender.female;
            }

            if (txtName.Text == "" || txtName.Text == null)
            {
                MessageBox.Show("vul een naam in");
            }
            else
            {
                MapForm map = new MapForm(gender, txtName.Text);
                map.Show();
                this.Hide();
            }
        }
    }
}
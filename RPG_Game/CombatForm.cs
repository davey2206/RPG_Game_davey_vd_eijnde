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
    }
}
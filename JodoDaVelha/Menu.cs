using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JodoDaVelha
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            Mesa doisJ = new Mesa();
            this.Hide();
            doisJ.ShowDialog();
            this.Close();
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            Mesa1J umJ = new Mesa1J();
            this.Hide();
            umJ.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnP1.BackColor = SystemColors.Control;
            btnP2.BackColor = SystemColors.Control;
            btnClose.BackColor = SystemColors.Control;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

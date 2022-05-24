using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimpijada
{
    public partial class Pregled : Form
    {
        public Pregled()
        {
            InitializeComponent();
        }

        private void Pregled_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void takmicariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ucesnici uc = new Ucesnici();
            uc.Show();
        }

        private void drzaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Drzave dr = new Drzave();
            dr.Show();
        }

        private void sportoviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sportovi sp = new Sportovi();
            sp.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Frm_Sobre : Form
    {
        public Frm_Sobre()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void Frm_Sobre_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Sobre_MouseClick(object sender, MouseEventArgs e)
        {
            Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Visible = false;
        }
    }
}

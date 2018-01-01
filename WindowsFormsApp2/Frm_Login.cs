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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btn_LoginEntrar_Click(object sender, EventArgs e)
        {
            if ((Tbx_user.Text == "Rafael") && (Tbx_senha.Text == "123456"))
            {
                Frm_cadVisitante frm = new Frm_cadVisitante();
                frm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou senha errada", "Ocorreu um erro na Autenticação", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void Btn_LoginCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tbx_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

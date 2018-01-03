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
    public partial class Frm_cadVisitante : Form
    {
        public Frm_cadVisitante()
        {
            InitializeComponent();
        }


        private void Frm_cadVisitante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseDataSet.visitante'. Você pode movê-la ou removê-la conforme necessário.
            this.visitanteTableAdapter.Fill(this.databaseDataSet.visitante);
            this.visitanteBindingSource.AddNew();

        }

        private void sobre(object sender, EventArgs e)
        {
            Frm_Sobre frm = new Frm_Sobre();
            frm.ShowDialog();
        }



        private void setor(object sender, EventArgs e)
        {
            Frm_CadSetor frm_setor = new Frm_CadSetor();
            frm_setor.Show();
        }


        private void sair(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("Você está Saindo do sistema de cadastro de visitande", "Saida", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void visitanteBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.visitanteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
            MessageBox.Show("Visitante registrado", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            visitanteBindingNavigatorSaveItem_Click_3(sender, e);
        }

        private void tSB_sair_Click(object sender, EventArgs e)
        {
            sair(sender, e);
        }

        private void tSB_sobre_Click(object sender, EventArgs e)
        {
            sobre(sender, e);
        }
    }
}

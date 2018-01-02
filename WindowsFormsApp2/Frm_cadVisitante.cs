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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Frm_cadVisitante_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseDataSet.visitante'. Você pode movê-la ou removê-la conforme necessário.
            this.visitanteTableAdapter.Fill(this.databaseDataSet.visitante);
            this.visitanteBindingSource.AddNew();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void visitanteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
            Frm_Sobre frm = new Frm_Sobre();
            frm.ShowDialog();
        }

        private void setor_visitaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton_setor_Click(object sender, EventArgs e)
        {
            Frm_CadSetor frm_setor = new Frm_CadSetor();
            frm_setor.Show();
        }

        private void visitanteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void visitanteBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {


        }

        private void visitanteBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.visitanteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
    }
}

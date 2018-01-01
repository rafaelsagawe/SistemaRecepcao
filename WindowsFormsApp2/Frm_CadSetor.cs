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
    public partial class Frm_CadSetor : Form
    {
        public Frm_CadSetor()
        {
            InitializeComponent();
        }

        private void setoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.setoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Frm_CadSetor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'databaseDataSet.setores'. Você pode movê-la ou removê-la conforme necessário.
            this.setoresTableAdapter.Fill(this.databaseDataSet.setores);

        }
    }
}

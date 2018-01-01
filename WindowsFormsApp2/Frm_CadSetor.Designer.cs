namespace WindowsFormsApp2
{
    partial class Frm_CadSetor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_setorLabel;
            System.Windows.Forms.Label nome_setorLabel;
            System.Windows.Forms.Label abreviacaoLabel;
            System.Windows.Forms.Label superiorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadSetor));
            this.databaseDataSet = new WindowsFormsApp2.DatabaseDataSet();
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setoresTableAdapter = new WindowsFormsApp2.DatabaseDataSetTableAdapters.setoresTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.setoresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setoresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_setorTextBox = new System.Windows.Forms.TextBox();
            this.nome_setorTextBox = new System.Windows.Forms.TextBox();
            this.abreviacaoTextBox = new System.Windows.Forms.TextBox();
            this.superiorTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            id_setorLabel = new System.Windows.Forms.Label();
            nome_setorLabel = new System.Windows.Forms.Label();
            abreviacaoLabel = new System.Windows.Forms.Label();
            superiorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingNavigator)).BeginInit();
            this.setoresBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_setorLabel
            // 
            id_setorLabel.AutoSize = true;
            id_setorLabel.Location = new System.Drawing.Point(12, 40);
            id_setorLabel.Name = "id_setorLabel";
            id_setorLabel.Size = new System.Drawing.Size(44, 13);
            id_setorLabel.TabIndex = 1;
            id_setorLabel.Text = "id setor:";
            // 
            // nome_setorLabel
            // 
            nome_setorLabel.AutoSize = true;
            nome_setorLabel.Location = new System.Drawing.Point(12, 66);
            nome_setorLabel.Name = "nome_setorLabel";
            nome_setorLabel.Size = new System.Drawing.Size(62, 13);
            nome_setorLabel.TabIndex = 3;
            nome_setorLabel.Text = "nome setor:";
            // 
            // abreviacaoLabel
            // 
            abreviacaoLabel.AutoSize = true;
            abreviacaoLabel.Location = new System.Drawing.Point(12, 92);
            abreviacaoLabel.Name = "abreviacaoLabel";
            abreviacaoLabel.Size = new System.Drawing.Size(63, 13);
            abreviacaoLabel.TabIndex = 5;
            abreviacaoLabel.Text = "abreviacao:";
            // 
            // superiorLabel
            // 
            superiorLabel.AutoSize = true;
            superiorLabel.Location = new System.Drawing.Point(12, 118);
            superiorLabel.Name = "superiorLabel";
            superiorLabel.Size = new System.Drawing.Size(47, 13);
            superiorLabel.TabIndex = 7;
            superiorLabel.Text = "superior:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // setoresBindingSource
            // 
            this.setoresBindingSource.DataMember = "setores";
            this.setoresBindingSource.DataSource = this.databaseDataSet;
            // 
            // setoresTableAdapter
            // 
            this.setoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.recpcaoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = this.setoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.visitanteTableAdapter = null;
            this.tableAdapterManager.visitaTableAdapter = null;
            // 
            // setoresBindingNavigator
            // 
            this.setoresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.setoresBindingNavigator.BindingSource = this.setoresBindingSource;
            this.setoresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.setoresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.setoresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.setoresBindingNavigatorSaveItem});
            this.setoresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.setoresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.setoresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.setoresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.setoresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.setoresBindingNavigator.Name = "setoresBindingNavigator";
            this.setoresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.setoresBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.setoresBindingNavigator.TabIndex = 0;
            this.setoresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // setoresBindingNavigatorSaveItem
            // 
            this.setoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.setoresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("setoresBindingNavigatorSaveItem.Image")));
            this.setoresBindingNavigatorSaveItem.Name = "setoresBindingNavigatorSaveItem";
            this.setoresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.setoresBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.setoresBindingNavigatorSaveItem.Click += new System.EventHandler(this.setoresBindingNavigatorSaveItem_Click);
            // 
            // id_setorTextBox
            // 
            this.id_setorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setoresBindingSource, "id_setor", true));
            this.id_setorTextBox.Location = new System.Drawing.Point(81, 37);
            this.id_setorTextBox.Name = "id_setorTextBox";
            this.id_setorTextBox.Size = new System.Drawing.Size(254, 20);
            this.id_setorTextBox.TabIndex = 2;
            // 
            // nome_setorTextBox
            // 
            this.nome_setorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setoresBindingSource, "nome_setor", true));
            this.nome_setorTextBox.Location = new System.Drawing.Point(81, 63);
            this.nome_setorTextBox.Name = "nome_setorTextBox";
            this.nome_setorTextBox.Size = new System.Drawing.Size(254, 20);
            this.nome_setorTextBox.TabIndex = 4;
            // 
            // abreviacaoTextBox
            // 
            this.abreviacaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setoresBindingSource, "abreviacao", true));
            this.abreviacaoTextBox.Location = new System.Drawing.Point(81, 89);
            this.abreviacaoTextBox.Name = "abreviacaoTextBox";
            this.abreviacaoTextBox.Size = new System.Drawing.Size(254, 20);
            this.abreviacaoTextBox.TabIndex = 6;
            // 
            // superiorTextBox
            // 
            this.superiorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.setoresBindingSource, "superior", true));
            this.superiorTextBox.Location = new System.Drawing.Point(81, 115);
            this.superiorTextBox.Name = "superiorTextBox";
            this.superiorTextBox.Size = new System.Drawing.Size(78, 20);
            this.superiorTextBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Frm_CadSetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 149);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(id_setorLabel);
            this.Controls.Add(this.id_setorTextBox);
            this.Controls.Add(nome_setorLabel);
            this.Controls.Add(this.nome_setorTextBox);
            this.Controls.Add(abreviacaoLabel);
            this.Controls.Add(this.abreviacaoTextBox);
            this.Controls.Add(superiorLabel);
            this.Controls.Add(this.superiorTextBox);
            this.Controls.Add(this.setoresBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_CadSetor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de setor";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_CadSetor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingNavigator)).EndInit();
            this.setoresBindingNavigator.ResumeLayout(false);
            this.setoresBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource setoresBindingSource;
        private DatabaseDataSetTableAdapters.setoresTableAdapter setoresTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator setoresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton setoresBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_setorTextBox;
        private System.Windows.Forms.TextBox nome_setorTextBox;
        private System.Windows.Forms.TextBox abreviacaoTextBox;
        private System.Windows.Forms.TextBox superiorTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
namespace WindowsFormsApp2
{
    partial class Frm_cadVisitante
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
            System.Windows.Forms.Label assuntoLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_visitaLabel;
            System.Windows.Forms.Label setor_visitaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadVisitante));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.visitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new WindowsFormsApp2.DatabaseDataSet();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.visitanteTableAdapter = new WindowsFormsApp2.DatabaseDataSetTableAdapters.visitanteTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.setoresTableAdapter = new WindowsFormsApp2.DatabaseDataSetTableAdapters.setoresTableAdapter();
            this.visitaTableAdapter = new WindowsFormsApp2.DatabaseDataSetTableAdapters.visitaTableAdapter();
            this.visitanteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.visitanteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_setor = new System.Windows.Forms.ToolStripButton();
            this.assuntoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.setor_visitaComboBox = new System.Windows.Forms.ComboBox();
            this.visitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.setoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_visitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            assuntoLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_visitaLabel = new System.Windows.Forms.Label();
            setor_visitaLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingNavigator)).BeginInit();
            this.visitanteBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // assuntoLabel
            // 
            assuntoLabel.AutoSize = true;
            assuntoLabel.Location = new System.Drawing.Point(7, 44);
            assuntoLabel.Name = "assuntoLabel";
            assuntoLabel.Size = new System.Drawing.Size(47, 13);
            assuntoLabel.TabIndex = 5;
            assuntoLabel.Text = "assunto:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(313, 26);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(25, 13);
            cpfLabel.TabIndex = 4;
            cpfLabel.Text = "cpf:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(7, 53);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(88, 13);
            data_nascimentoLabel.TabIndex = 5;
            data_nascimentoLabel.Text = "data nascimento:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(7, 26);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 6;
            nomeLabel.Text = "nome:";
            // 
            // data_visitaLabel
            // 
            data_visitaLabel.AutoSize = true;
            data_visitaLabel.Location = new System.Drawing.Point(213, 21);
            data_visitaLabel.Name = "data_visitaLabel";
            data_visitaLabel.Size = new System.Drawing.Size(58, 13);
            data_visitaLabel.TabIndex = 8;
            data_visitaLabel.Text = "data visita:";
            // 
            // setor_visitaLabel
            // 
            setor_visitaLabel.AutoSize = true;
            setor_visitaLabel.Location = new System.Drawing.Point(7, 24);
            setor_visitaLabel.Name = "setor_visitaLabel";
            setor_visitaLabel.Size = new System.Drawing.Size(60, 13);
            setor_visitaLabel.TabIndex = 9;
            setor_visitaLabel.Text = "setor visita:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 286);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Data e Hora";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(data_nascimentoLabel);
            this.groupBox1.Controls.Add(this.data_nascimentoDateTimePicker);
            this.groupBox1.Controls.Add(cpfLabel);
            this.groupBox1.Controls.Add(this.cpfMaskedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do visitante";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(49, 23);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(208, 20);
            this.nomeTextBox.TabIndex = 7;
            // 
            // visitanteBindingSource
            // 
            this.visitanteBindingSource.DataMember = "visitante";
            this.visitanteBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitanteBindingSource, "data_nascimento", true));
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(8, 69);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_nascimentoDateTimePicker.TabIndex = 6;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(344, 23);
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(135, 20);
            this.cpfMaskedTextBox.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // visitanteTableAdapter
            // 
            this.visitanteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.recpcaoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = this.setoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.visitanteTableAdapter = this.visitanteTableAdapter;
            this.tableAdapterManager.visitaTableAdapter = this.visitaTableAdapter;
            // 
            // setoresTableAdapter
            // 
            this.setoresTableAdapter.ClearBeforeFill = true;
            // 
            // visitaTableAdapter
            // 
            this.visitaTableAdapter.ClearBeforeFill = true;
            // 
            // visitanteBindingNavigator
            // 
            this.visitanteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.visitanteBindingNavigator.BindingSource = this.visitanteBindingSource;
            this.visitanteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.visitanteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.visitanteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.visitanteBindingNavigatorSaveItem,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton_setor});
            this.visitanteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitanteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitanteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitanteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitanteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitanteBindingNavigator.Name = "visitanteBindingNavigator";
            this.visitanteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitanteBindingNavigator.Size = new System.Drawing.Size(500, 25);
            this.visitanteBindingNavigator.TabIndex = 5;
            this.visitanteBindingNavigator.Text = "bindingNavigator1";
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
            // visitanteBindingNavigatorSaveItem
            // 
            this.visitanteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitanteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitanteBindingNavigatorSaveItem.Image")));
            this.visitanteBindingNavigatorSaveItem.Name = "visitanteBindingNavigatorSaveItem";
            this.visitanteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.visitanteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.visitanteBindingNavigatorSaveItem.Click += new System.EventHandler(this.visitanteBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.Image = global::WindowsFormsApp2.Properties.Resources.Exit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton3.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton3.Text = "Sair";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click_1);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton5.Text = "Sobre";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click_1);
            // 
            // toolStripButton_setor
            // 
            this.toolStripButton_setor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton_setor.Image = global::WindowsFormsApp2.Properties.Resources.User_group;
            this.toolStripButton_setor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_setor.Name = "toolStripButton_setor";
            this.toolStripButton_setor.Size = new System.Drawing.Size(54, 22);
            this.toolStripButton_setor.Text = "Setor";
            this.toolStripButton_setor.Click += new System.EventHandler(this.toolStripButton_setor_Click);
            // 
            // assuntoTextBox
            // 
            this.assuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "assunto", true));
            this.assuntoTextBox.Location = new System.Drawing.Point(10, 60);
            this.assuntoTextBox.Multiline = true;
            this.assuntoTextBox.Name = "assuntoTextBox";
            this.assuntoTextBox.Size = new System.Drawing.Size(469, 67);
            this.assuntoTextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(setor_visitaLabel);
            this.groupBox2.Controls.Add(this.setor_visitaComboBox);
            this.groupBox2.Controls.Add(data_visitaLabel);
            this.groupBox2.Controls.Add(this.data_visitaDateTimePicker);
            this.groupBox2.Controls.Add(assuntoLabel);
            this.groupBox2.Controls.Add(this.assuntoTextBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 137);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visita";
            // 
            // setor_visitaComboBox
            // 
            this.setor_visitaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitaBindingSource, "setor_visita", true));
            this.setor_visitaComboBox.DataSource = this.setoresBindingSource;
            this.setor_visitaComboBox.DisplayMember = "nome_setor";
            this.setor_visitaComboBox.FormattingEnabled = true;
            this.setor_visitaComboBox.Location = new System.Drawing.Point(73, 21);
            this.setor_visitaComboBox.Name = "setor_visitaComboBox";
            this.setor_visitaComboBox.Size = new System.Drawing.Size(121, 21);
            this.setor_visitaComboBox.TabIndex = 10;
            this.setor_visitaComboBox.ValueMember = "id_setor";
            this.setor_visitaComboBox.SelectedIndexChanged += new System.EventHandler(this.setor_visitaComboBox_SelectedIndexChanged);
            // 
            // visitaBindingSource
            // 
            this.visitaBindingSource.DataMember = "visita";
            this.visitaBindingSource.DataSource = this.databaseDataSet;
            // 
            // setoresBindingSource
            // 
            this.setoresBindingSource.DataMember = "setores";
            this.setoresBindingSource.DataSource = this.databaseDataSet;
            // 
            // data_visitaDateTimePicker
            // 
            this.data_visitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitaBindingSource, "data_visita", true));
            this.data_visitaDateTimePicker.Location = new System.Drawing.Point(277, 17);
            this.data_visitaDateTimePicker.Name = "data_visitaDateTimePicker";
            this.data_visitaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_visitaDateTimePicker.TabIndex = 9;
            // 
            // Frm_cadVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 308);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.visitanteBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_cadVisitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Visitante";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_cadVisitante_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingNavigator)).EndInit();
            this.visitanteBindingNavigator.ResumeLayout(false);
            this.visitanteBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource visitanteBindingSource;
        private DatabaseDataSetTableAdapters.visitanteTableAdapter visitanteTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator visitanteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton visitanteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.TextBox assuntoTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButton_setor;
        private DatabaseDataSetTableAdapters.visitaTableAdapter visitaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource visitaBindingSource;
        private System.Windows.Forms.ComboBox setor_visitaComboBox;
        private System.Windows.Forms.DateTimePicker data_visitaDateTimePicker;
        private DatabaseDataSetTableAdapters.setoresTableAdapter setoresTableAdapter;
        private System.Windows.Forms.BindingSource setoresBindingSource;
    }
}
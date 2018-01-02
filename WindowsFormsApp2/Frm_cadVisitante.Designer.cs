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
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label cpfLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cadVisitante));
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label tel_resiLabel;
            System.Windows.Forms.Label tel_celLabel;
            System.Windows.Forms.Label data_visitaLabel;
            System.Windows.Forms.Label setor_visitadaLabel;
            System.Windows.Forms.Label data_nascimentoLabel1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.databaseDataSet = new Recepcao.DatabaseDataSet();
            this.visitanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitanteTableAdapter = new Recepcao.DatabaseDataSetTableAdapters.visitanteTableAdapter();
            this.tableAdapterManager = new Recepcao.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.visitanteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.visitanteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.tel_resiTextBox = new System.Windows.Forms.TextBox();
            this.tel_celTextBox = new System.Windows.Forms.TextBox();
            this.assuntoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.data_visitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.setor_visitadaComboBox = new System.Windows.Forms.ComboBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tSB_sair = new System.Windows.Forms.ToolStripButton();
            this.tSB_sobre = new System.Windows.Forms.ToolStripButton();
            nomeLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            tel_resiLabel = new System.Windows.Forms.Label();
            tel_celLabel = new System.Windows.Forms.Label();
            data_visitaLabel = new System.Windows.Forms.Label();
            setor_visitadaLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingNavigator)).BeginInit();
            this.visitanteBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(6, 27);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(36, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "nome:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(6, 57);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(88, 13);
            data_nascimentoLabel.TabIndex = 4;
            data_nascimentoLabel.Text = "data nascimento:";
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(314, 26);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(25, 13);
            cpfLabel.TabIndex = 8;
            cpfLabel.Text = "cpf:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(data_nascimentoLabel1);
            this.groupBox1.Controls.Add(this.data_nascimentoDateTimePicker);
            this.groupBox1.Controls.Add(this.cpfMaskedTextBox);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(cpfLabel);
            this.groupBox1.Controls.Add(data_nascimentoLabel);
            this.groupBox1.Location = new System.Drawing.Point(7, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do visitante";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(setor_visitadaLabel);
            this.groupBox2.Controls.Add(this.setor_visitadaComboBox);
            this.groupBox2.Controls.Add(data_visitaLabel);
            this.groupBox2.Controls.Add(this.data_visitaDateTimePicker);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(7, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 191);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Visita";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.assuntoRichTextBox);
            this.groupBox3.Location = new System.Drawing.Point(9, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 106);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assunto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(tel_celLabel);
            this.groupBox4.Controls.Add(this.tel_celTextBox);
            this.groupBox4.Controls.Add(tel_resiLabel);
            this.groupBox4.Controls.Add(this.tel_resiTextBox);
            this.groupBox4.Controls.Add(emailLabel);
            this.groupBox4.Controls.Add(this.emailTextBox);
            this.groupBox4.Location = new System.Drawing.Point(7, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(446, 105);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contatos";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitanteBindingSource
            // 
            this.visitanteBindingSource.DataMember = "visitante";
            this.visitanteBindingSource.DataSource = this.databaseDataSet;
            // 
            // visitanteTableAdapter
            // 
            this.visitanteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.recpcaoTableAdapter = null;
            this.tableAdapterManager.setoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Recepcao.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.visitanteTableAdapter = this.visitanteTableAdapter;
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
            this.tSB_sair,
            this.tSB_sobre});
            this.visitanteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.visitanteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.visitanteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.visitanteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.visitanteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.visitanteBindingNavigator.Name = "visitanteBindingNavigator";
            this.visitanteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.visitanteBindingNavigator.Size = new System.Drawing.Size(461, 25);
            this.visitanteBindingNavigator.TabIndex = 12;
            this.visitanteBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // visitanteBindingNavigatorSaveItem
            // 
            this.visitanteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.visitanteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("visitanteBindingNavigatorSaveItem.Image")));
            this.visitanteBindingNavigatorSaveItem.Name = "visitanteBindingNavigatorSaveItem";
            this.visitanteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.visitanteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.visitanteBindingNavigatorSaveItem.Click += new System.EventHandler(this.visitanteBindingNavigatorSaveItem_Click_3);
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(23, 23);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 0;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(63, 20);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(372, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // tel_resiLabel
            // 
            tel_resiLabel.AutoSize = true;
            tel_resiLabel.Location = new System.Drawing.Point(17, 53);
            tel_resiLabel.Name = "tel_resiLabel";
            tel_resiLabel.Size = new System.Drawing.Size(40, 13);
            tel_resiLabel.TabIndex = 2;
            tel_resiLabel.Text = "tel resi:";
            // 
            // tel_resiTextBox
            // 
            this.tel_resiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "tel_resi", true));
            this.tel_resiTextBox.Location = new System.Drawing.Point(63, 50);
            this.tel_resiTextBox.Name = "tel_resiTextBox";
            this.tel_resiTextBox.Size = new System.Drawing.Size(144, 20);
            this.tel_resiTextBox.TabIndex = 3;
            // 
            // tel_celLabel
            // 
            tel_celLabel.AutoSize = true;
            tel_celLabel.Location = new System.Drawing.Point(19, 83);
            tel_celLabel.Name = "tel_celLabel";
            tel_celLabel.Size = new System.Drawing.Size(38, 13);
            tel_celLabel.TabIndex = 4;
            tel_celLabel.Text = "tel cel:";
            // 
            // tel_celTextBox
            // 
            this.tel_celTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "tel_cel", true));
            this.tel_celTextBox.Location = new System.Drawing.Point(63, 80);
            this.tel_celTextBox.Name = "tel_celTextBox";
            this.tel_celTextBox.Size = new System.Drawing.Size(144, 20);
            this.tel_celTextBox.TabIndex = 5;
            // 
            // assuntoRichTextBox
            // 
            this.assuntoRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "assunto", true));
            this.assuntoRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.assuntoRichTextBox.Name = "assuntoRichTextBox";
            this.assuntoRichTextBox.Size = new System.Drawing.Size(414, 79);
            this.assuntoRichTextBox.TabIndex = 1;
            this.assuntoRichTextBox.Text = "";
            // 
            // data_visitaLabel
            // 
            data_visitaLabel.AutoSize = true;
            data_visitaLabel.Location = new System.Drawing.Point(12, 163);
            data_visitaLabel.Name = "data_visitaLabel";
            data_visitaLabel.Size = new System.Drawing.Size(58, 13);
            data_visitaLabel.TabIndex = 14;
            data_visitaLabel.Text = "data visita:";
            // 
            // data_visitaDateTimePicker
            // 
            this.data_visitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitanteBindingSource, "data_visita", true));
            this.data_visitaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_visitaDateTimePicker.Location = new System.Drawing.Point(76, 159);
            this.data_visitaDateTimePicker.Name = "data_visitaDateTimePicker";
            this.data_visitaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_visitaDateTimePicker.TabIndex = 15;
            // 
            // setor_visitadaLabel
            // 
            setor_visitadaLabel.AutoSize = true;
            setor_visitadaLabel.Location = new System.Drawing.Point(11, 23);
            setor_visitadaLabel.Name = "setor_visitadaLabel";
            setor_visitadaLabel.Size = new System.Drawing.Size(72, 13);
            setor_visitadaLabel.TabIndex = 15;
            setor_visitadaLabel.Text = "setor visitada:";
            // 
            // setor_visitadaComboBox
            // 
            this.setor_visitadaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "setor_visitada", true));
            this.setor_visitadaComboBox.FormattingEnabled = true;
            this.setor_visitadaComboBox.Location = new System.Drawing.Point(89, 20);
            this.setor_visitadaComboBox.Name = "setor_visitadaComboBox";
            this.setor_visitadaComboBox.Size = new System.Drawing.Size(340, 21);
            this.setor_visitadaComboBox.TabIndex = 16;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(48, 23);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(246, 20);
            this.nomeTextBox.TabIndex = 9;
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.visitanteBindingSource, "cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(343, 23);
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpfMaskedTextBox.TabIndex = 10;
            // 
            // data_nascimentoLabel1
            // 
            data_nascimentoLabel1.AutoSize = true;
            data_nascimentoLabel1.Location = new System.Drawing.Point(113, 64);
            data_nascimentoLabel1.Name = "data_nascimentoLabel1";
            data_nascimentoLabel1.Size = new System.Drawing.Size(88, 13);
            data_nascimentoLabel1.TabIndex = 10;
            data_nascimentoLabel1.Text = "data nascimento:";
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.visitanteBindingSource, "data_nascimento", true));
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(207, 60);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_nascimentoDateTimePicker.TabIndex = 11;
            // 
            // tSB_sair
            // 
            this.tSB_sair.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSB_sair.Image = global::Recepcao.Properties.Resources.Exit;
            this.tSB_sair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_sair.Name = "tSB_sair";
            this.tSB_sair.Size = new System.Drawing.Size(46, 22);
            this.tSB_sair.Text = "Sair";
            // 
            // tSB_sobre
            // 
            this.tSB_sobre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tSB_sobre.Image = global::Recepcao.Properties.Resources.About;
            this.tSB_sobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tSB_sobre.Name = "tSB_sobre";
            this.tSB_sobre.Size = new System.Drawing.Size(57, 22);
            this.tSB_sobre.Text = "Sobre";
            // 
            // Frm_cadVisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 441);
            this.Controls.Add(this.visitanteBindingNavigator);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_cadVisitante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Visitante";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_cadVisitante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitanteBindingNavigator)).EndInit();
            this.visitanteBindingNavigator.ResumeLayout(false);
            this.visitanteBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Recepcao.DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource visitanteBindingSource;
        private Recepcao.DatabaseDataSetTableAdapters.visitanteTableAdapter visitanteTableAdapter;
        private Recepcao.DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DateTimePicker data_visitaDateTimePicker;
        private System.Windows.Forms.RichTextBox assuntoRichTextBox;
        private System.Windows.Forms.TextBox tel_celTextBox;
        private System.Windows.Forms.TextBox tel_resiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ComboBox setor_visitadaComboBox;
        private System.Windows.Forms.ToolStripButton tSB_sair;
        private System.Windows.Forms.ToolStripButton tSB_sobre;
    }
}
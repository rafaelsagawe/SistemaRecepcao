namespace WindowsFormsApp2
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.Btn_LoginEntrar = new System.Windows.Forms.Button();
            this.Btn_LoginCancelar = new System.Windows.Forms.Button();
            this.Tbx_user = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Tbx_senha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_LoginEntrar
            // 
            this.Btn_LoginEntrar.Location = new System.Drawing.Point(141, 178);
            this.Btn_LoginEntrar.Name = "Btn_LoginEntrar";
            this.Btn_LoginEntrar.Size = new System.Drawing.Size(96, 23);
            this.Btn_LoginEntrar.TabIndex = 0;
            this.Btn_LoginEntrar.Text = "Entrar";
            this.Btn_LoginEntrar.UseVisualStyleBackColor = true;
            this.Btn_LoginEntrar.Click += new System.EventHandler(this.Btn_LoginEntrar_Click);
            // 
            // Btn_LoginCancelar
            // 
            this.Btn_LoginCancelar.Location = new System.Drawing.Point(317, 178);
            this.Btn_LoginCancelar.Name = "Btn_LoginCancelar";
            this.Btn_LoginCancelar.Size = new System.Drawing.Size(127, 23);
            this.Btn_LoginCancelar.TabIndex = 1;
            this.Btn_LoginCancelar.Text = "Cancelar";
            this.Btn_LoginCancelar.UseVisualStyleBackColor = true;
            this.Btn_LoginCancelar.Click += new System.EventHandler(this.Btn_LoginCancelar_Click);
            // 
            // Tbx_user
            // 
            this.Tbx_user.Location = new System.Drawing.Point(6, 19);
            this.Tbx_user.Name = "Tbx_user";
            this.Tbx_user.Size = new System.Drawing.Size(291, 20);
            this.Tbx_user.TabIndex = 2;
            this.Tbx_user.TextChanged += new System.EventHandler(this.Tbx_user_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tbx_user);
            this.groupBox1.Location = new System.Drawing.Point(135, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Tbx_senha);
            this.groupBox2.Location = new System.Drawing.Point(135, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Senha";
            // 
            // Tbx_senha
            // 
            this.Tbx_senha.Location = new System.Drawing.Point(6, 19);
            this.Tbx_senha.Name = "Tbx_senha";
            this.Tbx_senha.PasswordChar = '#';
            this.Tbx_senha.Size = new System.Drawing.Size(291, 20);
            this.Tbx_senha.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cadastro de Visitante ";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(455, 212);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_LoginCancelar);
            this.Controls.Add(this.Btn_LoginEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_LoginEntrar;
        private System.Windows.Forms.Button Btn_LoginCancelar;
        private System.Windows.Forms.TextBox Tbx_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Tbx_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}
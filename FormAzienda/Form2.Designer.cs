namespace FormAzienda
{
    partial class Form2
    {
        /// <summary>
        /// Variabile di progettazione richiesta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">true se le risorse gestite devono essere eliminate; false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo richiesto per il supporto della finestra di progettazione. 
        /// Non modificare il contenuto di questo metodo con l'editor del codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCliente = new System.Windows.Forms.RadioButton();
            this.rbtnDipendente = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbMansione = new System.Windows.Forms.ComboBox();
            this.btnRegistrazione = new System.Windows.Forms.Button();
            this.btnTornaLogin = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCognome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMansione = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCliente);
            this.groupBox1.Controls.Add(this.rbtnDipendente);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(333, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleziona il tipo di utente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnCliente
            // 
            this.rbtnCliente.AutoSize = true;
            this.rbtnCliente.Location = new System.Drawing.Point(171, 32);
            this.rbtnCliente.Name = "rbtnCliente";
            this.rbtnCliente.Size = new System.Drawing.Size(69, 20);
            this.rbtnCliente.TabIndex = 1;
            this.rbtnCliente.TabStop = true;
            this.rbtnCliente.Text = "Cliente";
            this.rbtnCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnDipendente
            // 
            this.rbtnDipendente.AutoSize = true;
            this.rbtnDipendente.Location = new System.Drawing.Point(23, 32);
            this.rbtnDipendente.Name = "rbtnDipendente";
            this.rbtnDipendente.Size = new System.Drawing.Size(98, 20);
            this.rbtnDipendente.TabIndex = 0;
            this.rbtnDipendente.TabStop = true;
            this.rbtnDipendente.Text = "Dipendente";
            this.rbtnDipendente.UseVisualStyleBackColor = true;
            this.rbtnDipendente.CheckedChanged += new System.EventHandler(this.rbtnDipendente_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(433, 228);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(228, 22);
            this.txtNome.TabIndex = 2;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(433, 270);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(228, 22);
            this.txtCognome.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(433, 313);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(433, 356);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(228, 22);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(433, 398);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(228, 22);
            this.txtPassword.TabIndex = 6;
            // 
            // cmbMansione
            // 
            this.cmbMansione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMansione.FormattingEnabled = true;
            this.cmbMansione.Location = new System.Drawing.Point(433, 441);
            this.cmbMansione.Name = "cmbMansione";
            this.cmbMansione.Size = new System.Drawing.Size(228, 24);
            this.cmbMansione.TabIndex = 7;
            // 
            // btnRegistrazione
            // 
            this.btnRegistrazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRegistrazione.ForeColor = System.Drawing.Color.White;
            this.btnRegistrazione.Location = new System.Drawing.Point(345, 494);
            this.btnRegistrazione.Name = "btnRegistrazione";
            this.btnRegistrazione.Size = new System.Drawing.Size(316, 32);
            this.btnRegistrazione.TabIndex = 8;
            this.btnRegistrazione.Text = "Registrati";
            this.btnRegistrazione.UseVisualStyleBackColor = false;
            this.btnRegistrazione.Click += new System.EventHandler(this.btnRegistrazione_Click);
            // 
            // btnTornaLogin
            // 
            this.btnTornaLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTornaLogin.ForeColor = System.Drawing.Color.White;
            this.btnTornaLogin.Location = new System.Drawing.Point(345, 545);
            this.btnTornaLogin.Name = "btnTornaLogin";
            this.btnTornaLogin.Size = new System.Drawing.Size(316, 32);
            this.btnTornaLogin.TabIndex = 9;
            this.btnTornaLogin.Text = "Torna al Login";
            this.btnTornaLogin.UseVisualStyleBackColor = false;
            this.btnTornaLogin.Click += new System.EventHandler(this.btnTornaLogin_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(342, 228);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome:";
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.ForeColor = System.Drawing.Color.White;
            this.lblCognome.Location = new System.Drawing.Point(342, 270);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(69, 16);
            this.lblCognome.TabIndex = 11;
            this.lblCognome.Text = "Cognome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(342, 313);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(342, 356);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 16);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(342, 398);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // lblMansione
            // 
            this.lblMansione.AutoSize = true;
            this.lblMansione.ForeColor = System.Drawing.Color.White;
            this.lblMansione.Location = new System.Drawing.Point(342, 441);
            this.lblMansione.Name = "lblMansione";
            this.lblMansione.Size = new System.Drawing.Size(69, 16);
            this.lblMansione.TabIndex = 15;
            this.lblMansione.Text = "Mansione:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(303, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 52);
            this.label1.TabIndex = 16;
            this.label1.Text = "REGISTRAZIONE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(964, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMansione);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnTornaLogin);
            this.Controls.Add(this.btnRegistrazione);
            this.Controls.Add(this.cmbMansione);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Registrazione";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCliente;
        private System.Windows.Forms.RadioButton rbtnDipendente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbMansione;
        private System.Windows.Forms.Button btnRegistrazione;
        private System.Windows.Forms.Button btnTornaLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMansione;
        private System.Windows.Forms.Label label1;
    }
}

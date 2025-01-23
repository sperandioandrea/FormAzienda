namespace FormAzienda
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDipendente;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMansione;
        private System.Windows.Forms.ComboBox cmbMansione;
        private System.Windows.Forms.Button btnRegistrati;
        private System.Windows.Forms.Button btnIndietro;

        private void InitializeComponent()
        {
            this.lblTitolo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDipendente = new System.Windows.Forms.RadioButton();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMansione = new System.Windows.Forms.Label();
            this.cmbMansione = new System.Windows.Forms.ComboBox();
            this.btnRegistrati = new System.Windows.Forms.Button();
            this.btnIndietro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.Location = new System.Drawing.Point(420, 19);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(195, 32);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Registrazione";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDipendente);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Location = new System.Drawing.Point(416, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 103);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleziona tipo utente";
            // 
            // rbDipendente
            // 
            this.rbDipendente.AutoSize = true;
            this.rbDipendente.Location = new System.Drawing.Point(10, 20);
            this.rbDipendente.Name = "rbDipendente";
            this.rbDipendente.Size = new System.Drawing.Size(98, 20);
            this.rbDipendente.TabIndex = 0;
            this.rbDipendente.Text = "Dipendente";
            this.rbDipendente.CheckedChanged += new System.EventHandler(this.rbDipendente_CheckedChanged);
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(10, 50);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(69, 20);
            this.rbCliente.TabIndex = 1;
            this.rbCliente.Text = "Cliente";
            // 
            // lblNome
            // 
            this.lblNome.Location = new System.Drawing.Point(316, 206);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 22);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(416, 203);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblCognome
            // 
            this.lblCognome.Location = new System.Drawing.Point(316, 251);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(100, 23);
            this.lblCognome.TabIndex = 4;
            this.lblCognome.Text = "Cognome:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(416, 252);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(220, 22);
            this.txtCognome.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(316, 291);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(416, 292);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(316, 331);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 23);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(416, 332);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(220, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(316, 371);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(416, 368);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(220, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // lblMansione
            // 
            this.lblMansione.Location = new System.Drawing.Point(316, 411);
            this.lblMansione.Name = "lblMansione";
            this.lblMansione.Size = new System.Drawing.Size(100, 23);
            this.lblMansione.TabIndex = 12;
            this.lblMansione.Text = "Mansione:";
            // 
            // cmbMansione
            // 
            this.cmbMansione.Enabled = false;
            this.cmbMansione.Items.AddRange(new object[] {
            "Dirigente",
            "Gestore vendite",
            "Gestore contabilità",
            "Magazziniere"});
            this.cmbMansione.Location = new System.Drawing.Point(416, 408);
            this.cmbMansione.Name = "cmbMansione";
            this.cmbMansione.Size = new System.Drawing.Size(220, 24);
            this.cmbMansione.TabIndex = 13;
            // 
            // btnRegistrati
            // 
            this.btnRegistrati.Location = new System.Drawing.Point(386, 461);
            this.btnRegistrati.Name = "btnRegistrati";
            this.btnRegistrati.Size = new System.Drawing.Size(121, 31);
            this.btnRegistrati.TabIndex = 14;
            this.btnRegistrati.Text = "Registrati";
            this.btnRegistrati.Click += new System.EventHandler(this.btnRegistrati_Click);
            // 
            // btnIndietro
            // 
            this.btnIndietro.Location = new System.Drawing.Point(524, 461);
            this.btnIndietro.Name = "btnIndietro";
            this.btnIndietro.Size = new System.Drawing.Size(186, 31);
            this.btnIndietro.TabIndex = 15;
            this.btnIndietro.Text = "Torna alla pagina login";
            this.btnIndietro.Click += new System.EventHandler(this.btnIndietro_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(990, 518);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblMansione);
            this.Controls.Add(this.cmbMansione);
            this.Controls.Add(this.btnRegistrati);
            this.Controls.Add(this.btnIndietro);
            this.Name = "Form2";
            this.Text = "Registrazione";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

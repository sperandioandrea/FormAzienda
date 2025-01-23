namespace FormAzienda
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDipendenti;
        private System.Windows.Forms.DataGridView dgvDipendenti;
        private System.Windows.Forms.Label lblMagazzino;
        private System.Windows.Forms.DataGridView dgvMagazzino;
        private System.Windows.Forms.Label lblBustePaga;
        private System.Windows.Forms.DataGridView dgvBustePaga;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblDipendenti = new System.Windows.Forms.Label();
            this.dgvDipendenti = new System.Windows.Forms.DataGridView();
            this.lblMagazzino = new System.Windows.Forms.Label();
            this.dgvMagazzino = new System.Windows.Forms.DataGridView();
            this.lblBustePaga = new System.Windows.Forms.Label();
            this.dgvBustePaga = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDipendenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBustePaga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDipendenti
            // 
            this.lblDipendenti.AutoSize = true;
            this.lblDipendenti.Location = new System.Drawing.Point(20, 20);
            this.lblDipendenti.Name = "lblDipendenti";
            this.lblDipendenti.Size = new System.Drawing.Size(120, 16);
            this.lblDipendenti.TabIndex = 0;
            this.lblDipendenti.Text = "Elenco Dipendenti:";
            // 
            // dgvDipendenti
            // 
            this.dgvDipendenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDipendenti.ColumnHeadersHeight = 29;
            this.dgvDipendenti.Location = new System.Drawing.Point(20, 50);
            this.dgvDipendenti.Name = "dgvDipendenti";
            this.dgvDipendenti.ReadOnly = true;
            this.dgvDipendenti.RowHeadersWidth = 51;
            this.dgvDipendenti.Size = new System.Drawing.Size(750, 150);
            this.dgvDipendenti.TabIndex = 1;
            // 
            // lblMagazzino
            // 
            this.lblMagazzino.AutoSize = true;
            this.lblMagazzino.Location = new System.Drawing.Point(20, 220);
            this.lblMagazzino.Name = "lblMagazzino";
            this.lblMagazzino.Size = new System.Drawing.Size(75, 16);
            this.lblMagazzino.TabIndex = 2;
            this.lblMagazzino.Text = "Magazzino:";
            // 
            // dgvMagazzino
            // 
            this.dgvMagazzino.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMagazzino.ColumnHeadersHeight = 29;
            this.dgvMagazzino.Location = new System.Drawing.Point(20, 250);
            this.dgvMagazzino.Name = "dgvMagazzino";
            this.dgvMagazzino.ReadOnly = true;
            this.dgvMagazzino.RowHeadersWidth = 51;
            this.dgvMagazzino.Size = new System.Drawing.Size(750, 150);
            this.dgvMagazzino.TabIndex = 3;
            // 
            // lblBustePaga
            // 
            this.lblBustePaga.AutoSize = true;
            this.lblBustePaga.Location = new System.Drawing.Point(20, 420);
            this.lblBustePaga.Name = "lblBustePaga";
            this.lblBustePaga.Size = new System.Drawing.Size(80, 16);
            this.lblBustePaga.TabIndex = 4;
            this.lblBustePaga.Text = "Buste Paga:";
            // 
            // dgvBustePaga
            // 
            this.dgvBustePaga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBustePaga.ColumnHeadersHeight = 29;
            this.dgvBustePaga.Location = new System.Drawing.Point(20, 450);
            this.dgvBustePaga.Name = "dgvBustePaga";
            this.dgvBustePaga.ReadOnly = true;
            this.dgvBustePaga.RowHeadersWidth = 51;
            this.dgvBustePaga.Size = new System.Drawing.Size(750, 150);
            this.dgvBustePaga.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(778, 8);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form8
            // 
            this.ClientSize = new System.Drawing.Size(910, 650);
            this.Controls.Add(this.lblDipendenti);
            this.Controls.Add(this.dgvDipendenti);
            this.Controls.Add(this.lblMagazzino);
            this.Controls.Add(this.dgvMagazzino);
            this.Controls.Add(this.lblBustePaga);
            this.Controls.Add(this.dgvBustePaga);
            this.Controls.Add(this.btnLogout);
            this.Name = "Form8";
            this.Text = "Pagina Dirigente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDipendenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBustePaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

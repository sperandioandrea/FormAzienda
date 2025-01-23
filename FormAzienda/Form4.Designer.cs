namespace FormAzienda
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblIdProdotto;
        private System.Windows.Forms.TextBox txtIdProdotto;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.TextBox txtPrezzo;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.DataGridView dgvMagazzino;

        private void InitializeComponent()
        {
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblIdProdotto = new System.Windows.Forms.Label();
            this.txtIdProdotto = new System.Windows.Forms.TextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.dgvMagazzino = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.Location = new System.Drawing.Point(482, 69);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(237, 32);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Gestione Vendite";
            // 
            // lblIdProdotto
            // 
            this.lblIdProdotto.Location = new System.Drawing.Point(362, 109);
            this.lblIdProdotto.Name = "lblIdProdotto";
            this.lblIdProdotto.Size = new System.Drawing.Size(100, 23);
            this.lblIdProdotto.TabIndex = 1;
            this.lblIdProdotto.Text = "ID Prodotto:";
            // 
            // txtIdProdotto
            // 
            this.txtIdProdotto.Location = new System.Drawing.Point(482, 109);
            this.txtIdProdotto.Name = "txtIdProdotto";
            this.txtIdProdotto.Size = new System.Drawing.Size(100, 22);
            this.txtIdProdotto.TabIndex = 2;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.Location = new System.Drawing.Point(362, 149);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(100, 23);
            this.lblDescrizione.TabIndex = 3;
            this.lblDescrizione.Text = "Descrizione:";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(482, 149);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 22);
            this.txtDescrizione.TabIndex = 4;
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.Location = new System.Drawing.Point(362, 189);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(100, 23);
            this.lblPrezzo.TabIndex = 5;
            this.lblPrezzo.Text = "Prezzo:";
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(482, 189);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 22);
            this.txtPrezzo.TabIndex = 6;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(362, 229);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(220, 34);
            this.btnAggiungi.TabIndex = 7;
            this.btnAggiungi.Text = "Aggiungi/Modifica";
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // dgvMagazzino
            // 
            this.dgvMagazzino.ColumnHeadersHeight = 29;
            this.dgvMagazzino.Location = new System.Drawing.Point(362, 269);
            this.dgvMagazzino.Name = "dgvMagazzino";
            this.dgvMagazzino.RowHeadersWidth = 51;
            this.dgvMagazzino.Size = new System.Drawing.Size(500, 200);
            this.dgvMagazzino.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(971, 429);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(1174, 570);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.lblIdProdotto);
            this.Controls.Add(this.txtIdProdotto);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.dgvMagazzino);
            this.Name = "Form4";
            this.Text = "Gestione Vendite";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogout;
    }
}

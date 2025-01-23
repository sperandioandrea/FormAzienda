namespace FormAzienda
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.Label lblNomeProdotto;
        private System.Windows.Forms.TextBox txtNomeProdotto;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Label lblIdProdotto;
        private System.Windows.Forms.TextBox txtIdProdotto;
        private System.Windows.Forms.Button btnAggiungi;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.DataGridView dgvMagazzino;

        private void InitializeComponent()
        {
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblNomeProdotto = new System.Windows.Forms.Label();
            this.txtNomeProdotto = new System.Windows.Forms.TextBox();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.lblIdProdotto = new System.Windows.Forms.Label();
            this.txtIdProdotto = new System.Windows.Forms.TextBox();
            this.btnAggiungi = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.dgvMagazzino = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).BeginInit();
            this.SuspendLayout();
            //

            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.Location = new System.Drawing.Point(489, 42);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(277, 32);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Gestione Magazzino";
            // 
            // lblNomeProdotto
            // 
            this.lblNomeProdotto.Location = new System.Drawing.Point(369, 82);
            this.lblNomeProdotto.Name = "lblNomeProdotto";
            this.lblNomeProdotto.Size = new System.Drawing.Size(100, 23);
            this.lblNomeProdotto.TabIndex = 1;
            this.lblNomeProdotto.Text = "Nome Prodotto:";
            // 
            // txtNomeProdotto
            // 
            this.txtNomeProdotto.Location = new System.Drawing.Point(489, 82);
            this.txtNomeProdotto.Name = "txtNomeProdotto";
            this.txtNomeProdotto.Size = new System.Drawing.Size(100, 22);
            this.txtNomeProdotto.TabIndex = 2;
            // 
            // lblQuantita
            // 
            this.lblQuantita.Location = new System.Drawing.Point(369, 122);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(100, 23);
            this.lblQuantita.TabIndex = 3;
            this.lblQuantita.Text = "Quantità:";
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(489, 122);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(100, 22);
            this.txtQuantita.TabIndex = 4;
            // 
            // lblIdProdotto
            // 
            this.lblIdProdotto.Location = new System.Drawing.Point(369, 162);
            this.lblIdProdotto.Name = "lblIdProdotto";
            this.lblIdProdotto.Size = new System.Drawing.Size(100, 23);
            this.lblIdProdotto.TabIndex = 5;
            this.lblIdProdotto.Text = "ID Prodotto:";
            // 
            // txtIdProdotto
            // 
            this.txtIdProdotto.Location = new System.Drawing.Point(489, 162);
            this.txtIdProdotto.Name = "txtIdProdotto";
            this.txtIdProdotto.Size = new System.Drawing.Size(100, 22);
            this.txtIdProdotto.TabIndex = 6;
            // 
            // btnAggiungi
            // 
            this.btnAggiungi.Location = new System.Drawing.Point(369, 202);
            this.btnAggiungi.Name = "btnAggiungi";
            this.btnAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btnAggiungi.TabIndex = 7;
            this.btnAggiungi.Text = "Aggiungi";
            this.btnAggiungi.Click += new System.EventHandler(this.btnAggiungi_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(489, 202);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(75, 23);
            this.btnModifica.TabIndex = 8;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // dgvMagazzino
            // 
            this.dgvMagazzino.ColumnHeadersHeight = 29;
            this.dgvMagazzino.Location = new System.Drawing.Point(369, 257);
            this.dgvMagazzino.Name = "dgvMagazzino";
            this.dgvMagazzino.RowHeadersWidth = 51;
            this.dgvMagazzino.Size = new System.Drawing.Size(500, 200);
            this.dgvMagazzino.TabIndex = 9;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1008, 390);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 41);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(1209, 512);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.lblNomeProdotto);
            this.Controls.Add(this.txtNomeProdotto);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.lblIdProdotto);
            this.Controls.Add(this.txtIdProdotto);
            this.Controls.Add(this.btnAggiungi);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.dgvMagazzino);
            this.Name = "Form3";
            this.Text = "Gestione Magazzino";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMagazzino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogout;


    }
}

namespace FormAzienda
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.DataGridView dgvProdotti;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Button btnAggiungiCarrello;
        private System.Windows.Forms.Button btnVaiCarrello;

        private void InitializeComponent()
        {
            this.lblTitolo = new System.Windows.Forms.Label();
            this.dgvProdotti = new System.Windows.Forms.DataGridView();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.btnAggiungiCarrello = new System.Windows.Forms.Button();
            this.btnVaiCarrello = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.Location = new System.Drawing.Point(629, 26);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(122, 32);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Negozio";
            // 
            // dgvProdotti
            // 
            this.dgvProdotti.ColumnHeadersHeight = 29;
            this.dgvProdotti.Location = new System.Drawing.Point(395, 61);
            this.dgvProdotti.Name = "dgvProdotti";
            this.dgvProdotti.RowHeadersWidth = 51;
            this.dgvProdotti.Size = new System.Drawing.Size(600, 374);
            this.dgvProdotti.TabIndex = 1;
            // 
            // lblQuantita
            // 
            this.lblQuantita.Location = new System.Drawing.Point(505, 456);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(73, 23);
            this.lblQuantita.TabIndex = 2;
            this.lblQuantita.Text = "Quantità:";
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(584, 453);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(145, 22);
            this.txtQuantita.TabIndex = 3;
            // 
            // btnAggiungiCarrello
            // 
            this.btnAggiungiCarrello.Location = new System.Drawing.Point(505, 496);
            this.btnAggiungiCarrello.Name = "btnAggiungiCarrello";
            this.btnAggiungiCarrello.Size = new System.Drawing.Size(154, 52);
            this.btnAggiungiCarrello.TabIndex = 4;
            this.btnAggiungiCarrello.Text = "Aggiungi al Carrello";
            this.btnAggiungiCarrello.Click += new System.EventHandler(this.btnAggiungiCarrello_Click);
            // 
            // btnVaiCarrello
            // 
            this.btnVaiCarrello.Location = new System.Drawing.Point(706, 496);
            this.btnVaiCarrello.Name = "btnVaiCarrello";
            this.btnVaiCarrello.Size = new System.Drawing.Size(182, 52);
            this.btnVaiCarrello.TabIndex = 5;
            this.btnVaiCarrello.Text = "Vai al Carrello";
            this.btnVaiCarrello.Click += new System.EventHandler(this.btnVaiCarrello_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1104, 502);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(113, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(1249, 560);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.dgvProdotti);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.btnAggiungiCarrello);
            this.Controls.Add(this.btnVaiCarrello);
            this.Name = "Form5";
            this.Text = "Negozio";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnLogout;
    }
}

namespace FormAzienda
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitolo;
        private System.Windows.Forms.DataGridView dgvCarrello;
        private System.Windows.Forms.Button btnCompra;

        private void InitializeComponent()
        {
            this.lblTitolo = new System.Windows.Forms.Label();
            this.dgvCarrello = new System.Windows.Forms.DataGridView();
            this.btnCompra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrello)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitolo
            // 
            this.lblTitolo.AutoSize = true;
            this.lblTitolo.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitolo.Location = new System.Drawing.Point(380, 54);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(119, 32);
            this.lblTitolo.TabIndex = 0;
            this.lblTitolo.Text = "Carrello";
            // 
            // dgvCarrello
            // 
            this.dgvCarrello.AllowUserToAddRows = false;
            this.dgvCarrello.AllowUserToDeleteRows = false;
            this.dgvCarrello.ColumnHeadersHeight = 29;
            this.dgvCarrello.Location = new System.Drawing.Point(260, 94);
            this.dgvCarrello.Name = "dgvCarrello";
            this.dgvCarrello.ReadOnly = true;
            this.dgvCarrello.RowHeadersWidth = 51;
            this.dgvCarrello.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrello.Size = new System.Drawing.Size(600, 250);
            this.dgvCarrello.TabIndex = 1;
            // 
            // btnCompra
            // 
            this.btnCompra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnCompra.Location = new System.Drawing.Point(480, 364);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(150, 40);
            this.btnCompra.TabIndex = 2;
            this.btnCompra.Text = "Compra";
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(1000, 517);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.dgvCarrello);
            this.Controls.Add(this.btnCompra);
            this.Name = "Form6";
            this.Text = "Carrello";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrello)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

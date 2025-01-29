namespace FormAzienda
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvProdotti = new System.Windows.Forms.DataGridView();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdotti
            // 
            this.dgvProdotti.AllowUserToAddRows = false;
            this.dgvProdotti.AllowUserToDeleteRows = false;
            this.dgvProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdotti.Location = new System.Drawing.Point(209, 199);
            this.dgvProdotti.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdotti.Name = "dgvProdotti";
            this.dgvProdotti.ReadOnly = true;
            this.dgvProdotti.RowHeadersWidth = 51;
            this.dgvProdotti.Size = new System.Drawing.Size(906, 369);
            this.dgvProdotti.TabIndex = 0;
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(459, 151);
            this.txtQuantita.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(129, 22);
            this.txtQuantita.TabIndex = 1;
            // 
            // btnCompra
            // 
            this.btnCompra.BackColor = System.Drawing.Color.Yellow;
            this.btnCompra.Location = new System.Drawing.Point(663, 140);
            this.btnCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(133, 51);
            this.btnCompra.TabIndex = 2;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = false;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1144, 544);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblQuantita
            // 
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.ForeColor = System.Drawing.Color.White;
            this.lblQuantita.Location = new System.Drawing.Point(300, 157);
            this.lblQuantita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(139, 16);
            this.lblQuantita.TabIndex = 4;
            this.lblQuantita.Text = "Quantità da comprare:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(305, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(700, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "NEGOZIO - VENDITA PRODOTTI";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1257, 593);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCompra);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.dgvProdotti);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Negozio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdotti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvProdotti;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.Label label1;
    }
}

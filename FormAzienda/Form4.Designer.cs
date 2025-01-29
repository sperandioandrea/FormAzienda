using System.Windows.Forms;

namespace FormAzienda
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewProdotti;
        private Button btnModifica;
        private TextBox txtDescrizione;
        private TextBox txtPrezzo;
        private Button btnLogout;
        private Label lblDescrizione;
        private Label lblPrezzo;

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
            this.dataGridViewProdotti = new System.Windows.Forms.DataGridView();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdotti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdotti
            // 
            this.dataGridViewProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdotti.Location = new System.Drawing.Point(189, 95);
            this.dataGridViewProdotti.Name = "dataGridViewProdotti";
            this.dataGridViewProdotti.RowHeadersWidth = 51;
            this.dataGridViewProdotti.Size = new System.Drawing.Size(901, 293);
            this.dataGridViewProdotti.TabIndex = 0;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.Yellow;
            this.btnModifica.ForeColor = System.Drawing.Color.Black;
            this.btnModifica.Location = new System.Drawing.Point(661, 471);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(154, 47);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Aggiungi/Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(443, 471);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(128, 22);
            this.txtDescrizione.TabIndex = 2;
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(443, 521);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 22);
            this.txtPrezzo.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1086, 538);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.ForeColor = System.Drawing.Color.White;
            this.lblDescrizione.Location = new System.Drawing.Point(440, 446);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(78, 16);
            this.lblDescrizione.TabIndex = 5;
            this.lblDescrizione.Text = "Descrizione";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.ForeColor = System.Drawing.Color.White;
            this.lblPrezzo.Location = new System.Drawing.Point(440, 502);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(48, 16);
            this.lblPrezzo.TabIndex = 6;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(434, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "GESTIONE VENDITE";
            // 
            // Form4
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1173, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtPrezzo);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.dataGridViewProdotti);
            this.Name = "Form4";
            this.Text = "Gestione Vendite";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdotti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}

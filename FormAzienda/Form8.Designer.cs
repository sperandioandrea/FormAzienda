using System.Windows.Forms;

namespace FormAzienda
{
    partial class Form8
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewDipendenti;
        private DataGridView dataGridViewProdotti;
        private DataGridView dataGridViewBustePaga;
        private Button btnLogout;
        private Label labelDipendenti;
        private Label labelProdotti;
        private Label labelBustePaga;

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
            this.dataGridViewDipendenti = new System.Windows.Forms.DataGridView();
            this.dataGridViewProdotti = new System.Windows.Forms.DataGridView();
            this.dataGridViewBustePaga = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labelDipendenti = new System.Windows.Forms.Label();
            this.labelProdotti = new System.Windows.Forms.Label();
            this.labelBustePaga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDipendenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdotti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBustePaga)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDipendenti
            // 
            this.dataGridViewDipendenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDipendenti.Location = new System.Drawing.Point(188, 74);
            this.dataGridViewDipendenti.Name = "dataGridViewDipendenti";
            this.dataGridViewDipendenti.RowHeadersWidth = 51;
            this.dataGridViewDipendenti.Size = new System.Drawing.Size(539, 254);
            this.dataGridViewDipendenti.TabIndex = 0;
            // 
            // dataGridViewProdotti
            // 
            this.dataGridViewProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdotti.Location = new System.Drawing.Point(828, 345);
            this.dataGridViewProdotti.Name = "dataGridViewProdotti";
            this.dataGridViewProdotti.RowHeadersWidth = 51;
            this.dataGridViewProdotti.Size = new System.Drawing.Size(418, 254);
            this.dataGridViewProdotti.TabIndex = 1;
            // 
            // dataGridViewBustePaga
            // 
            this.dataGridViewBustePaga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBustePaga.Location = new System.Drawing.Point(15, 364);
            this.dataGridViewBustePaga.Name = "dataGridViewBustePaga";
            this.dataGridViewBustePaga.RowHeadersWidth = 51;
            this.dataGridViewBustePaga.Size = new System.Drawing.Size(773, 235);
            this.dataGridViewBustePaga.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1252, 563);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(83, 36);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelDipendenti
            // 
            this.labelDipendenti.AutoSize = true;
            this.labelDipendenti.ForeColor = System.Drawing.Color.White;
            this.labelDipendenti.Location = new System.Drawing.Point(188, 54);
            this.labelDipendenti.Name = "labelDipendenti";
            this.labelDipendenti.Size = new System.Drawing.Size(72, 16);
            this.labelDipendenti.TabIndex = 4;
            this.labelDipendenti.Text = "Dipendenti";
            // 
            // labelProdotti
            // 
            this.labelProdotti.AutoSize = true;
            this.labelProdotti.ForeColor = System.Drawing.Color.White;
            this.labelProdotti.Location = new System.Drawing.Point(825, 326);
            this.labelProdotti.Name = "labelProdotti";
            this.labelProdotti.Size = new System.Drawing.Size(53, 16);
            this.labelProdotti.TabIndex = 5;
            this.labelProdotti.Text = "Prodotti";
            // 
            // labelBustePaga
            // 
            this.labelBustePaga.AutoSize = true;
            this.labelBustePaga.ForeColor = System.Drawing.Color.White;
            this.labelBustePaga.Location = new System.Drawing.Point(12, 345);
            this.labelBustePaga.Name = "labelBustePaga";
            this.labelBustePaga.Size = new System.Drawing.Size(77, 16);
            this.labelBustePaga.TabIndex = 6;
            this.labelBustePaga.Text = "Buste Paga";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(889, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "DIRIGENTE";
            // 
            // Form8
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1347, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBustePaga);
            this.Controls.Add(this.labelProdotti);
            this.Controls.Add(this.labelDipendenti);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dataGridViewBustePaga);
            this.Controls.Add(this.dataGridViewProdotti);
            this.Controls.Add(this.dataGridViewDipendenti);
            this.Name = "Form8";
            this.Text = "Pagina Dirigente";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDipendenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdotti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBustePaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
    }
}

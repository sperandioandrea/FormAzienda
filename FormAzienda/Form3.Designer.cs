namespace FormAzienda
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProdotti;
        private System.Windows.Forms.TextBox txtNomeProdotto;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Button btnAggiungiProdotto;
        private System.Windows.Forms.Button btnModificaProdotto;
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
            this.dataGridViewProdotti = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeProdotto = new System.Windows.Forms.TextBox();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.btnAggiungiProdotto = new System.Windows.Forms.Button();
            this.btnModificaProdotto = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdotti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProdotti
            // 
            this.dataGridViewProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdotti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewProdotti.Location = new System.Drawing.Point(114, 101);
            this.dataGridViewProdotti.Name = "dataGridViewProdotti";
            this.dataGridViewProdotti.RowHeadersWidth = 51;
            this.dataGridViewProdotti.Size = new System.Drawing.Size(430, 410);
            this.dataGridViewProdotti.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "nome prodotto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "quantità";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // txtNomeProdotto
            // 
            this.txtNomeProdotto.Location = new System.Drawing.Point(614, 217);
            this.txtNomeProdotto.Name = "txtNomeProdotto";
            this.txtNomeProdotto.Size = new System.Drawing.Size(200, 22);
            this.txtNomeProdotto.TabIndex = 1;
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(614, 264);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(200, 22);
            this.txtQuantita.TabIndex = 2;
            // 
            // btnAggiungiProdotto
            // 
            this.btnAggiungiProdotto.BackColor = System.Drawing.Color.Yellow;
            this.btnAggiungiProdotto.Location = new System.Drawing.Point(614, 311);
            this.btnAggiungiProdotto.Name = "btnAggiungiProdotto";
            this.btnAggiungiProdotto.Size = new System.Drawing.Size(200, 42);
            this.btnAggiungiProdotto.TabIndex = 3;
            this.btnAggiungiProdotto.Text = "Aggiungi";
            this.btnAggiungiProdotto.UseVisualStyleBackColor = false;
            this.btnAggiungiProdotto.Click += new System.EventHandler(this.btnAggiungiProdotto_Click);
            // 
            // btnModificaProdotto
            // 
            this.btnModificaProdotto.BackColor = System.Drawing.Color.Yellow;
            this.btnModificaProdotto.Location = new System.Drawing.Point(614, 380);
            this.btnModificaProdotto.Name = "btnModificaProdotto";
            this.btnModificaProdotto.Size = new System.Drawing.Size(200, 42);
            this.btnModificaProdotto.TabIndex = 4;
            this.btnModificaProdotto.Text = "Modifica";
            this.btnModificaProdotto.UseVisualStyleBackColor = false;
            this.btnModificaProdotto.Click += new System.EventHandler(this.btnModificaProdotto_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(950, 481);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 48);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(416, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "MAGAZZINO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(611, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "nome prodotto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(611, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "quantità";
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1051, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnModificaProdotto);
            this.Controls.Add(this.btnAggiungiProdotto);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.txtNomeProdotto);
            this.Controls.Add(this.dataGridViewProdotti);
            this.Name = "Form3";
            this.Text = "Gestione Magazzino";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdotti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

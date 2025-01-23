namespace FormAzienda
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbDipendenti;
        private System.Windows.Forms.Label lblDipendenti;
        private System.Windows.Forms.NumericUpDown numOreMensili;
        private System.Windows.Forms.Label lblOreMensili;
        private System.Windows.Forms.DateTimePicker dtpDataStipendio;
        private System.Windows.Forms.Label lblDataStipendio;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.DataGridView dgvBustePaga;
        private System.Windows.Forms.Label lblBustePaga;
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
            this.cmbDipendenti = new System.Windows.Forms.ComboBox();
            this.lblDipendenti = new System.Windows.Forms.Label();
            this.numOreMensili = new System.Windows.Forms.NumericUpDown();
            this.lblOreMensili = new System.Windows.Forms.Label();
            this.dtpDataStipendio = new System.Windows.Forms.DateTimePicker();
            this.lblDataStipendio = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.dgvBustePaga = new System.Windows.Forms.DataGridView();
            this.lblBustePaga = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOreMensili)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBustePaga)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDipendenti
            // 
            this.cmbDipendenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDipendenti.Location = new System.Drawing.Point(423, 51);
            this.cmbDipendenti.Name = "cmbDipendenti";
            this.cmbDipendenti.Size = new System.Drawing.Size(200, 24);
            this.cmbDipendenti.TabIndex = 1;
            // 
            // lblDipendenti
            // 
            this.lblDipendenti.AutoSize = true;
            this.lblDipendenti.Location = new System.Drawing.Point(283, 51);
            this.lblDipendenti.Name = "lblDipendenti";
            this.lblDipendenti.Size = new System.Drawing.Size(143, 16);
            this.lblDipendenti.TabIndex = 0;
            this.lblDipendenti.Text = "Seleziona Dipendente:";
            // 
            // numOreMensili
            // 
            this.numOreMensili.Location = new System.Drawing.Point(423, 101);
            this.numOreMensili.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numOreMensili.Name = "numOreMensili";
            this.numOreMensili.Size = new System.Drawing.Size(120, 22);
            this.numOreMensili.TabIndex = 3;
            // 
            // lblOreMensili
            // 
            this.lblOreMensili.AutoSize = true;
            this.lblOreMensili.Location = new System.Drawing.Point(283, 101);
            this.lblOreMensili.Name = "lblOreMensili";
            this.lblOreMensili.Size = new System.Drawing.Size(77, 16);
            this.lblOreMensili.TabIndex = 2;
            this.lblOreMensili.Text = "Ore Mensili:";
            // 
            // dtpDataStipendio
            // 
            this.dtpDataStipendio.Location = new System.Drawing.Point(423, 151);
            this.dtpDataStipendio.Name = "dtpDataStipendio";
            this.dtpDataStipendio.Size = new System.Drawing.Size(250, 22);
            this.dtpDataStipendio.TabIndex = 5;
            // 
            // lblDataStipendio
            // 
            this.lblDataStipendio.AutoSize = true;
            this.lblDataStipendio.Location = new System.Drawing.Point(283, 151);
            this.lblDataStipendio.Name = "lblDataStipendio";
            this.lblDataStipendio.Size = new System.Drawing.Size(132, 16);
            this.lblDataStipendio.TabIndex = 4;
            this.lblDataStipendio.Text = "Data dello Stipendio:";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(283, 201);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(120, 40);
            this.btnCalcola.TabIndex = 6;
            this.btnCalcola.Text = "Calcola Stipendio";
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // dgvBustePaga
            // 
            this.dgvBustePaga.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBustePaga.ColumnHeadersHeight = 29;
            this.dgvBustePaga.Location = new System.Drawing.Point(283, 291);
            this.dgvBustePaga.Name = "dgvBustePaga";
            this.dgvBustePaga.ReadOnly = true;
            this.dgvBustePaga.RowHeadersWidth = 51;
            this.dgvBustePaga.Size = new System.Drawing.Size(600, 200);
            this.dgvBustePaga.TabIndex = 8;
            // 
            // lblBustePaga
            // 
            this.lblBustePaga.AutoSize = true;
            this.lblBustePaga.Location = new System.Drawing.Point(283, 261);
            this.lblBustePaga.Name = "lblBustePaga";
            this.lblBustePaga.Size = new System.Drawing.Size(80, 16);
            this.lblBustePaga.TabIndex = 7;
            this.lblBustePaga.Text = "Buste Paga:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(763, 51);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Form7
            // 
            this.ClientSize = new System.Drawing.Size(1172, 549);
            this.Controls.Add(this.lblDipendenti);
            this.Controls.Add(this.cmbDipendenti);
            this.Controls.Add(this.lblOreMensili);
            this.Controls.Add(this.numOreMensili);
            this.Controls.Add(this.lblDataStipendio);
            this.Controls.Add(this.dtpDataStipendio);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.lblBustePaga);
            this.Controls.Add(this.dgvBustePaga);
            this.Controls.Add(this.btnLogout);
            this.Name = "Form7";
            this.Text = "Gestione Contabilità";
            ((System.ComponentModel.ISupportInitialize)(this.numOreMensili)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBustePaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

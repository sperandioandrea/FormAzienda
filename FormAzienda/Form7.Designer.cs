using System.Windows.Forms;

namespace FormAzienda
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbDipendenti;
        private TextBox txtOreMensili;
        private DateTimePicker dtpDataStipendio;
        private Button btnCalcolaStipendio;
        private DataGridView dgvBustePaga;
        private Button btnLogout;

        private void InitializeComponent()
        {
            this.cmbDipendenti = new System.Windows.Forms.ComboBox();
            this.txtOreMensili = new System.Windows.Forms.TextBox();
            this.dtpDataStipendio = new System.Windows.Forms.DateTimePicker();
            this.btnCalcolaStipendio = new System.Windows.Forms.Button();
            this.dgvBustePaga = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBustePaga)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDipendenti
            // 
            this.cmbDipendenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDipendenti.FormattingEnabled = true;
            this.cmbDipendenti.Location = new System.Drawing.Point(985, 196);
            this.cmbDipendenti.Name = "cmbDipendenti";
            this.cmbDipendenti.Size = new System.Drawing.Size(200, 24);
            this.cmbDipendenti.TabIndex = 0;
            // 
            // txtOreMensili
            // 
            this.txtOreMensili.Location = new System.Drawing.Point(985, 246);
            this.txtOreMensili.Name = "txtOreMensili";
            this.txtOreMensili.Size = new System.Drawing.Size(200, 22);
            this.txtOreMensili.TabIndex = 1;
            // 
            // dtpDataStipendio
            // 
            this.dtpDataStipendio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataStipendio.Location = new System.Drawing.Point(985, 291);
            this.dtpDataStipendio.Name = "dtpDataStipendio";
            this.dtpDataStipendio.Size = new System.Drawing.Size(200, 22);
            this.dtpDataStipendio.TabIndex = 2;
            // 
            // btnCalcolaStipendio
            // 
            this.btnCalcolaStipendio.BackColor = System.Drawing.Color.Yellow;
            this.btnCalcolaStipendio.Location = new System.Drawing.Point(985, 340);
            this.btnCalcolaStipendio.Name = "btnCalcolaStipendio";
            this.btnCalcolaStipendio.Size = new System.Drawing.Size(200, 39);
            this.btnCalcolaStipendio.TabIndex = 3;
            this.btnCalcolaStipendio.Text = "Calcola Stipendio";
            this.btnCalcolaStipendio.UseVisualStyleBackColor = false;
            this.btnCalcolaStipendio.Click += new System.EventHandler(this.btnCalcolaStipendio_Click);
            // 
            // dgvBustePaga
            // 
            this.dgvBustePaga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBustePaga.Location = new System.Drawing.Point(12, 126);
            this.dgvBustePaga.Name = "dgvBustePaga";
            this.dgvBustePaga.RowHeadersWidth = 51;
            this.dgvBustePaga.Size = new System.Drawing.Size(949, 286);
            this.dgvBustePaga.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1103, 423);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 36);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(982, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selezionare il dipendente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(982, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ore di lavoro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(982, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data busta paga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(143, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(836, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "GESTORE CONTABILITA\' DIPENDENTI";
            // 
            // Form7
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1233, 471);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.dgvBustePaga);
            this.Controls.Add(this.btnCalcolaStipendio);
            this.Controls.Add(this.dtpDataStipendio);
            this.Controls.Add(this.txtOreMensili);
            this.Controls.Add(this.cmbDipendenti);
            this.Name = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBustePaga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            CaricaProdotti();
        }

        private void CaricaProdotti()
        {
            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nome_prodotto, descrizione, prezzo, quantita FROM magazzino";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProdotti.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nel caricamento dei prodotti: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAggiungiCarrello_Click(object sender, EventArgs e)
        {
            if (dgvProdotti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleziona un prodotto!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idProdotto = dgvProdotti.SelectedRows[0].Cells["id"].Value.ToString();
            string nomeProdotto = dgvProdotti.SelectedRows[0].Cells["nome_prodotto"].Value.ToString();
            string prezzo = dgvProdotti.SelectedRows[0].Cells["prezzo"].Value.ToString();
            string quantitaSelezionata = txtQuantita.Text.Trim();

            if (string.IsNullOrWhiteSpace(quantitaSelezionata) || !int.TryParse(quantitaSelezionata, out int quantita) || quantita <= 0)
            {
                MessageBox.Show("Inserisci una quantità valida!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO carrello (id_prodotto, nome_prodotto, prezzo, quantita) VALUES (@id, @nome, @prezzo, @quantita)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idProdotto);
                    cmd.Parameters.AddWithValue("@nome", nomeProdotto);
                    cmd.Parameters.AddWithValue("@prezzo", prezzo);
                    cmd.Parameters.AddWithValue("@quantita", quantita);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Prodotto aggiunto al carrello!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nell'aggiunta al carrello: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVaiCarrello_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Mostra la pagina di login
            Form1 form1 = new Form1();
            form1.Show();

            // Chiudi l'attuale form
            this.Close();
        }
    }
}

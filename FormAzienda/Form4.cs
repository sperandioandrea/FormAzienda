using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            CaricaMagazzino();
        }

        private void CaricaMagazzino()
        {
            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nome_prodotto, quantita, descrizione, prezzo FROM magazzino";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMagazzino.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nel caricamento del magazzino: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string idProdotto = txtIdProdotto.Text.Trim();
            string descrizione = txtDescrizione.Text.Trim();
            string prezzo = txtPrezzo.Text.Trim();

            if (string.IsNullOrWhiteSpace(idProdotto) || string.IsNullOrWhiteSpace(descrizione) || string.IsNullOrWhiteSpace(prezzo))
            {
                MessageBox.Show("Compila tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE magazzino SET descrizione = @descrizione, prezzo = @prezzo WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@descrizione", descrizione);
                    cmd.Parameters.AddWithValue("@prezzo", prezzo);
                    cmd.Parameters.AddWithValue("@id", idProdotto);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Informazioni aggiunte/modificate con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CaricaMagazzino();
                    }
                    else
                    {
                        MessageBox.Show("Prodotto non trovato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nell'aggiornamento del prodotto: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

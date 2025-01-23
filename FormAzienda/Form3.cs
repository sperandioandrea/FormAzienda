using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form3 : Form
    {
        public Form3()
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
                    string query = "SELECT id, nome_prodotto, quantita FROM magazzino";
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
            string nomeProdotto = txtNomeProdotto.Text.Trim();
            string quantita = txtQuantita.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeProdotto) || string.IsNullOrWhiteSpace(quantita))
            {
                MessageBox.Show("Compila tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO magazzino (nome_prodotto, quantita) VALUES (@nome, @quantita)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", nomeProdotto);
                    cmd.Parameters.AddWithValue("@quantita", quantita);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Prodotto aggiunto al magazzino!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CaricaMagazzino();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nell'aggiunta del prodotto: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string idProdotto = txtIdProdotto.Text.Trim();
            string nuovoNome = txtNomeProdotto.Text.Trim();
            string nuovaQuantita = txtQuantita.Text.Trim();

            if (string.IsNullOrWhiteSpace(idProdotto) || string.IsNullOrWhiteSpace(nuovoNome) || string.IsNullOrWhiteSpace(nuovaQuantita))
            {
                MessageBox.Show("Compila tutti i campi!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE magazzino SET nome_prodotto = @nome, quantita = @quantita WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", nuovoNome);
                    cmd.Parameters.AddWithValue("@quantita", nuovaQuantita);
                    cmd.Parameters.AddWithValue("@id", idProdotto);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Prodotto aggiornato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CaricaMagazzino();
                    }
                    else
                    {
                        MessageBox.Show("Prodotto non trovato!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nella modifica del prodotto: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            // Mostra la pagina di login
            Form1 form1 = new Form1();
            form1.Show();

            // Chiudi l'attuale form
            this.Close();
        }
    }
}

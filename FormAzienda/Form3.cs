using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form3 : Form
    {
        private Db db = new Db();
        private int userId; // Variabile per memorizzare l'ID dell'utente

        public Form3(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Carica i dati del magazzino al caricamento del form
            CaricaProdotti();
        }

        private void CaricaProdotti()
        {
            try
            {
                db.OpenConnection();
                string query = "SELECT id, nome_prodotto, quantita FROM prodotti_magazzino";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Pulisci la lista esistente
                dataGridViewProdotti.Rows.Clear();

                // Aggiungi i prodotti alla DataGridView
                while (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    string nomeProdotto = reader.GetString("nome_prodotto");
                    int quantita = reader.GetInt32("quantita");

                    // Aggiungi la riga alla DataGridView
                    dataGridViewProdotti.Rows.Add(id, nomeProdotto, quantita);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento dei prodotti: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnAggiungiProdotto_Click(object sender, EventArgs e)
        {
            string nomeProdotto = txtNomeProdotto.Text.Trim();
            int quantita;
            if (!int.TryParse(txtQuantita.Text.Trim(), out quantita) || quantita <= 0)
            {
                MessageBox.Show("Inserisci una quantità valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.OpenConnection();
                string query = "INSERT INTO prodotti_magazzino (nome_prodotto, quantita) VALUES (@nomeProdotto, @quantita)";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@nomeProdotto", nomeProdotto);
                cmd.Parameters.AddWithValue("@quantita", quantita);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Prodotto aggiunto con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ricarica i prodotti
                CaricaProdotti();

                // Pulisci i campi di input
                txtNomeProdotto.Clear();
                txtQuantita.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'aggiunta del prodotto: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnModificaProdotto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdotti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleziona un prodotto da modificare", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int prodottoId = Convert.ToInt32(dataGridViewProdotti.SelectedRows[0].Cells[0].Value);
            string nuovoNomeProdotto = txtNomeProdotto.Text.Trim();
            int nuovaQuantita;
            if (!int.TryParse(txtQuantita.Text.Trim(), out nuovaQuantita) || nuovaQuantita <= 0)
            {
                MessageBox.Show("Inserisci una quantità valida", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.OpenConnection();
                string query = "UPDATE prodotti_magazzino SET nome_prodotto = @nomeProdotto, quantita = @quantita WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@nomeProdotto", nuovoNomeProdotto);
                cmd.Parameters.AddWithValue("@quantita", nuovaQuantita);
                cmd.Parameters.AddWithValue("@id", prodottoId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Prodotto modificato con successo", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ricarica i prodotti
                CaricaProdotti();

                // Pulisci i campi di input
                txtNomeProdotto.Clear();
                txtQuantita.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la modifica del prodotto: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Torna al login
            this.Hide();
            new Form1().Show();
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            CaricaCarrello();
        }

        private void CaricaCarrello()
        {
            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nome_prodotto, prezzo, quantita FROM carrello";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCarrello.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nel caricamento del carrello: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string queryAggiornaMagazzino = @"
                        UPDATE magazzino AS m
                        JOIN carrello AS c ON m.id = c.id_prodotto
                        SET m.quantita = m.quantita - c.quantita
                        WHERE c.quantita <= m.quantita;
                        DELETE FROM carrello;
                    ";

                    MySqlCommand cmd = new MySqlCommand(queryAggiornaMagazzino, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Prodotti acquistati con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CaricaCarrello();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante l'acquisto: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

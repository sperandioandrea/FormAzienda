using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form5 : Form
    {
        private Db db = new Db();
        private int userId;

        public Form5(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Salviamo l'ID dell'utente autenticato
            CaricaProdotti(); // Carica i prodotti all'avvio
        }

        // Metodo per caricare i prodotti nella DataGridView
        private void CaricaProdotti()
        {
            string query = "SELECT id, nome_prodotto, prezzo, descrizione, quantita FROM prodotti_magazzino";
            DataTable prodotti = db.ExecuteQuery(query); // Usa ExecuteQuery della classe Db
            dgvProdotti.DataSource = prodotti; // Imposta la sorgente dati della DataGridView
        }

        // Evento click per il bottone "Compra"
        private void btnCompra_Click(object sender, EventArgs e)
        {
            if (dgvProdotti.SelectedRows.Count > 0)
            {
                int idProdotto = Convert.ToInt32(dgvProdotti.SelectedRows[0].Cells["id"].Value);
                int quantitaDisponibile = Convert.ToInt32(dgvProdotti.SelectedRows[0].Cells["quantita"].Value);

                if (int.TryParse(txtQuantita.Text, out int quantitaAcquistata) && quantitaAcquistata > 0)
                {
                    if (quantitaAcquistata <= quantitaDisponibile)
                    {
                        try
                        {
                            // Aggiorna il database
                            string queryUpdate = "UPDATE prodotti_magazzino SET quantita = quantita - @quantitaAcquistata WHERE id = @idProdotto";
                            db.ExecuteNonQuery(queryUpdate,
                                new MySqlParameter("@quantitaAcquistata", quantitaAcquistata),
                                new MySqlParameter("@idProdotto", idProdotto));

                            // Notifica all'utente
                            MessageBox.Show("Acquisto completato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Ricarica i prodotti
                            CaricaProdotti();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Errore durante l'acquisto: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La quantità richiesta supera quella disponibile!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Inserire una quantità valida!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Selezionare un prodotto prima di acquistare!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento click per il bottone "Logout"
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}

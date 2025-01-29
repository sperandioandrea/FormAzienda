using FormAzienda;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Usa MySql.Data.MySqlClient invece di System.Data.SqlClient

namespace FormAzienda
{
    public partial class Form4 : Form
    {
        private Db db = new Db(); // Classe Db per la connessione al database
        private int userId; // Memorizza l'ID dell'utente autenticato

        // Costruttore che accetta userId
        public Form4(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Memorizza l'ID utente
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Carica i prodotti dal magazzino
            LoadProducts();
        }

        // Metodo per caricare i prodotti dal database
        private void LoadProducts()
        {
            string query = "SELECT p.id, p.nome_prodotto, p.quantita, p.descrizione, p.prezzo " +
                           "FROM prodotti_magazzino p " +
                           "WHERE p.quantita > 0"; // Solo i prodotti con disponibilità

            DataTable dt = db.ExecuteQuery(query);
            dataGridViewProdotti.DataSource = dt;
        }

        // Metodo per modificare il prezzo e la descrizione di un prodotto
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdotti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleziona un prodotto da modificare.");
                return;
            }

            int productId = Convert.ToInt32(dataGridViewProdotti.SelectedRows[0].Cells[0].Value);
            string newDescription = txtDescrizione.Text;
            decimal newPrice;

            // Verifica se il prezzo è valido
            if (!decimal.TryParse(txtPrezzo.Text, out newPrice))
            {
                MessageBox.Show("Inserisci un prezzo valido.");
                return;
            }

            string updateQuery = "UPDATE prodotti_magazzino SET descrizione = @descrizione, prezzo = @prezzo " +
                                 "WHERE id = @id";

            // Usa MySqlParameter invece di SqlParameter
            var parameters = new[]
            {
                new MySqlParameter("@descrizione", newDescription),
                new MySqlParameter("@prezzo", newPrice),
                new MySqlParameter("@id", productId)
            };

            db.ExecuteNonQuery(updateQuery, parameters);
            MessageBox.Show("Prodotto modificato con successo!");
            LoadProducts(); // Ricarica la lista aggiornata dei prodotti
        }

        // Metodo per il logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}

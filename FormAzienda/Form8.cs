using FormAzienda;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form8 : Form
    {
        private Db db = new Db(); // Classe Db per la connessione al database
        private int userId; // Memorizza l'ID dell'utente autenticato

        public Form8(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // Carica i dati delle tabelle richieste
            LoadEmployeeData();
            LoadProductData();
            LoadPayrollData();
        }

        // Metodo per caricare i dipendenti
        private void LoadEmployeeData()
        {
            string query = "SELECT nome, cognome, mansione, email FROM utenti WHERE mansione IN ('magazziniere', 'gestore vendite', 'compratore')";

            DataTable dt = db.ExecuteQuery(query);
            dataGridViewDipendenti.DataSource = dt;
        }

        // Metodo per caricare i prodotti dal magazzino
        private void LoadProductData()
        {
            string query = "SELECT nome_prodotto, quantita, prezzo FROM prodotti_magazzino";

            DataTable dt = db.ExecuteQuery(query);
            dataGridViewProdotti.DataSource = dt;
        }

        // Metodo per caricare le buste paga
        private void LoadPayrollData()
        {
            string query = "SELECT b.id, u.nome, u.cognome, u.mansione, b.data_stipendio, b.ore_mensili, b.stipendio " +
                           "FROM buste_paga b " +
                           "JOIN utenti u ON b.id_user = u.id";

            DataTable dt = db.ExecuteQuery(query);
            dataGridViewBustePaga.DataSource = dt;
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

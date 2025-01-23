using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form8 : Form
    {
        private MySqlConnection connection;

        public Form8()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadDipendenti();
            LoadMagazzino();
            LoadBustePaga();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=localhost;Database=dbaziendale;UID=root;Password=;";
            connection = new MySqlConnection(connectionString);
        }

        private void LoadDipendenti()
        {
            try
            {
                connection.Open();
                string query = "SELECT nome, cognome, mansione, email FROM utenti WHERE mansione IS NOT NULL";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvDipendenti.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento dei dipendenti: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadMagazzino()
        {
            try
            {
                connection.Open();
                string query = "SELECT nome_prodotto, quantita_disponibile, prezzo_unitario FROM magazzino";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvMagazzino.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento del magazzino: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadBustePaga()
        {
            try
            {
                connection.Open();
                string query = "SELECT id, nome, cognome, mansione, data_stipendio, ore_mensili, stipendio FROM buste_paga";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvBustePaga.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel caricamento delle buste paga: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}

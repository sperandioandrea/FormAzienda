using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form7 : Form
    {
        private MySqlConnection connection;

        public Form7()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadDipendenti();
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
                string query = "SELECT id, CONCAT(nome, ' ', cognome, ' - ', mansione) AS dipendente FROM utenti WHERE mansione IN ('magazziniere', 'gestore vendite', 'gestore contabilità')";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbDipendenti.DisplayMember = "dipendente";
                cmbDipendenti.ValueMember = "id";
                cmbDipendenti.DataSource = dt;
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

        private void LoadBustePaga()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM buste_paga";
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

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            if (cmbDipendenti.SelectedValue == null || numOreMensili.Value == 0)
            {
                MessageBox.Show("Selezionare un dipendente e inserire le ore mensili.");
                return;
            }

            int dipendenteId = Convert.ToInt32(cmbDipendenti.SelectedValue);
            string mansione = cmbDipendenti.Text.Split('-')[1].Trim();
            int oreMensili = (int)numOreMensili.Value;
            decimal stipendio = CalcolaStipendio(mansione, oreMensili);
            DateTime dataStipendio = dtpDataStipendio.Value;

            try
            {
                connection.Open();
                string query = "INSERT INTO buste_paga (dipendente_id, nome, cognome, mansione, data_stipendio, ore_mensili, stipendio) " +
                               "SELECT id, nome, cognome, mansione, @dataStipendio, @oreMensili, @stipendio " +
                               "FROM utenti WHERE id = @dipendenteId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@dipendenteId", dipendenteId);
                command.Parameters.AddWithValue("@dataStipendio", dataStipendio);
                command.Parameters.AddWithValue("@oreMensili", oreMensili);
                command.Parameters.AddWithValue("@stipendio", stipendio);
                command.ExecuteNonQuery();

                MessageBox.Show("Busta paga aggiunta con successo.");
                LoadBustePaga();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nell'aggiunta della busta paga: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private decimal CalcolaStipendio(string mansione, int oreMensili)
        {
            decimal pagaOraria = 0;

            switch (mansione)
            {
                case "magazziniere":
                    pagaOraria = 10;
                    break;
                case "gestore vendite":
                    pagaOraria = 12;
                    break;
                case "gestore contabilità":
                    pagaOraria = 15;
                    break;
            }

            return pagaOraria * oreMensili;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }
    }
}

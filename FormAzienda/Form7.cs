using FormAzienda;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FormAzienda
{
    public partial class Form7 : Form
    {
        private Db db = new Db();
        private int userId;  // Variabile per memorizzare l'ID dell'utente autenticato

        public Form7(int userId)
        {
            InitializeComponent();
            this.userId = userId;  // Assegno l'ID utente alla variabile
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadDipendenti();
            LoadBustePaga();
        }

        private void LoadDipendenti()
        {
            try
            {
                db.OpenConnection();

                // Recupera tutti i dipendenti con mansioni specifiche (magazziniere, gestore vendite, gestore contabilità)
                string query = @"SELECT id, nome, cognome, mansione 
                                 FROM utenti 
                                 WHERE mansione IN ('magazziniere', 'gestore vendite', 'gestore contabilita')";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Imposta la ComboBox con i dipendenti
                cmbDipendenti.DataSource = dt;
                cmbDipendenti.DisplayMember = "nome";
                cmbDipendenti.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento dei dipendenti: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void LoadBustePaga()
        {
            try
            {
                db.OpenConnection();

                // Carica le buste paga esistenti
                string queryBustePaga = @"SELECT b.id, u.nome, u.cognome, u.mansione, b.data_stipendio, b.ore_mensili, b.stipendio
                                          FROM buste_paga b
                                          JOIN utenti u ON b.id_user = u.id";
                MySqlCommand cmdBustePaga = new MySqlCommand(queryBustePaga, db.Connection);
                MySqlDataAdapter adapterBustePaga = new MySqlDataAdapter(cmdBustePaga);
                DataTable dtBustePaga = new DataTable();
                adapterBustePaga.Fill(dtBustePaga);

                // Imposta la DataGridView per visualizzare le buste paga
                dgvBustePaga.DataSource = dtBustePaga;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il caricamento delle buste paga: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnCalcolaStipendio_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDipendenti.SelectedValue == null || !int.TryParse(txtOreMensili.Text.Trim(), out int oreMensili))
                {
                    MessageBox.Show("Selezionare un dipendente e inserire un numero valido di ore mensili.");
                    return;
                }

                int dipendenteId = Convert.ToInt32(cmbDipendenti.SelectedValue);
                string dataStipendio = dtpDataStipendio.Value.ToString("yyyy-MM-dd");

                db.OpenConnection();

                // Recupera le informazioni sul dipendente selezionato
                string queryDipendente = @"SELECT mansione 
                                           FROM utenti 
                                           WHERE id = @id";
                MySqlCommand cmdDipendente = new MySqlCommand(queryDipendente, db.Connection);
                cmdDipendente.Parameters.AddWithValue("@id", dipendenteId);
                string mansione = cmdDipendente.ExecuteScalar()?.ToString();

                if (string.IsNullOrEmpty(mansione))
                {
                    MessageBox.Show("Dipendente non trovato.");
                    return;
                }

                // Calcola lo stipendio in base alla mansione
                decimal pagaOraria = 0;
                switch (mansione)
                {
                    case "magazziniere":
                        pagaOraria = 10;
                        break;
                    case "gestore vendite":
                        pagaOraria = 12;
                        break;
                    case "gestore contabilita":
                        pagaOraria = 15;
                        break;
                    default:
                        MessageBox.Show("Mansione non riconosciuta.");
                        return;
                }

                decimal stipendio = pagaOraria * oreMensili;

                // Inserisce la busta paga nel database
                string queryBustaPaga = @"INSERT INTO buste_paga (id_user, data_stipendio, ore_mensili, stipendio)
                                          VALUES (@id_user, @data_stipendio, @ore_mensili, @stipendio)";
                MySqlCommand cmdBustaPaga = new MySqlCommand(queryBustaPaga, db.Connection);
                cmdBustaPaga.Parameters.AddWithValue("@id_user", dipendenteId);
                cmdBustaPaga.Parameters.AddWithValue("@data_stipendio", dataStipendio);
                cmdBustaPaga.Parameters.AddWithValue("@ore_mensili", oreMensili);
                cmdBustaPaga.Parameters.AddWithValue("@stipendio", stipendio);
                cmdBustaPaga.ExecuteNonQuery();

                MessageBox.Show("Busta paga inserita correttamente.");
                LoadBustePaga();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante l'inserimento della busta paga: {ex.Message}");
            }
            finally
            {
                db.CloseConnection();
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

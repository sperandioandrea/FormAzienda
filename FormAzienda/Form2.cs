using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form2 : Form
    {
        private Db db = new Db();

        public Form2()
        {
            InitializeComponent();
            cmbMansione.Items.AddRange(new string[] { "dirigente", "gestore vendite", "gestore contabilita", "magazziniere" });
            cmbMansione.Enabled = false; // Disabilita la ComboBox all'inizio
        }

        private void rbtnDipendente_CheckedChanged(object sender, EventArgs e)
        {
            // Abilita la ComboBox solo se è selezionata l'opzione "Dipendente"
            cmbMansione.Enabled = rbtnDipendente.Checked;
        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cognome = txtCognome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string mansione = rbtnDipendente.Checked ? cmbMansione.SelectedItem?.ToString() : "compratore";

            // Controllo dei campi obbligatori
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cognome) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                (rbtnDipendente.Checked && string.IsNullOrEmpty(mansione)))
            {
                MessageBox.Show("Per favore, compila tutti i campi richiesti.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                db.OpenConnection();

                // Verifica se l'username esiste già
                string checkUserQuery = "SELECT COUNT(*) FROM utenti WHERE username = @username";
                MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, db.Connection);
                checkCmd.Parameters.AddWithValue("@username", username);
                int userCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (userCount > 0)
                {
                    MessageBox.Show("Nome utente già esistente. Scegli un altro nome utente.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Inserisci il nuovo utente nel database
                string insertQuery = "INSERT INTO utenti (nome, cognome, email, username, password, mansione) VALUES (@nome, @cognome, @email, @username, @password, @mansione)";
                MySqlCommand cmd = new MySqlCommand(insertQuery, db.Connection);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@cognome", cognome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@mansione", mansione);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Registrazione avvenuta con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Torna al form di login dopo 3 secondi
                Timer timer = new Timer();
                timer.Interval = 3000; // 3 secondi
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    this.Hide();
                    new Form1().Show();
                };
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante la registrazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnTornaLogin_Click(object sender, EventArgs e)
        {
            // Torna al form di login
            this.Hide();
            new Form1().Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Vuoto (può essere rimosso se non utilizzato)
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Vuoto (può essere rimosso se non utilizzato)
        }
    }
}

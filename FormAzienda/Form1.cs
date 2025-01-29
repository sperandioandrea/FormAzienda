using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form1 : Form
    {
        private Db db = new Db();
        public static int userId; // Variabile statica per memorizzare l'ID dell'utente autenticato

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                db.OpenConnection();

                // Query per ottenere le informazioni dell'utente
                string query = "SELECT id, username, password, mansione FROM utenti WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, db.Connection);
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Leggi i dati dal database
                        string dbPassword = reader["password"].ToString();
                        string role = reader["mansione"]?.ToString();
                        userId = Convert.ToInt32(reader["id"]); // Memorizza l'ID dell'utente autenticato

                        // Verifica della password
                        if (password == dbPassword)
                        {
                            // Verifica se l'utente è un compratore o un dipendente
                            if (role == "compratore") // Compratore
                            {
                                this.Hide();
                                new Form5(userId).Show(); // Passa userId a Form5
                            }
                            else // Dipendente
                            {
                                this.Hide();

                                // Apri il form corrispondente alla mansione
                                switch (role)
                                {
                                    case "magazziniere":
                                        new Form3(userId).Show(); // Passa userId a Form3
                                        break;
                                    case "gestore vendite":
                                        new Form4(userId).Show(); // Passa userId a Form4
                                        break;
                                    case "gestore contabilita":
                                        new Form7(userId).Show(); // Passa userId a Form7
                                        break;
                                    case "dirigente":
                                        new Form8(userId).Show(); // Passa userId a Form8
                                        break;
                                    default:
                                        MessageBox.Show("Mansione non riconosciuta!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password errata!", "Errore di Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utente non trovato!", "Errore di Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore durante il login: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            // Apri il form di registrazione
            new Form2().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}

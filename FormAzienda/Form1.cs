using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (MySqlConnection conn = Db.GetConnection())
            {
                if (conn.State == System.Data.ConnectionState.Closed) // Assicurati che la connessione sia chiusa prima di aprirla
                {
                    conn.Open();
                }

                try
                {
                    // Modifica della query per usare il campo 'mansione'
                    string query = "SELECT username, password, mansione FROM utenti WHERE username = @username";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // Leggi i dati della prima riga
                            string dbPassword = reader["password"].ToString();
                            string mansione = reader["mansione"].ToString();

                            // Verifica della password
                            if (dbPassword == password)
                            {
                                // Login riuscito, apri la finestra in base alla mansione
                                switch (mansione)
                                {
                                    case "magazziniere":
                                        new Form3().Show();
                                        break;
                                    case "gestore vendite":
                                        new Form4().Show();
                                        break;
                                    case "compratore":
                                        new Form5().Show();
                                        break;
                                    case "gestore contabilità":
                                        new Form7().Show();
                                        break;
                                    case "dirigente":
                                        new Form8().Show();
                                        break;
                                    default:
                                        MessageBox.Show("Mansione non riconosciuta!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                }
                                this.Hide(); // Nasconde la finestra di login
                            }
                            else
                            {
                                MessageBox.Show("Password errata!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Credenziali errate!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante il login: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Chiudi la connessione nel blocco finally
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnRegistrazione_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FormAzienda
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistrati_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string cognome = txtCognome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string mansione = rbDipendente.Checked ? cmbMansione.SelectedItem?.ToString() : "cliente";

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cognome) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || (rbDipendente.Checked && string.IsNullOrWhiteSpace(mansione)))
            {
                MessageBox.Show("Tutti i campi sono obbligatori!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = Db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO utenti (nome, cognome, email, username, password, mansione) " +
                                   "VALUES (@nome, @cognome, @email, @username, @password, @mansione)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@cognome", cognome);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@mansione", mansione);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registrazione completata con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Form1().Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore durante la registrazione: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void rbDipendente_CheckedChanged(object sender, EventArgs e)
        {
            cmbMansione.Enabled = rbDipendente.Checked;
        }
    }
}

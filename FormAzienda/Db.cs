using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace FormAzienda
{
    public class Db
    {
        private const string ConnectionString = "Server=localhost;Database=dbaziendale;Uid=root;Pwd=;";
        public MySqlConnection Connection { get; private set; }

        public Db()
        {
            Connection = new MySqlConnection(ConnectionString);
        }

        // Metodo per aprire la connessione
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
                Connection.Open();
        }

        // Metodo per chiudere la connessione
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
                Connection.Close();
        }

        // Metodo per eseguire una query SELECT che restituisce un DataTable (con parametri opzionali)
        public DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            DataTable result = new DataTable();
            try
            {
                OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(cmd))
                    {
                        dataAdapter.Fill(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante l'esecuzione della query: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        // Metodo per eseguire una query di tipo INSERT, UPDATE, DELETE (con parametri opzionali)
        public int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            int rowsAffected = 0;
            try
            {
                OpenConnection();
                using (MySqlCommand cmd = new MySqlCommand(query, Connection))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante l'esecuzione della query: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return rowsAffected;
        }

        // Metodo per iniziare una transazione
        public MySqlTransaction BeginTransaction()
        {
            OpenConnection();
            return Connection.BeginTransaction();
        }
    }
}

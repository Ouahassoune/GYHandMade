using System;
using System.Data;
using System.Data.SqlClient;

namespace GYProject.Database
{
    internal class DatabaseManager
    {
        private static DatabaseManager _instance;
        private string _connectionString = "Data Source=DESKTOP-MUD0CQV\\SQLEXPRESS;Initial Catalog=Test2;Integrated Security=True";

        public void  conn()
        {
            // Chaîne de connexion à la base de données
            string _connectionString = "Data Source=DESKTOP-MUD0CQV\\SQLEXPRESS;Initial Catalog=Test2;Integrated Security=True";

            try
            {
                // Création d'une instance de SqlConnection avec la chaîne de connexion
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    // Tentative d'ouverture de la connexion
                    connection.Open();

                    // Vérification si la connexion est ouverte
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Connexion à la base de données réussie !");
                    }
                    else
                    {
                        Console.WriteLine("La connexion à la base de données a échoué.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Affichage de l'erreur s'il y a un problème de connexion
                Console.WriteLine("Erreur lors de la connexion à la base de données : " + ex.Message);
            }
        }
        // Empêche l'instanciation en dehors de cette classe
        public DatabaseManager() { }




        public void ExecuteNonQuery(string query)
        {
            conn();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    // Ajoute une alerte indiquant que la connexion est établie
                    Console.WriteLine("Connexion établie avec succès.");
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Affiche l'erreur de connexion
                Console.WriteLine("Erreur lors de l'établissement de la connexion : " + ex.Message);
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    connection.Open();
                    // Ajoute une alerte indiquant que la connexion est établie
                    Console.WriteLine("Connexion établie avec succès.");
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                // Affiche l'erreur de connexion
                Console.WriteLine("Erreur lors de l'établissement de la connexion : " + ex.Message);
            }
            return dataTable;
        }


        // Méthode pour obtenir l'instance unique de DatabaseManager
        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseManager();
                }
                return _instance;
            }
        }

      

        
    }
}

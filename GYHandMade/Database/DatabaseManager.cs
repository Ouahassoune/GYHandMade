using System;
using System.Data;
using System.Data.SqlClient;

namespace GYProject.Database
{
    internal class DatabaseManager
    {
        private static DatabaseManager _instance;
        private string _connectionString = "Data Source=DESKTOP-DMLR2AM;Initial Catalog=Test2;Integrated Security=True";

        // Empêche l'instanciation en dehors de cette classe
        private DatabaseManager() { }

        // Méthode pour exécuter une requête non query
        public void ExecuteNonQuery(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Success: Query executed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        public void ExecuteNonQuery2(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddRange(parameters); // Ajouter les paramètres à la commande
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Success: Query executed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }


        // Méthode pour exécuter une requête de sélection de données et retourner les résultats sous forme de DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                    Console.WriteLine("Success: Query executed successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
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



        // Méthode pour exécuter une requête de sélection de données et retourner la première colonne de la première ligne du résultat
        public object ExecuteScalar(string query)
    {
        object result = null;
        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                result = command.ExecuteScalar();
                Console.WriteLine("Success: Query executed successfully.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        return result;
    }

}}

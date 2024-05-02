using System;
using System.Data;
using System.Data.SqlClient;

namespace GYProject.Database
{
    internal class DatabaseManager
    {
        private static DatabaseManager _instance;
        private string _connectionString ="Data Source=DESKTOP-DMLR2AM\\SQLEXPRESS;Initial Catalog=Test2;Integrated Security=True";


        // Empêche l'instanciation en dehors de cette classe
        public DatabaseManager() { }




        // Méthode pour exécuter une requête non query
        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        // Méthode pour exécuter une requête de sélection de données et retourner les résultats sous forme de DataTable
        public DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
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

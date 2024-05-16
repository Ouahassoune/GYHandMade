using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GYProject.Database
{
    internal class DatabaseManager
    {
        private static DatabaseManager _instance;
        private string _connectionString = "Data Source=DESKTOP-MUD0CQV\\SQLEXPRESS;Initial Catalog=Test2;Integrated Security=True";

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
        public DataTable ExecuteQuery3(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters if provided
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        // Method to execute a SQL query that returns a single value from the database
        public object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            object result = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters); // Add parameters to the command if provided
                    }
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

        public int ExecuteNonQuery4(string query, params SqlParameter[] parameters)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }
        public object[] ExecuteRow(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        object[] row = new object[reader.FieldCount];
                        reader.GetValues(row);
                        Console.WriteLine("Success: Row fetched successfully.");
                        return row;
                    }
                    else
                    {
                        Console.WriteLine("Error: No rows found.");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

    }
}

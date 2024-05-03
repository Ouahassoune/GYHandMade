using GYProject.Database;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYProject.Classes;
using System.Data.SqlClient;
namespace GYProject.Classes
{
    internal class TransactionDB
    {

        public TransactionDB()
        {
        }







        // Méthode pour insérer une nouvelle transaction dans la base de données
        internal static void  AddTransaction(Transaction transaction, int UserId)
        {    // Construction de la requête SQL d'insertion dans la table transactions
            string query = $"INSERT INTO transactions (Description, Montant, Date, Type, idUser, category) " +
                           $"VALUES ('{transaction.Description}', {transaction.Montant}, " +
                           $"'{transaction.Date.ToString("yyyy-MM-dd HH:mm:ss")}', '{transaction.Type}', {UserId}, '{transaction.category}')";

               // Exécution de la requête à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
            Console.WriteLine("La transaction a été ajoutée avec succès.");

        }




        // Méthode pour supprimer une transaction de la base de données
        internal static void DeleteTransaction(int transactionId)
        {
            try
            {
                // Construction de la requête SQL de suppression
                string query = $"DELETE FROM transactions WHERE ID = {transactionId}";

                // Exécution de la requête à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
                Console.WriteLine("La transaction a été supprimée avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de la transaction : " + ex.Message);
            }
        }

        internal static Transaction GetTransactionById(int transactionId)
        {
            Transaction transaction = null;
            try
            {
                // Construction de la requête SQL pour récupérer la transaction par son ID
                string query = $"SELECT * FROM transactions WHERE ID = {transactionId}";

                // Exécution de la requête à l'aide de la classe DatabaseManager et récupération des résultats
                DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

                // Vérification s'il y a des lignes retournées
                if (dataTable.Rows.Count > 0)
                {
                    // Récupération de la première ligne de résultat
                    DataRow row = dataTable.Rows[0];

                    // Création de l'objet Transaction à partir des données de la ligne
                    transaction = new Transaction(
                        row["Description"].ToString(), // Description
                        Convert.ToDecimal(row["Montant"]), // Montant
                          row["Type"].ToString(), // Type
                       DateTime.Parse(row["Date"].ToString()), // Type
                           row["category"].ToString() // Description
                    );

                    // Utilisation des setters pour remplir les autres champs
                    transaction.ID = Convert.ToInt32(row["ID"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération de la transaction par ID : " + ex.Message);
            }
            return transaction;
        }



        // Méthode pour récupérer toutes les transactions de la base de données et les retourner sous forme de liste
        internal static List<Transaction> GetAllTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();
            try
            {
                // Construction de la requête SQL de sélection
                string query = "SELECT * FROM transactions";

                // Exécution de la requête à l'aide de la classe DatabaseManager et récupération des résultats
                DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

                // Transformation des lignes de données en objets Transaction
                foreach (DataRow row in dataTable.Rows)
                {
                    Transaction transaction = new Transaction(
                  row["Description"].ToString(), // Description
                        Convert.ToDecimal(row["Montant"]), // Montant
                          row["Type"].ToString(), // Type
                       DateTime.Parse(row["Date"].ToString()), // Type
                           row["category"].ToString() // Description
                    );

                    // Utilisation des setters pour remplir les autres champs
                    transaction.ID = Convert.ToInt32(row["ID"]);
                    transaction.Date = Convert.ToDateTime(row["Date"]);

                
                transactions.Add(transaction);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des transactions : " + ex.Message);
            }
            return transactions;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using GYProject.Classes.CompteAll;
using GYProject.Classes.userAll;
using GYProject.Database;




/// <summary>
/// Summary description for userDB
/// </summary>
///
namespace GYProject.Classes.userAll
{
    public class userDB
    {
        public userDB(){}
        //SS


        /******************* operation de user ***********************/

        // Méthode pour verifier si user existe ou pas 
        internal static User Authentifier(string mail, string motDePasse)
        {
            User user = null;
            try
            {
                // Construction de la requête SQL pour rechercher l'utilisateur par nom d'utilisateur et mot de passe
                string query = $"SELECT * FROM users WHERE Email = '{mail}' AND Password = '{motDePasse}'";

                // Exécution de la requête à l'aide de la classe DatabaseManager et récupération des résultats
                DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

                // Vérification s'il y a des lignes retournées
                if (dataTable.Rows.Count > 0)
                {
                    // Création d'un objet User à partir des données de la première ligne
                    DataRow row = dataTable.Rows[0];
                    user = new User();
                    user.id = Convert.ToInt32(row["id"]);
                    user.nom = row["nom"].ToString();
                    user.prenom = row["prenom"].ToString();
                    user.email = row["email"].ToString();
                    user.password = row["password"].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'authentification de l'utilisateur : " + ex.Message);
            }
            return user;
        }


        // Méthode pour insérer un nouvel utilisateur dans la base de données
        internal static void AddtUser(User user)
        {
            try
            {
                // Construction de la requête SQL d'insertion
                string query = $"INSERT INTO users (nom, prenom, email, password) VALUES ('{user.nom}', '{user.prenom}', '{user.email}', '{user.password}')";

                // Exécution de la requête à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
                Console.WriteLine("L'utilisateur a été inséré avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion de l'utilisateur : " + ex.Message);
            }
        }


        //Retourner le user par le id
        internal static User GetUserById(int userId)
        {
            User user = null; // Initialise l'utilisateur à null par défaut

            try
            {
                // Construction de la requête SQL pour récupérer l'utilisateur par ID
                string query = $"SELECT * FROM users WHERE Id = {userId}";

                // Exécution de la requête à l'aide de la classe DatabaseManager et récupération des résultats
                DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

                // Vérification si des données ont été renvoyées
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0]; // Première ligne de résultat
                                                     // Création de l'objet User à partir des données de la ligne
                    user = new User
                    {
                        id = Convert.ToInt32(row["id"]),
                        nom = row["nom"].ToString(),
                        prenom = row["prenom"].ToString(),
                        email = row["email"].ToString(),
                        password = row["password"].ToString()
                    };
                }
                else
                {
                    // L'utilisateur avec cet ID n'a pas été trouvé dans la base de données
                    Console.WriteLine("Aucun utilisateur trouvé avec l'ID spécifié.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération de l'utilisateur : " + ex.Message);
            }

            return user;
        }


        //methode pour la supression de user 
        internal static void DeleteUser(int userId)
        {
            try
            {
                // Construction de la requête SQL de suppression
                string query = $"DELETE FROM users WHERE id = {userId}";

                // Exécution de la requête à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
                Console.WriteLine("L'utilisateur a été supprimé avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de l'utilisateur : " + ex.Message);
            }
        }



        /******************* user et transaction operation ***********************/
        //ajouter transaction a un user
        internal static void AddUserTransaction(int idUser, int idTransaction)
        {
            try
            {
                // Construction de la requête SQL d'insertion dans la table UserTransaction
                string query = $"INSERT INTO transactions (Description, Montant) VALUES ({idUser}, {idTransaction})";

                // Exécution de la requête à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
                Console.WriteLine("L'association utilisateur-transaction a été ajoutée avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout de l'association utilisateur-transaction : " + ex.Message);
            }
        }
       
        //afficher tous les Transactions pour un user
        internal static List<Transaction> ShowAllTransaction(int userId)
        {
            List<Transaction> transactions = new List<Transaction>();
            try
            {
                // Construction de la requête SQL pour récupérer toutes les transactions de l'utilisateur
                string query = $"SELECT t.* FROM transactions t " +
               $"WHERE t.idUser = {userId}";

                // Exécution de la requête à l'aide de la classe DatabaseManager et récupération des résultats
                DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

                // Transformation des lignes de données en objets Transaction
                foreach (DataRow row in dataTable.Rows)
                {
                    Transaction transaction = new Transaction();
                    transaction.ID = Convert.ToInt32(row["ID"]);
                    transaction.Description = row["Description"].ToString();
                    transaction.Montant = Convert.ToDecimal(row["Montant"]);
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




        /******************* user et Compte operation ***********************/
        //ajouter compte a un user
        internal static void AddUserCompte(int iduser, Compte cmp)
        {
            try
            {
                // Construction de la requête SQL d'insertion dans la table UserCompte
                string query = $"INSERT INTO Compte (Nom, Solde, idUser) VALUES ('{cmp.Nom}', {cmp.Solde}, {iduser})";

                // Exécution de la requête à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
                Console.WriteLine("L'association utilisateur-compte a été ajoutée avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout de l'association utilisateur-compte : " + ex.Message);
            }
        }


        //afficher tous les Compte pour un user
        internal static List<Compte> ShowAllComptes(int userId)
        {
            List<Compte> comptes = new List<Compte>();
            try
            {
                // Construction de la requête SQL pour récupérer tous les comptes de l'utilisateur
                string query = $"SELECT * FROM Compte  " +
                               
                               $"WHERE idUser = {userId}";

                // Exécution de la requête à l'aide de la classe DatabaseManager et récupération des résultats
                DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

                // Transformation des lignes de données en objets Compte
                foreach (DataRow row in dataTable.Rows)
                {
                    Compte compte = new Compte();
                    compte.ID = Convert.ToInt32(row["ID"]);
                    compte.Nom = row["Nom"].ToString();
                    compte.Solde = Convert.ToDecimal(row["Solde"]);
                    // Ajoutez d'autres propriétés de compte si nécessaire
                    comptes.Add(compte);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des comptes : " + ex.Message);
            }
            return comptes;
        }

      

        internal static void EffectuerTransaction(Transaction transaction, Compte compte)
        {
            try
            {
                // Vérifier le type de transaction
                if (transaction.Type == "depense")
                {
                    // Mettre à jour le solde pour une dépense
                    string query = $"UPDATE Compte SET Solde = Solde - {transaction.Montant} WHERE ID = {compte.ID}";
                    DatabaseManager.Instance.ExecuteNonQuery(query);
                }
                else if (transaction.Type == "revenu")
                {
                    // Mettre à jour le solde pour un revenu
                    string query = $"UPDATE Compte SET Solde = Solde + {transaction.Montant} WHERE ID = {compte.ID}";
                    DatabaseManager.Instance.ExecuteNonQuery(query);
                }
                else
                {
                    Console.WriteLine("Type de transaction invalide.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'effectuation de la transaction : " + ex.Message);
            }
        }




    }
}


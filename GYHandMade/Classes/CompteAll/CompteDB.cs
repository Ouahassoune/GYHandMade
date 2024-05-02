using GYProject.Classes.userAll;
using GYProject.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYProject.Classes.CompteAll
{
    internal class CompteDB
    {
        public CompteDB() { }


        // trouver compte by id
        internal static Compte GetCompteById(int compteId)
        {
            Compte compte = null;
            try
            {
                // Construction de la requête SQL pour récupérer le compte par ID
                string query = $"SELECT * FROM Compte WHERE ID = {compteId}";

                // Exécution de la requête à l'aide de la classe DatabaseManager et récupération des résultats
                DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

                // Vérification s'il y a des lignes retournées
                if (dataTable.Rows.Count > 0)
                {
                    // Création d'un objet Compte à partir des données de la première ligne
                    DataRow row = dataTable.Rows[0];
                    compte = new Compte();
                    compte.ID = Convert.ToInt32(row["ID"]);
                    compte.Nom = row["Nom"].ToString();
                    compte.Solde = Convert.ToDecimal(row["Solde"]);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la recherche du compte par ID : " + ex.Message);
            }
            return compte;
        }

        // Méthode pour insérer un nouveau compte dans la base de données
        internal static void AddCompte(Compte compte)
        {
            try
            {
                // Construction de la requête SQL d'insertion
                string query = $"INSERT INTO Compte (Nom, Solde) " +
                               $"VALUES ('{compte.Nom}', {compte.Solde})";

                // Exécution de la requête à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
                Console.WriteLine("Le compte a été inséré avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'insertion du compte : " + ex.Message);
            }
        }


        // Méthode pour supprimer un compte de la base de données
        internal static void DeleteCompte(int compteId)
        {
            try
            {
                // Construction de la requête SQL de suppression
                string query = $"DELETE FROM Compte WHERE ID = {compteId}";

                // Exécution de la requête à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
                Console.WriteLine("Le compte a été supprimé avec succès.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression du compte : " + ex.Message);
            }
        }



        // Méthode pour récupérer tous les comptes de la base de données
        internal static List<Compte> GetAllComptes()
        {
            List<Compte> comptes = new List<Compte>();
            try
            {
                // Construction de la requête SQL de sélection
                string query = "SELECT * FROM Compte";

                // Exécution de la requête à l'aide de la classe DatabaseManager et récupération des résultats
                DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

                // Transformation des lignes de données en objets Compte
                foreach (DataRow row in dataTable.Rows)
                {
                    Compte compte = new Compte(
                        row["Nom"].ToString(),
                        Convert.ToDecimal(row["Solde"])
                    );
                    compte.ID = Convert.ToInt32(row["ID"]);
                    comptes.Add(compte);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des comptes : " + ex.Message);
            }
            return comptes;
        }



        // Méthode pour authentifier un utilisateur
    }


}


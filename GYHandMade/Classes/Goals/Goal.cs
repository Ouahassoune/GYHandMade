using GYProject.Classes.CompteAll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using GYProject.Classes.userAll;
using GYProject.Database;
using System.Windows;
using System.Data.SqlClient;
using System.Data;


namespace GYHandMade.Classes.Goals
{
    internal class Goal
    {
        public int Id { get; set; }
        public string category { get; set; }
        public string NomOfGoal { get; set; }
        public decimal Budget { get; set; }
        public DateTime Datee { get; set; }
        public string Statut { get; set; }
        public decimal Montant { get; set; }
       public int idUser { get; set; }
        public Goal(string nomOfGoal, string cat, decimal budget, DateTime datee)
        {
            category=  cat;
            NomOfGoal = nomOfGoal;
            Budget = budget;
            Datee = datee;
            Statut = "en cours";
            Montant = 0;
        }

        public Goal()
        {
        }
        //check
        public static  void AddGoal(Goal goal,int idUser)
        {
            try
            {
                // Construire la requête SQL d'insertion
                string query = $"INSERT INTO goals (nomOfGoal, budget, datee, statut, montant, idUser,category) " +
                               $"VALUES ('{goal.NomOfGoal}', {goal.Budget}, '{goal.Datee.ToString("yyyy-MM-dd")}', " +
                               $"'{goal.Statut}', {goal.Montant}, {idUser},'{goal.category}')";

                // Exécuter la requête SQL
                DatabaseManager.Instance.ExecuteNonQuery(query);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
        }

        /*
         * Récupérer tous les objectifs de l'utilisateur avec l'ID 3016
                    List<Goal> userGoals = Goal.GetAllGoalsByUserId(3016);

                    // Afficher les détails de chaque objectif dans la console
                    foreach (Goal goal in userGoals)
                    {
                        Console.WriteLine($"ID : {goal.Id}");
                        Console.WriteLine($"Nom de l'objectif : {goal.NomOfGoal}");
                        Console.WriteLine($"Budget : {goal.Budget}");
                        Console.WriteLine($"Date : {goal.Datee}");
                        Console.WriteLine($"Statut : {goal.Statut}");
                        Console.WriteLine($"Montant : {goal.Montant}");
                        Console.WriteLine();
                    }
         */
        public static List<Goal> GetAllGoalsByUserId(int userId)
        {
            List<Goal> goals = new List<Goal>();

            // Construction de la requête SQL pour sélectionner tous les objectifs de l'utilisateur spécifié
            string query = $"SELECT * FROM goals WHERE idUser = {userId}";

            // Exécution de la requête SQL et récupération des résultats dans un DataTable
            DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

            // Parcours de chaque ligne dans le DataTable et création d'un objet Goal pour chaque objectif
            foreach (DataRow row in dataTable.Rows)
            {
                Goal goal = new Goal
                {
                    Id = Convert.ToInt32(row["Id"]),
                    NomOfGoal = row["NomOfGoal"].ToString(),
                    Budget = Convert.ToDecimal(row["Budget"]),
                    Datee = Convert.ToDateTime(row["Datee"]),
                    Statut = row["Statut"].ToString(),
                    Montant = Convert.ToDecimal(row["Montant"]),
                };

                goals.Add(goal);
            }

            // Retourner la liste d'objectifs
            return goals;
        }

        public static void AddAmountToGoals(int idGoal, decimal montant, int idUser, string nameOfCompte)
        {
            try
            {
                // Récupérer l'objectif correspondant à l'ID
                Goal goal = GetGoalById(idGoal);

                // Vérifier si le montant + le nouveau montant dépasse le budget
                decimal nouveauMontant = goal.Montant + montant;
                if (nouveauMontant > goal.Budget)
                {
                    // Afficher un message d'avertissement si le montant dépasse le budget
                    decimal restePourObjectif = goal.Budget - goal.Montant;
                    MessageBox.Show($"Vous avez dépassé le budget. Il vous reste {restePourObjectif} pour atteindre votre objectif.");
                }
                else if (nouveauMontant == goal.Budget)
                {
                    // Si le montant atteint le budget, mettre à jour le montant et afficher un message de réussite
                    UpdateGoalMontant(idGoal, nouveauMontant);
                    // Mettre à jour le statut de l'objectif à "done"
                    UpdateGoalStatut(idGoal, "done");
                    MessageBox.Show("Bravo! Vous avez atteint votre objectif.");
                    
                        
                    
                }
                else
                {
                    // Si le montant est inférieur au budget, ajouter le montant à l'objectif et déduire le montant du compte
                    UpdateGoalMontant(idGoal, nouveauMontant);
                    CompteDB.RemoveAmountFromAccount(idUser, nameOfCompte, montant);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error dans : {ex.Message}");
            }
        }

        public static void UpdateGoalStatut(int idGoal, string newStatut)
        {
            try
            {
                // Construction de la requête SQL pour mettre à jour le statut de l'objectif
                string query = $"UPDATE goals SET Statut = '{newStatut}' WHERE Id = {idGoal}";

                // Exécution de la requête SQL à l'aide de la classe DatabaseManager
                DatabaseManager.Instance.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error lors de la mise à jour du statut de l'objectif : {ex.Message}");
            }
        }

        public int GetAccountId(string nameOfCompte, int idUser)
        {
            int accountId = -1; // Valeur par défaut si aucun compte correspondant n'est trouvé

            try
            {
                string query = $"SELECT ID FROM Compte WHERE Nom = '{nameOfCompte}' AND idUser = {idUser}";

                // Exécuter la requête SQL
                DataTable resultTable = DatabaseManager.Instance.ExecuteQuery(query);

                if (resultTable.Rows.Count > 0)
                {
                    DataRow row = resultTable.Rows[0];
                    accountId = (int)row["ID"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return accountId;
        }



        //pas de probleme ici
        public static void UpdateGoalMontant(int idGoal, decimal nouveauMontant)
        {
            try
            {
                // Construire la requête SQL d'update
                string query = $"UPDATE goals SET montant = {nouveauMontant} WHERE id = {idGoal}";

                // Exécuter la requête SQL
                DatabaseManager.Instance.ExecuteNonQuery(query);

                Console.WriteLine("Success: Goal amount updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
      
        
        public static Goal GetGoalById(int id)
        {
            string query = $"SELECT * FROM Goals WHERE Id = {id}";
            DataTable dataTable = DatabaseManager.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                Goal goal = new Goal();
                goal.Id = (int)row["Id"];
                goal.NomOfGoal = (string)row["NomOfGoal"];
                goal.Budget = (decimal)row["Budget"];
                goal.Datee = (DateTime)row["Datee"];
                goal.Statut = (string)row["Statut"];
                goal.Montant = (decimal)row["Montant"];
                goal.idUser = (int)row["idUser"];

                return goal;
            }
            else
            {
                return null; // Ou lever une exception selon vos besoins
            }
        }

    }
}

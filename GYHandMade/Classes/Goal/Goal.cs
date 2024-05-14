using GYProject.Database;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYProject.Classes;
using System.Data.SqlClient;
//using GYHandMade.Database;



namespace GYHandMade
{
    public class Goal
    {
        // Attributes
        private int goalId; // New attribute: GoalId
        private string goalName;
        private string goalCategory;
        private decimal goalBudget;
        private decimal amount;
        private DateTime goalDate;
        private bool goalCompleted;

        // Getters and setters
        public int GoalId
        {
            get { return goalId; }
            set { goalId = value; }
        }

        public string GoalName
        {
            get { return goalName; }
            set { goalName = value; }
        }

        public string GoalCategory
        {
            get { return goalCategory; }
            set { goalCategory = value; }
        }

        public decimal GoalBudget
        {
            get { return goalBudget; }
            set { goalBudget = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public DateTime GoalDate
        {
            get { return goalDate; }
            set { goalDate = value; }
        }

        public bool GoalCompleted
        {
            get { return goalCompleted; }
            set { goalCompleted = value; }
        }

        // Constructor
        public Goal(int goalId, string goalName, string goalCategory, decimal goalBudget, decimal amount, DateTime goalDate, bool goalCompleted)
        {
            this.goalId = goalId;
            this.goalName = goalName;
            this.goalCategory = goalCategory;
            this.goalBudget = goalBudget;
            this.amount = amount;
            this.goalDate = goalDate;
            this.goalCompleted = goalCompleted;
        }
        public Goal(string goalName, string goalCategory, decimal goalBudget, decimal amount, DateTime goalDate, bool goalCompleted)
        {
            // Assume goalId = 0 or default value for new goals
            this.goalName = goalName;
            this.goalCategory = goalCategory;
            this.goalBudget = goalBudget;
            this.amount = amount;
            this.goalDate = goalDate;
            this.goalCompleted = goalCompleted;
        }

        public Goal()
        {
        }

        // Method to add a new goal to the database
        public void AddGoal(Goal goal, int userId)
        {
            try
            {
                // SQL query to insert a new goal into the database
                string query = "INSERT INTO Goal (GoalName, GoalCategory, GoalBudget, Amount, GoalDate, GoalCompleted, UserId) " +
                               "VALUES (@GoalName, @GoalCategory, @GoalBudget, @Amount, @GoalDate, @GoalCompleted, @UserId); SELECT SCOPE_IDENTITY();";

                // Parameters for the SQL query
                SqlParameter[] parameters =
                {
                    new SqlParameter("@GoalName", SqlDbType.VarChar) { Value = goal.GoalName },
                    new SqlParameter("@GoalCategory", SqlDbType.VarChar) { Value = goal.GoalCategory },
                    new SqlParameter("@GoalBudget", SqlDbType.Decimal) { Value = goal.GoalBudget },
                    new SqlParameter("@Amount", SqlDbType.Decimal) { Value = goal.Amount },
                    new SqlParameter("@GoalDate", SqlDbType.DateTime) { Value = goal.GoalDate },
                    new SqlParameter("@GoalCompleted", SqlDbType.Bit) { Value = goal.GoalCompleted },
                    new SqlParameter("@UserId", SqlDbType.Int) { Value = userId }
                };

                // Execute the query using the DatabaseManager class
                object result = DatabaseManager.Instance.ExecuteScalar(query, parameters);

                if (result != null)
                {
                    goal.GoalId = Convert.ToInt32(result);
                    Console.WriteLine("Goal added successfully. GoalId: " + goal.GoalId);
                }
                else
                {
                    Console.WriteLine("Error: Failed to retrieve GoalId.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to update the amount of the goal in the database
        public void UpdateAmountInDatabase()
        {
            try
            {
                // SQL query to update the amount of the goal in the database
                string query = "UPDATE Goal SET Amount = @Amount, GoalCompleted = CASE WHEN @Amount >= GoalBudget THEN 1 ELSE 0 END WHERE GoalId = @GoalId";

                // Parameters for the SQL query
                SqlParameter[] parameters =
                {
            new SqlParameter("@Amount", SqlDbType.Decimal) { Value = this.Amount },
            new SqlParameter("@GoalId", SqlDbType.Int) { Value = this.GoalId }
        };

                // Execute the query using the DatabaseManager class
                DatabaseManager.Instance.ExecuteNonQuery2(query, parameters);
                Console.WriteLine("Goal amount updated successfully in the database. GoalId: " + this.GoalId + " Amount:" + this.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating goal amount in the database: " + ex.Message);
            }
        }

        public void DeleteFromDatabase()
        {
            try
            {
                // SQL query to delete the goal from the database
                string query = "DELETE FROM Goal WHERE GoalId = @GoalId";

                // Parameters for the SQL query
                SqlParameter parameter = new SqlParameter("@GoalId", SqlDbType.Int) { Value = this.GoalId };

                // Execute the query using the DatabaseManager class
                DatabaseManager.Instance.ExecuteNonQuery4(query, parameter);

                // Optionally, perform additional actions after successful deletion
                Console.WriteLine("Goal deleted successfully from the database. GoalId: " + this.GoalId);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during deletion
                Console.WriteLine("Error deleting goal from the database: " + ex.Message);
            }
        }

    }
}

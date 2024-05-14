using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using GYProject.Classes;
using Microsoft.VisualBasic;


namespace GYHandMade.UserControls
{
    // Define a delegate for the event
    public delegate void DeleteButtonClickedEventHandler(object sender, EventArgs e);
    public partial class Done : UserControl
    {
        // Define the event
        public event DeleteButtonClickedEventHandler DeleteButtonClicked;
        private Goal goal;
        //Financial Ufoo= new Financial();
        public Done()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
        public void SetGoalData(Goal goaln)
        {
            this.goal = goaln;
            // Assuming you have labels or other controls to display goal information
            // Example:
            labelGoalName.Text = goaln.GoalName;
            // labelGoalCategory.Text = goal.GoalCategory;
            labelGoalBudget.Text = goaln.GoalBudget.ToString("C"); // Assuming you want to display currency
            //labelAmount.Text = goal.Amount.ToString("C"); // Assuming you want to display currency
            labelGoalDate.Text = goaln.GoalDate.ToShortDateString(); // Display short date format
            //labelGoalCompleted.Text = goal.GoalCompleted ? "Completed" : "Pending"; // Display completion status
            Console.WriteLine(goaln.GoalId);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void AddAmount_Click(object sender, EventArgs e)
        {

        }
        private void UpdateDatabaseWithNewAmount(Goal goal)
        {
            // Implement database update logic here to update the goal with the new amount
            // For example:
            goal.UpdateAmountInDatabase();
        }

        private void BtnAddAmount_Click_Click(object sender, EventArgs e)
        {
            if (goal != null)
            {       // Identify the corresponding goal item
                    // You can access the goal through the 'this.goal' property

                // Prompt the user for the amount to add
                string input = Interaction.InputBox("Enter the amount to add:", "Add Amount", "0");

                // Parse the input string to decimal
                if (decimal.TryParse(input, out decimal amount))
                {
                    // Update the goal's amount
                    goal.Amount += amount;

                    // Calculate the percentage of completion
                    decimal percentage = (goal.Amount / goal.GoalBudget) * 100;

                    // Ensure the percentage does not exceed 100
                    percentage = Math.Min(percentage, 100);

                    // Set the value of the circular progress bar
                    guna2CircleProgressBar1.Value = Convert.ToInt32(percentage);

                    // Update the UI to reflect the changes
                    // For example, update the amount label
                    //labelAmount.Text = goal.Amount.ToString(); // Update the amount label text

                    // Now you can perform database update operations
                    // Call a method to update the database with the new amount
                    UpdateDatabaseWithNewAmount(goal);
                }
                else
                {
                    // Display error message if the input is not a valid decimal
                    MessageBox.Show("Invalid input! Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Goal data is not set. Please set goal data before adding amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
     
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (goal != null)
            {
                
                    DeleteGoal();
                DeleteButtonClicked?.Invoke(this, EventArgs.Empty);

                // Clear the UI controls
                ClearControls();

                    // Optionally, display a message to indicate successful deletion
                    MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           }
            else
            {
                MessageBox.Show("Goal data is not set. Please set goal data before deleting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteGoal()
        {
            try
            {
                // Call a method to delete the goal from the database
                // For example:
                goal.DeleteFromDatabase();

                // Once deleted, you can optionally perform additional actions
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting goal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControls()
        {
            // Clear the UI controls displaying goal information
            labelGoalName.Text = string.Empty;
            labelGoalBudget.Text = string.Empty;
            labelGoalDate.Text = string.Empty;
            guna2CircleProgressBar1.Value = 0;


            // Clear the goal object
            goal = null;
            // Clear existing controls from the form
            //Uf.Controls.Clear();

            // Remove the Done user control from the panel's Controls collection
            //Uf.Controls.Remove(this);

            // Optionally, dispose the Done user control
            //this.Dispose();
        }

    }
}

using Guna.UI2.WinForms.Suite;
using GYProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYHandMade.UserControls
{
    public partial class Pending : UserControl
    {
        public Pending()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }
        public void SetGoalData(Goal goaln)
        {
            // Assuming you have labels or other controls to display goal information
            // Example:
            labelGoalName.Text = goaln.GoalName;
            // labelGoalCategory.Text = goal.GoalCategory;
            labelGoalBudget.Text = goaln.GoalBudget.ToString("C"); // Assuming you want to display currency
            //labelAmount.Text = goal.Amount.ToString("C"); // Assuming you want to display currency
            labelGoalDate.Text = goaln.GoalDate.ToShortDateString(); // Display short date format
            //labelGoalCompleted.Text = goal.GoalCompleted ? "Completed" : "Pending"; // Display completion status
        }

    }
}

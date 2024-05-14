using GYHandMade.UserControls;
using GYProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYProject.Classes.userAll;

namespace GYHandMade
{
    public partial class Financial : UserControl
    {
        //internal User user = new User();
        readonly User userc; 
      
        UserControls.AddGoal UAdd = new UserControls.AddGoal ();

        UserControls.Done Donex = new UserControls.Done();
        public Financial()
        {
            InitializeComponent();

            userc = userDB.GetUserById(9);
            LoadGoalsFromDatabase();

            // Instantiate Donex
            Donex = new UserControls.Done();
            // Subscribe to the DeleteButtonClicked event after Donex is instantiated
            Donex.DeleteButtonClicked += Done_DeleteButtonClicked;
            // Add Donex to panel3
            panel3.Controls.Add(Donex);
            Donex.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
      
        private void LoadGoalsFromDatabase()
        {
            // Assuming you have a method to retrieve goals from the database
            int userId = 9; // Assuming the user ID you want to retrieve goals for is 9

            List<Goal> goals = userDB.AllGoals(userId);  // Assuming this.user represents the current user
            foreach (var goal in goals)
            {
                Console.WriteLine($"Goal Name: {goal.GoalName}");
                Console.WriteLine($"Goal Category: {goal.GoalCategory}");
                Console.WriteLine($"Goal Budget: {goal.GoalBudget}");
                Console.WriteLine($"Amount: {goal.Amount}");
                Console.WriteLine($"Goal Date: {goal.GoalDate}");
                Console.WriteLine($"Goal Completed: {goal.GoalCompleted}");
                Console.WriteLine(); // Add a blank line between each goal
            }
            // Clear existing controls from the panel
            panel3.Controls.Clear();

            // Calculate the initial Y position
            int yPos = panel3.Height;
            int xPos = 0;

            // Create and add a UGoal UserControl for each goal
            foreach (var goal in goals)
            {
                // Determine which control to use based on GoalCompleted property
                UserControl goalControl;
                if (goal.GoalCompleted)
                {
                     goalControl = new Pending();
                }
                else
                {
                    goalControl = new Done();
                }

                // Cast goalControl to the appropriate type (Done or Pending) before calling SetGoalData
                if (goalControl is Done doneControl)
                {
                    doneControl.SetGoalData(goal);
                }
                else if (goalControl is Pending pendingControl)
                {
                    pendingControl.SetGoalData(goal);
                }
                goalControl.Dock = DockStyle.Left; // Align controls vertically
                //goalControl.Margin = new Padding(30);

                // Adjust the Y position for the next control
                // yPos -= goalControl.Height; // Subtract the height of the control from the Y position

                // Set the location of the control
                //goalControl.Location = new Point(0, yPos);
                goalControl.Location = new Point(xPos, 0);
                // Add the control to the panel
                panel3.Controls.Add(goalControl);
                xPos += goalControl.Width;
            }
        }

        private void Financial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(UAdd);
            UAdd.Dock = DockStyle.Fill;

        }

            private void Done_DeleteButtonClicked(object sender, EventArgs e)
            {
            Donex.Visible = false;
        }
        }
}

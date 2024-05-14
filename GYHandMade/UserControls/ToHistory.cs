using GYProject.Classes;
using GYProject.Classes.userAll;
using GYProject.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GYHandMade.UserControls
{
    public partial class ToHistory : UserControl
    {
        internal User user = new User();


        UserControls.UHistory UHistory = new UserControls.UHistory();
        UserControls.Rp URp = new UserControls.Rp();
        public ToHistory()
        {
          
            InitializeComponent();
            panel3.Controls.Add(UHistory);
            UHistory.Dock = DockStyle.Fill;
            LoadHistoryItemsFromDatabase();
        }
        internal void setUser(User use)
        {
            this.user = use;

        }
        private void ToHistory_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadHistoryItemsFromDatabase()
        {
            // Assuming you have a method to retrieve history items from the database
            List<Transaction> historyItems = this.user.AllTransaction();

            // Clear existing controls from the panel
            panel3.Controls.Clear();

            // Calculate the initial Y position
            int yPos = panel3.Height;

            // Create and add a UHistory UserControl for each history item
            foreach (var historyItem in historyItems)
            {
                Console.WriteLine(historyItem.Type);
                UHistory newHistoryControl = new UHistory();
                newHistoryControl.SetHistoryData(historyItem); // Set data for the new control
                newHistoryControl.Dock = DockStyle.Top; // Align controls vertically
                Console.WriteLine($"ID: {historyItem.ID}, type: {historyItem.Type},Description: {historyItem.Description}, Montant: {historyItem.Montant}, Date: {historyItem.Date}");

                // Adjust the Y position for the next control
                yPos += newHistoryControl.Height;

                // Set the location of the control
                newHistoryControl.Location = new Point(0, yPos);

                // Log the position for debugging
                Console.WriteLine($"Control position: ({newHistoryControl.Location.X}, {newHistoryControl.Location.Y})");

                panel3.Controls.Add(newHistoryControl); // Add the new control to the panel
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            // Clear existing controls from panel1
            panel1.Controls.Clear();

            // Hide panel2
            panel2.Visible = false;

            // Create an instance of the Rp UserControl
            Rp rpControl = new Rp();

            // Pass the user data to the Rp UserControl using the SetUser method
            rpControl.SetUser(user);

            // Add the Rp UserControl to panel1
            panel1.Controls.Add(rpControl);

            // Dock the Rp UserControl to fill the panel
            rpControl.Dock = DockStyle.Fill;
        }

    }
}

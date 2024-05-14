using GYProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYHandMade.UserControls
{
    public partial class AddGoal2 : UserControl
    {
        public new ImageLayout BackgroundImageLayout { get; set; } = ImageLayout.Stretch;
        private string selectedCategory = "";
        public AddGoal2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddGoal2_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

            decimal montant = decimal.Parse(GoalBudgett.Text);
            DateTime dateSelectionnee = GoalDatee.Value;
            string GoalName = GoalNamee.Text;





            // Check if a category is selected
            if (!string.IsNullOrEmpty(selectedCategory))
            {

                // Create a new Goal object with the desired data
                Goal newGoal = new Goal(GoalName, selectedCategory, montant, 0, dateSelectionnee, false);


                
                
                new Goal().AddGoal(newGoal, 9); // Change Here Ghizlane UserID
            }
            else
            {
                // Inform the user to select a category
                MessageBox.Show("Please select a category.");
            }






        }
        private void PictureBoxCategory_Click(object sender, EventArgs e)
        {
            // Reset border style for all PictureBoxes
            foreach (Control control in Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.BorderStyle = BorderStyle.None;
                    pictureBox.BackgroundImage = null; // Remove any previous border image
                }
            }

            // Highlight the clicked PictureBox with a circular border image
            PictureBox clickedPictureBox = (PictureBox)sender;
            clickedPictureBox.BorderStyle = BorderStyle.None; // Set to None to allow custom border

            try
            {
                // Load the circular border image from file
                Image borderImage = Image.FromFile("D:/GYHandMade/GYHandMade/category/bb.png");

                // Set the layout mode of the background image
                clickedPictureBox.BackgroundImageLayout = BackgroundImageLayout;

                // Assign the border image to the PictureBox background
                clickedPictureBox.BackgroundImage = borderImage;

                // Output a debug message
                Console.WriteLine("Image loaded successfully.");

                // Get the category name from the PictureBox's Tag property and store it
                selectedCategory = clickedPictureBox.Tag.ToString();
            }
            catch (Exception ex)
            {
                // Output any exception that occurred during image loading
                Console.WriteLine("Error loading image: " + ex.Message);
            }

            // Perform other actions based on category selection
            // For example, you can show category details, etc.
        }
    }
}

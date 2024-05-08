using GYProject.Classes;
using GYProject.Classes.userAll;
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
    public partial class AddIncome : UserControl
    { 
        internal User user = null;
        public new ImageLayout BackgroundImageLayout { get; set; } = ImageLayout.Stretch;
        private string selectedCategory = "";
        public AddIncome()
        {
            InitializeComponent();
            user = userDB.GetUserById(9);
        }
        internal void setUser(User use)
        {
            this.user = use;

        }
        private void AddIncome_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            decimal montant = decimal.Parse(amount.Text);
            DateTime dateSelectionnee = date.Value;
            string description = desc.Text;
            string category = "category";
            Transaction tr = new Transaction(description,montant,"revenu",dateSelectionnee,category);
            user.AjouterTransaction(tr);

        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            decimal montant = decimal.Parse(amount.Text);
            DateTime dateSelectionnee = date.Value;
            string description = desc.Text;
            
            
            

            // Check if a category is selected
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                // Add the transaction using the selected category
                Transaction tr = new Transaction(description, montant, "revenu", dateSelectionnee, selectedCategory);
                user.AjouterTransaction(tr);
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using GYProject.Classes;
using GYProject.Classes.userAll;

namespace GYHandMade.UserControls
{
    public partial class AddExpense : UserControl
    {
        internal User user = null;
        private Color borderColor = Color.Red;

        // New property to specify the layout mode of the background image
        public new ImageLayout BackgroundImageLayout { get; set; } = ImageLayout.Stretch;

        public AddExpense()
        {
            InitializeComponent();
            user = userDB.GetUserById(7);
            // Subscribe to click events of PictureBoxes
            pictureBoxCategory2.Click += PictureBoxCategory_Click;
            pictureBoxCategory2.Click += PictureBoxCategory_Click;
            // Add more PictureBoxes and subscribe to their Click events as needed
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            decimal montant = decimal.Parse(amount.Text);
            DateTime dateSelectionnee = date.Value;
            string description = desc.Text;
            string category = "category";
            Transaction tr = new Transaction(description, montant, "depense", dateSelectionnee, category);
            user.AjouterTransaction(tr);
        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            decimal montant = decimal.Parse(amount.Text);
            DateTime dateSelectionnee = date.Value;
            string description = desc.Text;
            string category = "category";
            Transaction tr = new Transaction(description, montant, "depense", dateSelectionnee, category);
            user.AjouterTransaction(tr);
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddExpense_Load(object sender, EventArgs e)
        {

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

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
        private string selectedCategory = "";

        // New property to specify the layout mode of the background image
        public new ImageLayout BackgroundImageLayout { get; set; } = ImageLayout.Stretch;

        public AddExpense()
        {
            InitializeComponent();
            // Subscribe to click events of PictureBoxes
            pictureBoxCategory2.Click += PictureBoxCategory_Click;
            pictureBoxCategory2.Click += PictureBoxCategory_Click;
            // Add more PictureBoxes and subscribe to their Click events as needed
        }
        internal void setUser(User use)
        {
            this.user = use;

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            // Get other expense details
            decimal montant = decimal.Parse(amount.Text);
            DateTime dateSelectionnee = date.Value;
            string description = desc.Text;

            // Check if a category is selected
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                // Add the transaction using the selected category
                Transaction tr = new Transaction(description, montant, "depense", dateSelectionnee, selectedCategory);
                user.EffectuerTransaction(tr, "Banc");
            }
            else
            {
                // Inform the user to select a category
                MessageBox.Show("Please select a category.");
            }
        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            // Get other expense details
            decimal montant = decimal.Parse(amount.Text);
            DateTime dateSelectionnee = date.Value;
            string description = desc.Text;

            // Check if a category is selected
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                // Add the transaction using the selected category
                Transaction tr = new Transaction(description, montant, "depense", dateSelectionnee, selectedCategory);
                user.EffectuerTransaction(tr,"Banc");

            }
            else
            {
                // Inform the user to select a category
                MessageBox.Show("Please select a category.");
            }
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

                Image borderImage = Image.FromFile("C:\\Users\\Pc\\Desktop\\GI2_S4\\.Net\\8_youss\\GYHandMade\\category\\bb.png");

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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        internal void addUser(User user)
        {
            this.user = user;
        }
    }
}

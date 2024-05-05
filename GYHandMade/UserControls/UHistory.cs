using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms.Suite;
using GYProject.Classes;

namespace GYHandMade.UserControls
{
    public partial class UHistory : UserControl

    {
        public int Id { get; set; }
        public string Typep { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public string category { get; set; }

        // Dictionary to map category names to picture file paths
        private Dictionary<string, string> categoryPicturePaths;


        public UHistory()
        {
            InitializeComponent();
            // Initialize the category-picture mapping
            InitializeCategoryPictureMapping();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UHistory_Load(object sender, EventArgs e)
        {

        }
        public void SetHistoryData( Transaction historyItem)
        {

            // Set properties of the UHistory control based on the provided history item

            Typep = "revenue";
            
            Description = historyItem.Description;
            Date = historyItem.Date;
            Montant = historyItem.Montant;
            //category = historyItem.category;
            category = "Gym";
            

            // Set the text color based on the type
            if (Typep == "revenue")
            {
                labelType.ForeColor = Color.Green;
            }
            else if (Typep == "depense")
            {
                labelType.ForeColor = Color.Red;
            }
            else
            {
                labelType.ForeColor = SystemColors.ControlText; // Default color if type is neither "revenue" nor "depense"
            }
            // Update UI elements to display the data

            labelType.Text = Typep;
            labelD.Text = Description;
            labelM.Text = Montant.ToString();
            // Format the date without the hour part
            labelDate.Text = Date.ToString("yyyy-MM-dd"); // Change the format as needed

            labelC.Text = category;

            // Set picture based on category
            if (categoryPicturePaths.ContainsKey(category))
            {
                string picturePath = categoryPicturePaths[category];
                pictureBox.Image = Image.FromFile(picturePath);
            }
            else
            {
                // If category picture not found, set a default picture or leave blank
                pictureBox.Image = null; // Or set a default image

            }

        }
        private void InitializeCategoryPictureMapping()
        {
            // Define the mapping between category names and picture file paths
            categoryPicturePaths = new Dictionary<string, string>
{
    // Income categories
    { "Salary", "D:/GYHandMade/GYHandMade/cat/14.png" },
    { "Other", "D:/GYHandMade/GYHandMade/cat/Blue Flat Illustrative Finance Company Logo (11).png" },
    { "Interest", "D:/GYHandMade/GYHandMade/cat/13.png" },
    { "Investment", "D:/GYHandMade/GYHandMade/cat/16.png" },
    { "Gift", "D:/GYHandMade/GYHandMade/category/Gift.png" },
    
    // Expense categories
    { "Rent", "D:/GYHandMade/GYHandMade/cat/1.png" },
    { "Gym", "D:/GYHandMade/GYHandMade/cat/12.png" },
    { "Groceries", "D:/GYHandMade/GYHandMade/cat/6.png" },
    { "Transportation", "D:/GYHandMade/GYHandMade/cat/5.png" },
    { "Entertainment", "D:/GYHandMade/GYHandMade/category/Entertainment.png"},
    
    // Common categories for both income and expenses
    { "Healthcare", "D:/GYHandMade/GYHandMade/cat/9.png" },
    { "Education", "path/to/education_picture.jpg" },
    { "Savings", "D:/GYHandMade/GYHandMade/cat/15.png" },
    { "Debt Repayment", "path/to/debt_repayment_picture.jpg" },
    { "Insurance", "D:/GYHandMade/GYHandMade/cat/10.png" },
    { "Taxes", "D:/GYHandMade/GYHandMade/cat/11.png" },
    
    // Add more common categories and their corresponding picture paths as needed
};
        }
    }
}

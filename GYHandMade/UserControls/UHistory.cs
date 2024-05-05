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

            //Typep = historyItem.Type;
            Typep = historyItem.Type;
            Description = historyItem.Description;
            Date = historyItem.Date;
            Montant = historyItem.Montant;
            //category = historyItem.category;
            category = "Gift";

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
               // pictureBox.Image = Image.FromFile(picturePath);
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
    { "Salary", "path/to/salary_picture.jpg" },
    { "Bonus", "path/to/bonus_picture.jpg" },
    { "Interest", "path/to/interest_picture.jpg" },
    { "Investment", "path/to/investment_picture.jpg" },
    { "Gift", "D:/GYHandMade/GYHandMade/category/Gift.png" },
    
    // Expense categories
    { "Rent", "D:/GYHandMade/GYHandMade/category/Rent.png" },
    { "Utilities", "path/to/utilities_picture.jpg" },
    { "Groceries", "path/to/groceries_picture.jpg" },
    { "Transportation", "path/to/transportation_picture.jpg" },
    { "Entertainment", "D:/GYHandMade/GYHandMade/category/Entertainment.png"},
    
    // Common categories for both income and expenses
    { "Healthcare", "path/to/healthcare_picture.jpg" },
    { "Education", "path/to/education_picture.jpg" },
    { "Savings", "path/to/savings_picture.jpg" },
    { "Debt Repayment", "path/to/debt_repayment_picture.jpg" },
    { "Insurance", "path/to/insurance_picture.jpg" },
    { "Taxes", "path/to/taxes_picture.jpg" },
    
    // Add more common categories and their corresponding picture paths as needed
};
        }
    }
}

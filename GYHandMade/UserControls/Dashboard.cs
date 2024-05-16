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
using GYProject.Classes;
using Bunifu.Charts.WinForms.ChartTypes;

namespace GYHandMade.UserControls
{
    public partial class Dashboard : UserControl
    {
        //private Form fullScreenForm;
        internal User user=null;

        internal Dashboard(User user)
        {
           
            InitializeComponent();

            this.user = user;
            remplir();
            GetCategoryPercentagesFromDatabase();
            List<double> categoryPercentages = GetCategoryPercentagesFromDatabase();
            Console.WriteLine(categoryPercentages);

            // Set the data for the BunifuBarChart
            bunifuDoughnutChart1.Data = categoryPercentages;
        }

        internal void  remplir()
        {
            
            expenses.Text = "$ " + user.TotalExpenses().ToString();
            incomes.Text = "$ " + user.getTotalIncomes().ToString();
            transactions.Text = user.GetAccountBalance().ToString();
        }
        internal Dashboard()
        {
            

        }
        internal void setUser(User use)
        {
            this.user = use;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuChartCanvas2_Load(object sender, EventArgs e)
        {
        }

        private void bunifuChartCanvas1_Load(object sender, EventArgs e)
        {
            // Retrieve category percentages from the database
          
        }

        // Liste des catégories dans l'ordre spécifié
        private List<string> CategoriesList = new List<string>()
{
    "Rent",
    "Shopping",
    "Transportation",
    "Entertainment",
    "Insurance",
    "Taxes",
    "Gym",
    "Groceries",
    "Healthcare",
    "Other"
};
        // Méthode pour récupérer les pourcentages de chaque catégorie depuis la base de données
        public List<double> GetCategoryPercentagesFromDatabase()
        {
            List<double> categoryPercentages = new List<double>();

            try
            {
                List<Transaction> transactions = user.AllTransaction();
                Console.WriteLine("Nombre total de transactions récupérées : " + transactions.Count);

                // Vérifiez si la liste des transactions est null
                if (transactions != null)
                {
                    Dictionary<string, int> categoryCounts = new Dictionary<string, int>();

                    // Initialisez les comptages à zéro pour chaque catégorie
                    foreach (string category in CategoriesList)
                    {
                        categoryCounts[category] = 0;
                    }

                    // Comptez le nombre d'occurrences de chaque catégorie
                    foreach (Transaction transaction in transactions)
                    {
                        // Vérifiez si la catégorie de la transaction est null
                        if (transaction.category!= null )
                        {
                            Console.WriteLine("Catégorie de la transaction : " + transaction.category);

                            if (categoryCounts.ContainsKey(transaction.category))
                            {
                                categoryCounts[transaction.category]++;
                            }
                            else
                            {
                                categoryCounts["Other"]++;
                            }
                       }
                       else
                        {
                            Console.WriteLine("La catégorie de la transaction est null.");
                            categoryCounts["Other"]++;
                            // Vous pouvez choisir de traiter cela d'une manière appropriée à votre application.
                            // Par exemple, vous pouvez ignorer cette transaction ou la compter dans une catégorie spécifique.
                       }
                    }

                    // Calculez le total des transactions
                    int totalTransactions = transactions.Count;
                    Console.WriteLine("Nombre total de transactions : " + totalTransactions);

                    // Calculez le pourcentage pour chaque catégorie
                    foreach (string category in CategoriesList)
                    {
                        double percentage = (double)categoryCounts[category] / totalTransactions * 100.0;
                        categoryPercentages.Add(percentage);
                        Console.WriteLine("Pourcentage de la catégorie " + category + " : " + percentage);
                    }
                }
                else
                {
                    Console.WriteLine("La liste des transactions est null.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des pourcentages de catégorie depuis la base de données : " + ex.Message);
            }

            return categoryPercentages;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuChartCanvas1_Load_1(object sender, EventArgs e)
        {
            List<double> categoryPercentages = GetCategoryPercentagesFromDatabase();
            Console.WriteLine(categoryPercentages);
            bunifuChartCanvas1.Labels = CategoriesList.ToArray();
            // Set the data for the BunifuBarChart
            bunifuDoughnutChart1.Data = categoryPercentages;
        }
    }
}

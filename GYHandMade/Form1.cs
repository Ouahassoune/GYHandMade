using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYHandMade.UserControls;
using GYProject.Classes;
using GYProject.Classes.userAll;

namespace GYHandMade
{
    public partial class Form1 : Form

    {  

        UserControls.AddTransaction UAddTransaction = new UserControls.AddTransaction();
        internal  UserControls.Dashboard Udashboard = new UserControls.Dashboard();
        internal UserControls.ToHistory UHistory = new UserControls.ToHistory();
        public UserControls.AddCompte UCompte = new UserControls.AddCompte();
        internal User user = new User();

        internal Form1(User use,Dashboard uds, ToHistory UHistory, AddCompte ompte, AddTransaction UAddTransaction)
        {
            InitializeComponent();

            // Définir l'utilisateur avant de créer le Dashboard UserControl
            this.user = use;
            this.Udashboard = uds;
            this.UAddTransaction = UAddTransaction;
            this.UCompte = ompte;
            
            this.UAddTransaction = UAddTransaction;
            this.UHistory = UHistory;
            // Créer une instance de Dashboard UserControl

            // Passer l'utilisateur au Dashboard UserControl

            // Ajouter le Dashboard UserControl au formulaire principal
            MainPanel.Controls.Add(Udashboard);
            Udashboard.Dock = DockStyle.Fill;

            label2.Text = "Hello, " + user.nom + "!";
            lastTransaction();

        }
        internal void  setUdashboard(UserControls.Dashboard udashboard)
        {
            this.Udashboard = udashboard;

        }
        internal void setUser(User use)
        {
            this.user = use;

        }

        //remplir la liste des 3 transactions les plus recentes
        public void lastTransaction()
        {
            // Récupérer les trois dernières transactions de l'utilisateur
            List<Transaction> liste = user.GetLastThreeTransactions();

            // Vérifier si la liste contient au moins une transaction
            if (liste.Count > 0)
            {
                // Remplir le premier label avec les données de la première transaction
                amount1.Text = liste[0].Montant.ToString();
                cat1.Text = liste[0].category;
                date1.Text = liste[0].Date.ToString();
            }

            // Vérifier si la liste contient au moins deux transactions
            if (liste.Count > 1)
            {
                // Remplir le deuxième label avec les données de la deuxième transaction
                amount2.Text = liste[1].Montant.ToString();
                cat2.Text = liste[1].category;
                date2.Text = liste[1].Date.ToString();
            }

            // Vérifier si la liste contient au moins trois transactions
            if (liste.Count > 2)
            {
                // Remplir le troisième label avec les données de la troisième transaction
                amount3.Text = liste[2].Montant.ToString();
                cat3.Text = liste[2].category;
                date3.Text = liste[2].Date.ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            MainPanel.Controls.Clear();

            // Add the dashboard user control to the form
            MainPanel.Controls.Add(Udashboard);
            Udashboard.setUser(user);
            Udashboard.remplir();
            Udashboard.Dock = DockStyle.Fill;


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            MainPanel.Controls.Clear();

            // Add the dashboard user control to the form
            MainPanel.Controls.Add(UAddTransaction);
            UAddTransaction.Dock = DockStyle.Fill;
            UAddTransaction.setUser(user);
            UAddTransaction.setUser(user);
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            MainPanel.Controls.Clear();

            // Add the dashboard user control to the form
            MainPanel.Controls.Add(UHistory);
            UHistory.Dock = DockStyle.Fill;
            UHistory.setUser(user);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            MainPanel.Controls.Clear();
            UCompte.setUser(user);
            // Add the dashboard user control to the form
            MainPanel.Controls.Add(UCompte);
            UCompte.Dock = DockStyle.Fill;
           
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

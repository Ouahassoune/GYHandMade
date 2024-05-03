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

namespace GYHandMade
{
    public partial class Form1 : Form

    {
        UserControls.Dashboard Udashboard = new UserControls.Dashboard();
        UserControls.AddTransaction UAddTransaction = new UserControls.AddTransaction();
   
        UserControls.ToHistory UHistory = new UserControls.ToHistory();
        UserControls.AddCompte UCompte = new UserControls.AddCompte();
        public Form1()
        {
            InitializeComponent();
            MainPanel.Controls.Add(Udashboard);
            Udashboard.Dock = DockStyle.Fill;
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
            Udashboard.Dock = DockStyle.Fill;

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            MainPanel.Controls.Clear();

            // Add the dashboard user control to the form
            MainPanel.Controls.Add(UAddTransaction);
            UAddTransaction.Dock = DockStyle.Fill;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            MainPanel.Controls.Clear();

            // Add the dashboard user control to the form
            MainPanel.Controls.Add(UHistory);
            UHistory.Dock = DockStyle.Fill;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            MainPanel.Controls.Clear();

            // Add the dashboard user control to the form
            MainPanel.Controls.Add(UCompte);
            UCompte.Dock = DockStyle.Fill;
        }
    }
}

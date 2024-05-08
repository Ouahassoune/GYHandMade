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
    public partial class AddTransaction : UserControl
    {
        internal User user = null;
        UserControls.AddIncome UAddIncome = new UserControls.AddIncome();
        UserControls.AddExpense UAddExpense = new UserControls.AddExpense();
        public AddTransaction()
        {
            InitializeComponent();
            UAddIncome.setUser(user);
            panel2.Controls.Add(UAddIncome);
            UAddIncome.Dock = DockStyle.Fill;

        }
        internal void setUser(User use)
        {
            this.user = use;

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            panel2.Controls.Clear();

            // Add the dashboard user control to the form
            panel2.Controls.Add(UAddIncome);
            UAddIncome.Dock = DockStyle.Fill;
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            // Clear existing controls from the form
            panel2.Controls.Clear();
            UAddExpense.addUser(user);
            // Add the dashboard user control to the form
            panel2.Controls.Add(UAddExpense);
            UAddExpense.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {

        }

        private void AddTransaction_Load_1(object sender, EventArgs e)
        {

        }
    }
}

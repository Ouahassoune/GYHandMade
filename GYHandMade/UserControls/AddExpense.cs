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
    public partial class AddExpense : UserControl
    {
       internal User user = null;
        public AddExpense()
        {
            InitializeComponent();
            user = userDB.GetUserById(7);

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
    }
}

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
    { internal User user = null;
        public AddIncome()
        {
            InitializeComponent();
            user = userDB.GetUserById(9);
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
            string category = "category";
            Transaction tr = new Transaction(description, montant, "revenu", dateSelectionnee, category);
            user.AjouterTransaction(tr);
            desc.Text = "";
            date.Text = "";
            amount.Text = "";
            Form1 f = new Form1();
            f.FuturTransaction();
        }
    }
}

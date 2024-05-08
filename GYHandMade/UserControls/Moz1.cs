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
    public partial class Moz1 : UserControl
    {
        internal AddCompte cmp = null;

        internal User user = null;
        internal String nameOfCompte = "Espece";
        public Moz1()
        {
            InitializeComponent();
        }
        internal void setUser(User use)
        {
            this.user = use;

        }
        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }
        internal void envoyer(User user, AddCompte addCompte)
        {
            this.user = user;
            this.cmp = addCompte;

        }

        private void Moz1_Load(object sender, EventArgs e)
        {

        }
      

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

            String str = inputTextBox.Text;
            decimal amount = decimal.Parse(inputTextBox.Text);
            user.RemoveFromCompte(nameOfCompte, amount);
            inputTextBox.Text = "";
            cmp.remplirLabels();

        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

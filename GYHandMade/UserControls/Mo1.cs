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
    public partial class Mo1 : UserControl
    {
        internal User user = null;
        internal String nameOfCompte = "Espece";
        internal AddCompte cmp = null;

        public Mo1()
        {
            InitializeComponent();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }
        internal void envoyer(User user)
        {
            this.user = user;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        internal void envoyer(User user, AddCompte addCompte)
        {
            this.user = user;
            this.cmp = addCompte;

        }

       

        private void Mo1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {
            String str = inputTextBox.Text;
            decimal amount = decimal.Parse(inputTextBox.Text);
            user.AddToCompte(nameOfCompte, amount);
            inputTextBox.Text = "";
            cmp.remplirLabels();
        }
    }
}

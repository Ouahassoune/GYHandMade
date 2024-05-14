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
using static System.Net.Mime.MediaTypeNames;

namespace GYHandMade.UserControls
{
    public partial class Mo : UserControl
    {
        internal User user = null;
        internal String nameOfCompte = "Banc";
        internal AddCompte cmp = null;

        public Mo()
        {
            InitializeComponent();
        }
        internal void envoyer(User user, AddCompte addCompte)
        {
            this.user = user;
            this.cmp = addCompte;
        }
        internal void setUser(User use)
        {
            this.user = use;

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();

        }

        private void Mo_Load(object sender, EventArgs e)
        {

        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

            String str = inputTextBox.Text;
            decimal amount = decimal.Parse(inputTextBox.Text);
            user.AddToCompte(nameOfCompte, amount);
            inputTextBox.Text = "";

            cmp.remplirLabels();

        }



      


            private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
            {
                String str = inputTextBox.Text;
                decimal amount = decimal.Parse(inputTextBox.Text);
                user.AddToCompte(nameOfCompte, amount);
                inputTextBox.Text = "";
                cmp.remplirLabels();


            }

        private void guna2GradientTileButton1_Click_1(object sender, EventArgs e)
        {

            String str = inputTextBox.Text;
            decimal amount = decimal.Parse(inputTextBox.Text);
            user.AddToCompte(nameOfCompte, amount);
            inputTextBox.Text = "";
            cmp.remplirLabels();


        }
    } }

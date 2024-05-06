﻿using GYProject.Classes.userAll;
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
    public partial class Transfer1 : UserControl
    {
        internal User user = null;
        internal String nameOfCompte = "Espece";
        internal AddCompte cmp = null;
        public Transfer1()
        {
            InitializeComponent();
        }
        internal void envoyer(User user, AddCompte addCompte)
        {
            this.user = user;
            this.cmp = addCompte;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }

        private void Transfer1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(inputTextBox.Text);
            user.TransferAmount("Espece", "Banc", amount);
            inputTextBox.Text = "";
            cmp.remplirLabels();
        }
    }
}

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
    public partial class Dashboard : UserControl
    {
        private Form fullScreenForm;
        internal User user=null;

        public Dashboard()
        {
           
            InitializeComponent();
         //   InitializeFullScreenForm();
            user = userDB.GetUserById(9);
            expenses.Text ="$ "+ user.TotalExpenses().ToString();
            incomes.Text= "$ " + user.getTotalIncomes().ToString();
            transactions.Text=user.GetAccountBalance().ToString();
            Console.WriteLine("Dashboard constructor executed.");
        }

        private void InitializeFullScreenForm()
        {
            // Set form properties for full screen mode
            this.Dock = DockStyle.Fill;

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.FormBorderStyle = FormBorderStyle.None;
                parentForm.WindowState = FormWindowState.Maximized;
            }
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
    }
}

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
    {   internal User user=null;

        public Dashboard()
        {
            InitializeComponent();
            user = userDB.GetUserById(9);
            expenses.Text ="$ "+ user.TotalExpenses().ToString();
            incomes.Text= "$ " + user.getTotalIncomes().ToString();
            transactions.Text=user.GetTotalTransactionsCount().ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}

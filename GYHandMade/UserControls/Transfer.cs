﻿using System;
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
    public partial class Transfer : UserControl
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Parent.Hide();
        }
    }
}
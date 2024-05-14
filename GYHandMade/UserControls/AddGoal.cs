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
    public partial class AddGoal : UserControl
    {
        UserControls.AddGoal2 UAddG = new UserControls.AddGoal2();
        public AddGoal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(UAddG);
            UAddG.Dock = DockStyle.Fill;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GYHandMade.UserControls
{
    public partial class AddCompte : UserControl
    {
        UserControls.Mo Umo = new UserControls.Mo();
        UserControls.Moz Umon = new UserControls.Moz();
        UserControls.Transfer Ut = new UserControls.Transfer();

        UserControls.Mo1 Umo1 = new UserControls.Mo1();
        UserControls.Moz1 Umon1 = new UserControls.Moz1();
        UserControls.Transfer1 Ut1 = new UserControls.Transfer1();

        //PictureBox pictureBoxOverlay = new PictureBox(); // PictureBox for the semi-transparent overlay

        public AddCompte()
        {
            InitializeComponent();
            panel4.Visible = false; // Initially hide panel4
            //panel5.Visible = false; // Initially hide panel5

            
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void addButton_Click(object sender, EventArgs e)
        {
         /*   // Create a semi-transparent image for the overlay
            Bitmap semiTransparentImage = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(semiTransparentImage))
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(10, Color.Black))) // 128 for 50% transparency
                {
                    g.FillRectangle(brush, 0, 0, semiTransparentImage.Width, semiTransparentImage.Height);
                }
            }*/

            // Set the semi-transparent image as the PictureBox's image
            //pictureBox1.Image = semiTransparentImage;

            // Show the overlay PictureBox and bring it to front
            //pictureBox1.Visible = true;
            //pictureBoxOverlay.BringToFront();

            // Show panel4 (the modal user control) and bring it to front
            panel4.Visible = true;
            panel4.BringToFront();

            // Clear existing controls from panel4
            panel4.Controls.Clear();

            // Add the dashboard user control to panel4
            panel4.Controls.Add(Umo);
            Umo.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();

            // Clear existing controls from panel4
            panel4.Controls.Clear();

            // Add the dashboard user control to panel4
            panel4.Controls.Add(Umon);
            Umon.Dock = DockStyle.Fill;
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();

            // Clear existing controls from panel4
            panel4.Controls.Clear();

            // Add the dashboard user control to panel4
            panel4.Controls.Add(Ut);
            Ut.Dock = DockStyle.Fill;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();

            // Clear existing controls from panel4
            panel4.Controls.Clear();

            // Add the dashboard user control to panel4
            panel4.Controls.Add(Ut1);
            Ut1.Dock = DockStyle.Fill;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();

            // Clear existing controls from panel4
            panel4.Controls.Clear();

            // Add the dashboard user control to panel4
            panel4.Controls.Add(Umo1);
            Umo1.Dock = DockStyle.Fill;
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel4.BringToFront();

            // Clear existing controls from panel4
            panel4.Controls.Clear();

            // Add the dashboard user control to panel4
            panel4.Controls.Add(Umon1);
            Umon1.Dock = DockStyle.Fill;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace GYHandMade.UserControls
{
    public partial class AddCompte : UserControl
    {
        UserControls.Mo Umo = new UserControls.Mo();
        UserControls.Moz Umon = new UserControls.Moz();

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
    }
}

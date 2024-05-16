using Guna.UI2.WinForms.Suite;
using GYProject.Classes.userAll;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms; // Importation des contrôles Windows Forms uniquement

namespace GYHandMade
{
    public partial class Logup : UserControl
    {
        public Logup()
        {
            InitializeComponent();
          //  SetRoundedCorners(panel2, 20, 100, 20, 100);
            ////SetRoundedCorners(panel1, 20, 20, 20, 20);
           // panel2.BackColor = Color.FromArgb(100, Color.White); // 100 est l'opacité (transparence)

        }

        public Logup GetUserControl()
        {
            Logup userControl = new Logup();
            return userControl;
            
        }
        private void SetRoundedCorners(System.Windows.Forms.Panel panel, int topLeft, int topRight, int bottomLeft, int bottomRight)
        {
            GraphicsPath path = new GraphicsPath();

            path.StartFigure();
            path.AddArc(0, 0, 2 * topLeft, 2 * topLeft, 180, 90); // Coin supérieur gauche
            path.AddLine(topLeft, 0, panel.Width - topRight, 0); // Bord supérieur
            path.AddArc(panel.Width - 2 * topRight, 0, 2 * topRight, 2 * topRight, 270, 90); // Coin supérieur droit
            path.AddLine(panel.Width, topRight, panel.Width, panel.Height - bottomRight); // Bord droit
            path.AddArc(panel.Width - 2 * bottomRight, panel.Height - 2 * bottomRight, 2 * bottomRight, 2 * bottomRight, 0, 90); // Coin inférieur droit
            path.AddLine(panel.Width - bottomRight, panel.Height, bottomLeft, panel.Height); // Bord inférieur
            path.AddArc(0, panel.Height - 2 * bottomLeft, 2 * bottomLeft, 2 * bottomLeft, 90, 90); // Coin inférieur gauche
            path.CloseFigure();

            panel.Region = new Region(path);



        }
        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            String nom = first.Text;
            String prenom = second.Text;
            String mail = email.Text;
            String password = pw.Text;

            // Vérifier si une image est chargée dans le pictureBox3
            if (pictureBox3.Image != null)
            {
                // Récupérer l'image depuis le pictureBox3
                Image photo = pictureBox3.Image;

                // Créer un objet User avec les informations fournies
                User user = new User(nom, prenom, mail, password, ConvertImageToBytes(photo));
                user.AddUser();
                // Utiliser l'objet User selon les besoins
                // Par exemple, vous pouvez appeler une méthode pour enregistrer l'utilisateur dans une base de données, etc.
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une photo.", "Photo manquante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public byte[] ConvertImageToBytes(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Sauvegarder l'image dans un flux mémoire
                image.Save(ms, image.RawFormat);

                // Retourner le tableau de bytes de l'image
                return ms.ToArray();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Code de dessin du panel, si nécessaire
        }

        private void guna2GradientTileButton2_Click(object sender, EventArgs e)
        {
            // Masquer le formulaire Logup
            this.Hide();

            // Afficher le formulaire Form1
            Login form1 = new Login();
            form1.Show();
        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {
           
                // Créer une instance de la boîte de dialogue OpenFileDialog
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Définir les filtres de fichier pour afficher uniquement les images
                openFileDialog.Filter = "Fichiers image (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif|Tous les fichiers (*.*)|*.*";

                // Afficher la boîte de dialogue et attendre que l'utilisateur choisisse un fichier
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                    // Charger l'image sélectionnée dans le PictureBox
                    pictureBox3.Image = new Bitmap(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        // Gérer toute exception survenue lors du chargement de l'image
                        MessageBox.Show("Une erreur s'est produite lors du chargement de l'image : " + ex.Message);
                    }
                }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        { // Créer une instance de la boîte de dialogue OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Définir les filtres de fichier pour afficher uniquement les images
            openFileDialog.Filter = "Fichiers image (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif|Tous les fichiers (*.*)|*.*";

            // Afficher la boîte de dialogue et attendre que l'utilisateur choisisse un fichier
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Charger l'image sélectionnée dans le PictureBox
                    pictureBox3.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    // Gérer toute exception survenue lors du chargement de l'image
                    MessageBox.Show("Une erreur s'est produite lors du chargement de l'image : " + ex.Message);
                }
            }

        }
    }
}

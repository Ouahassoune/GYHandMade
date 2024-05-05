using GYProject.Classes.userAll;
using GYProject.Database;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;
using System.IO;

namespace GYHandMade
{
    public partial class testForm : Form
    {
        public testForm()
        {
            InitializeComponent();
            DisplayImages();
        }
        public void DisplayImages()
        {
            // Récupérer les images depuis la base de données
            (byte[] photoBytes, byte[] imagBytes) = userDB.SelectImages();

            // Vérifier si les données d'image sont disponibles
            if (photoBytes != null && imagBytes != null)
            {
                // Convertir les données binaires en images
                using (MemoryStream msPhoto = new MemoryStream(photoBytes))
                {
                    using (MemoryStream msImag = new MemoryStream(imagBytes))
                    {
                        Image photoImage = Image.FromStream(msPhoto);
                        Image imagImage = Image.FromStream(msImag);

                        // Afficher les images dans les PictureBox
                        pic1.Image = photoImage;
                        pic2.Image = imagImage;

                        Console.WriteLine("Les images ont été affichées avec succès.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Aucune image disponible dans la base de données.");
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

        // Méthode pour insérer un utilisateur dans la table "Users"
        private void btn_Click(object sender, EventArgs e)
        {
            // Sélectionner une image depuis l'ordinateur
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // Lire l'image en tant qu'array de bytes
                byte[] imageBytes = File.ReadAllBytes(opf.FileName);
                byte[] byteImg = ConvertImageToBytes(img.Image);

                // Appeler la méthode pour insérer l'utilisateur avec l'image dans la base de données
                userDB.InsertUserWithImage("nom", "prenom", byteImg, imageBytes);

                // Appeler la méthode pour insérer l'utilisateur dans la table "Users"
            }
        }

        private void testForm_Load(object sender, EventArgs e)
        {

        }
    }
}

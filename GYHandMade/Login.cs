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

namespace GYHandMade
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            string email = inputTextBox.Text;
            string password = guna2TextBox1.Text;
          

                // Appeler la méthode d'authentification de la classe userDB
                User user = userDB.Authentifier(email, password);

                // Vérifier si l'utilisateur a été authentifié avec succès
                if (user != null)
                {
                Form1 form1 = new Form1(user);

                // Afficher la nouvelle fenêtre
                form1.Show();

                // Masquer la fenêtre actuelle si nécessaire
                this.Hide();
            }
                else
                {
                    // L'utilisateur n'existe pas ou les informations d'identification sont incorrectes
                    // Afficher un message d'erreur ou prendre d'autres mesures appropriées
                    MessageBox.Show("Échec de l'authentification. Vérifiez vos informations d'identification.");
                }
            }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    
}

using GYHandMade.Properties;
using GYHandMade.UserControls;
using GYProject.Classes.CompteAll;
using GYProject.Classes.userAll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            panel1.BackColor = Color.Transparent; // Définir la couleur de fond du Panel comme transparent
            this.FormBorderStyle = FormBorderStyle.None;
            panel3.BackColor = Color.FromArgb(160, 137, 245);
            panel3.SendToBack();

            // pour que les autre composant de panel n'herite pas de panel1
            panel1.Paint += (sender, e) =>
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, Color.Black))) // 100 est l'opacité (transparence)
                {
                    e.Graphics.FillRectangle(brush, panel1.ClientRectangle); // Dessiner le fond semi-transparent
                }
            };
            //Définir les coins arrondis pour le Panel
            SetRoundedCorners(panel2, 20, 100, 20, 100);
            SetRoundedCorners(panel1, 20, 20, 20, 20);
            panel2.BackColor = Color.FromArgb(100, Color.Black); // 100 est l'opacité (transparence)
                                                                 // Assurez-vous que votre TextBox est nommé input1 dans votre formulaire
            guna2TextBox1.PasswordChar = '*';
            guna2TextBox1.IconLeft = Resource1.right;
            pictureBox1.Click += Btn_Click;

            // Définir l'image de fond pour la case à cocher

            //  button1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 40, 40)); // 20 est le rayon des coins arrondis

        }

        //  [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //  public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        // Gestionnaire d'événements pour le clic sur le bouton
        bool passwordVisible = false;

        private void Btn_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                pictureBox1.Image = Properties.Resources.eye_crossed__1_; // Changer l'image en "closed_eyes"
                guna2TextBox1.PasswordChar = '*'; // Masquer le texte dans le TextBox de mot de passe
            }
            else
            {
                pictureBox1.Image = Resource1.eye__1_; // Changer l'image en "opened_eyes"
                guna2TextBox1.PasswordChar = '\0'; // Afficher le texte normal dans le TextBox de mot de passe
            }

            // Inverser l'état du mot de passe visible pour la prochaine fois que le bouton est cliqué
            passwordVisible = !passwordVisible;
        }

        private void SetRoundedCorners(Panel panel, int topLeft, int topRight, int bottomLeft, int bottomRight)
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
            string email = inputTextBox.Text;
            string password = guna2TextBox1.Text;


            // Appeler la méthode d'authentification de la classe userDB
            User user = userDB.Authentifier(email, password);

                // Vérifier si l'utilisateur a été authentifié avec succès
                if (user != null)
                {
                UserControls.Dashboard Udashboard = new UserControls.Dashboard(user);
                UserControls.AddTransaction UAddTransaction = new UserControls.AddTransaction();
                 UserControls.ToHistory UHistory = new UserControls.ToHistory();
                 UserControls.AddCompte UCompte = new UserControls.AddCompte();
                Console.WriteLine("userrr1 imagge est" + user.img);


                Udashboard.remplir();
                UCompte.setUser(user);
                UAddTransaction.setUser(user);
                UCompte.remplirLabels();
                UHistory.setUser(user);   
                UHistory.LoadHistoryItemsFromDatabase();

                Form1 form1 = new Form1(user,Udashboard,  UHistory , UCompte,  UAddTransaction);


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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {
            // Créer une instance du contrôle utilisateur Logup
            Logup logupControl = new Logup();

            // Effacer tous les contrôles enfants de panel1
            panel1.Controls.Clear();

            // Ajouter le contrôle utilisateur Logup à panel1
            logupControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(logupControl);




        }
    }
    
}

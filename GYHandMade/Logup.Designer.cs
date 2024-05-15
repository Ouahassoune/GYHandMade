using System.ComponentModel;

namespace GYHandMade
{
    partial class Logup
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Logup(IContainer components)
        {
            this.components = components;
        }

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GradientTileButton3 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.labelLoginCredentials = new System.Windows.Forms.Label();
            this.second = new Guna.UI2.WinForms.Guna2TextBox();
            this.first = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pw = new Guna.UI2.WinForms.Guna2TextBox();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.second);
            this.panel1.Controls.Add(this.first);
            this.panel1.Controls.Add(this.guna2GradientTileButton3);
            this.panel1.Controls.Add(this.guna2GradientTileButton2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pw);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.guna2GradientTileButton1);
            this.panel1.Controls.Add(this.labelLoginCredentials);
            this.panel1.Location = new System.Drawing.Point(-14, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 449);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2GradientTileButton3
            // 
            this.guna2GradientTileButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton3.BorderRadius = 25;
            this.guna2GradientTileButton3.Checked = true;
            this.guna2GradientTileButton3.CheckedState.Parent = this.guna2GradientTileButton3;
            this.guna2GradientTileButton3.CustomImages.Parent = this.guna2GradientTileButton3;
            this.guna2GradientTileButton3.FillColor = System.Drawing.Color.Black;
            this.guna2GradientTileButton3.FillColor2 = System.Drawing.Color.DimGray;
            this.guna2GradientTileButton3.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton3.HoverState.Parent = this.guna2GradientTileButton3;
            this.guna2GradientTileButton3.Location = new System.Drawing.Point(563, 6);
            this.guna2GradientTileButton3.Margin = new System.Windows.Forms.Padding(1);
            this.guna2GradientTileButton3.Name = "guna2GradientTileButton3";
            this.guna2GradientTileButton3.ShadowDecoration.Parent = this.guna2GradientTileButton3;
            this.guna2GradientTileButton3.Size = new System.Drawing.Size(165, 39);
            this.guna2GradientTileButton3.TabIndex = 69;
            this.guna2GradientTileButton3.Text = "Sign Up";
            // 
            // guna2GradientTileButton2
            // 
            this.guna2GradientTileButton2.BorderRadius = 25;
            this.guna2GradientTileButton2.Checked = true;
            this.guna2GradientTileButton2.CheckedState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.CustomImages.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton2.HoverState.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Location = new System.Drawing.Point(381, 6);
            this.guna2GradientTileButton2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            this.guna2GradientTileButton2.ShadowDecoration.Parent = this.guna2GradientTileButton2;
            this.guna2GradientTileButton2.Size = new System.Drawing.Size(165, 39);
            this.guna2GradientTileButton2.TabIndex = 68;
            this.guna2GradientTileButton2.Text = "Sign In";
            this.guna2GradientTileButton2.Click += new System.EventHandler(this.guna2GradientTileButton2_Click);
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BorderRadius = 10;
            this.guna2GradientTileButton1.Checked = true;
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(472, 312);
            this.guna2GradientTileButton1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(209, 39);
            this.guna2GradientTileButton1.TabIndex = 55;
            this.guna2GradientTileButton1.Text = "SIGN UP";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // labelLoginCredentials
            // 
            this.labelLoginCredentials.AutoSize = true;
            this.labelLoginCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginCredentials.ForeColor = System.Drawing.Color.White;
            this.labelLoginCredentials.Location = new System.Drawing.Point(388, 49);
            this.labelLoginCredentials.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginCredentials.Name = "labelLoginCredentials";
            this.labelLoginCredentials.Size = new System.Drawing.Size(0, 24);
            this.labelLoginCredentials.TabIndex = 50;
            // 
            // second
            // 
            this.second.Animated = true;
            this.second.BorderColor = System.Drawing.Color.Indigo;
            this.second.BorderRadius = 25;
            this.second.BorderThickness = 2;
            this.second.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.second.DefaultText = "";
            this.second.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.second.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.second.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.second.DisabledState.Parent = this.second;
            this.second.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.second.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.second.FocusedState.Parent = this.second;
            this.second.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.ForeColor = System.Drawing.Color.Black;
            this.second.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.second.HoverState.Parent = this.second;
            this.second.IconLeft = ((System.Drawing.Image)(resources.GetObject("second.IconLeft")));
            this.second.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.second.IconLeftSize = new System.Drawing.Size(42, 42);
            this.second.Location = new System.Drawing.Point(421, 144);
            this.second.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.second.Name = "second";
            this.second.Padding = new System.Windows.Forms.Padding(8, 5, 4, 5);
            this.second.PasswordChar = '\0';
            this.second.PlaceholderText = "Enter Your Second Name";
            this.second.SelectedText = "";
            this.second.ShadowDecoration.Parent = this.second;
            this.second.Size = new System.Drawing.Size(360, 46);
            this.second.TabIndex = 71;
            // 
            // first
            // 
            this.first.Animated = true;
            this.first.BorderColor = System.Drawing.Color.Indigo;
            this.first.BorderRadius = 25;
            this.first.BorderThickness = 2;
            this.first.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.first.DefaultText = "";
            this.first.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.first.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.first.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.first.DisabledState.Parent = this.first;
            this.first.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.first.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.first.FocusedState.Parent = this.first;
            this.first.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first.ForeColor = System.Drawing.Color.Black;
            this.first.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.first.HoverState.Parent = this.first;
            this.first.IconLeft = ((System.Drawing.Image)(resources.GetObject("first.IconLeft")));
            this.first.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.first.IconLeftSize = new System.Drawing.Size(42, 42);
            this.first.Location = new System.Drawing.Point(53, 55);
            this.first.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.first.Name = "first";
            this.first.Padding = new System.Windows.Forms.Padding(8, 5, 4, 5);
            this.first.PasswordChar = '\0';
            this.first.PlaceholderText = "Enter Your Name";
            this.first.SelectedText = "";
            this.first.ShadowDecoration.Parent = this.first;
            this.first.Size = new System.Drawing.Size(360, 46);
            this.first.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GYHandMade.Properties.Resources.eye_crossed__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(681, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 66;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // pw
            // 
            this.pw.Animated = true;
            this.pw.BorderColor = System.Drawing.Color.Indigo;
            this.pw.BorderRadius = 25;
            this.pw.BorderThickness = 2;
            this.pw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pw.DefaultText = "";
            this.pw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pw.DisabledState.Parent = this.pw;
            this.pw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pw.FocusedState.Parent = this.pw;
            this.pw.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.ForeColor = System.Drawing.Color.Black;
            this.pw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pw.HoverState.Parent = this.pw;
            this.pw.IconLeft = ((System.Drawing.Image)(resources.GetObject("pw.IconLeft")));
            this.pw.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.pw.IconLeftSize = new System.Drawing.Size(42, 42);
            this.pw.Location = new System.Drawing.Point(421, 233);
            this.pw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pw.Name = "pw";
            this.pw.Padding = new System.Windows.Forms.Padding(8, 5, 4, 5);
            this.pw.PasswordChar = '\0';
            this.pw.PlaceholderText = "Enter Your Password";
            this.pw.SelectedText = "";
            this.pw.ShadowDecoration.Parent = this.pw;
            this.pw.Size = new System.Drawing.Size(360, 46);
            this.pw.TabIndex = 64;
            // 
            // email
            // 
            this.email.Animated = true;
            this.email.BorderColor = System.Drawing.Color.Indigo;
            this.email.BorderRadius = 25;
            this.email.BorderThickness = 2;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.FocusedState.Parent = this.email;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.HoverState.Parent = this.email;
            this.email.IconLeft = ((System.Drawing.Image)(resources.GetObject("email.IconLeft")));
            this.email.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.email.IconLeftSize = new System.Drawing.Size(42, 42);
            this.email.Location = new System.Drawing.Point(421, 55);
            this.email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(8, 5, 4, 5);
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "Enter Your Email";
            this.email.SelectedText = "";
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(360, 46);
            this.email.TabIndex = 63;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GYHandMade.Resource1._2;
            this.pictureBox3.Location = new System.Drawing.Point(71, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Logup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "Logup";
            this.Size = new System.Drawing.Size(854, 413);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton3;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox pw;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private System.Windows.Forms.Label labelLoginCredentials;
        private Guna.UI2.WinForms.Guna2TextBox second;
        private Guna.UI2.WinForms.Guna2TextBox first;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

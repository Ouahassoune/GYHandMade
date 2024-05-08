﻿namespace GYHandMade.UserControls
{
    partial class Transfer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.closebutton = new Bunifu.Framework.UI.BunifuImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BorderRadius = 25;
            this.guna2GradientTileButton1.Checked = true;
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientTileButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(62, 125);
            this.guna2GradientTileButton1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(165, 39);
            this.guna2GradientTileButton1.TabIndex = 59;
            this.guna2GradientTileButton1.Text = "Transfert";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click_1);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(76, 32);
            this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 19);
            this.Label1.TabIndex = 58;
            this.Label1.Text = "Transfer To Active";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Animated = true;
            this.inputTextBox.BorderColor = System.Drawing.Color.Indigo;
            this.inputTextBox.BorderRadius = 25;
            this.inputTextBox.BorderThickness = 2;
            this.inputTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTextBox.DefaultText = "";
            this.inputTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputTextBox.DisabledState.Parent = this.inputTextBox;
            this.inputTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputTextBox.FocusedState.Parent = this.inputTextBox;
            this.inputTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.ForeColor = System.Drawing.Color.Black;
            this.inputTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputTextBox.HoverState.Parent = this.inputTextBox;
            this.inputTextBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("inputTextBox.IconLeft")));
            this.inputTextBox.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.inputTextBox.IconLeftSize = new System.Drawing.Size(42, 42);
            this.inputTextBox.Location = new System.Drawing.Point(38, 68);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Padding = new System.Windows.Forms.Padding(8, 5, 4, 5);
            this.inputTextBox.PasswordChar = '\0';
            this.inputTextBox.PlaceholderText = "Enter Amount To Transfer";
            this.inputTextBox.SelectedText = "";
            this.inputTextBox.ShadowDecoration.Parent = this.inputTextBox;
            this.inputTextBox.Size = new System.Drawing.Size(209, 46);
            this.inputTextBox.TabIndex = 57;
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.Image")));
            this.closebutton.ImageActive = null;
            this.closebutton.Location = new System.Drawing.Point(260, 9);
            this.closebutton.Margin = new System.Windows.Forms.Padding(1);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(24, 17);
            this.closebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebutton.TabIndex = 60;
            this.closebutton.TabStop = false;
            this.closebutton.Zoom = 10;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(5, 76);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(29, 31);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 61;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Transfer";
            this.Size = new System.Drawing.Size(293, 191);
            this.Load += new System.EventHandler(this.Transfer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.closebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton closebutton;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private System.Windows.Forms.Label Label1;
        private Guna.UI2.WinForms.Guna2TextBox inputTextBox;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}

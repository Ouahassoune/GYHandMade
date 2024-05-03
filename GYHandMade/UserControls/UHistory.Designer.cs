namespace GYHandMade.UserControls
{
    partial class UHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UHistory));
            this.labelType = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.BackColor = System.Drawing.Color.Transparent;
            this.labelType.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(755, 58);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(89, 40);
            this.labelType.TabIndex = 46;
            this.labelType.Text = "TYPE";
            this.labelType.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.BackColor = System.Drawing.Color.Transparent;
            this.labelD.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(1094, 58);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(89, 40);
            this.labelD.TabIndex = 47;
            this.labelD.Text = "TYPE";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.BackColor = System.Drawing.Color.Transparent;
            this.labelM.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.Location = new System.Drawing.Point(457, 58);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(89, 40);
            this.labelM.TabIndex = 48;
            this.labelM.Text = "TYPE";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(1412, 58);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(89, 40);
            this.labelDate.TabIndex = 49;
            this.labelDate.Text = "TYPE";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.BackColor = System.Drawing.Color.Transparent;
            this.labelC.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.Location = new System.Drawing.Point(178, 58);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(89, 40);
            this.labelC.TabIndex = 50;
            this.labelC.Text = "TYPE";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(73, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox.ShadowDecoration.Parent = this.pictureBox;
            this.pictureBox.Size = new System.Drawing.Size(94, 94);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 51;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 40);
            this.label1.TabIndex = 52;
            this.label1.Text = "$";
            // 
            // UHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelType);
            this.Name = "UHistory";
            this.Size = new System.Drawing.Size(1700, 147);
            this.Load += new System.EventHandler(this.UHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelC;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox;
        private System.Windows.Forms.Label label1;
    }
}

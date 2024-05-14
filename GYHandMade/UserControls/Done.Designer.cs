namespace GYHandMade.UserControls
{
    partial class Done
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Done));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelGoalBudget = new System.Windows.Forms.Label();
            this.labelGoalDate = new System.Windows.Forms.Label();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.labelGoalName = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BtnAddAmount_Click = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddAmount_Click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.guna2CircleProgressBar1);
            this.panel1.Controls.Add(this.labelGoalName);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 421);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(219)))), ((int)(((byte)(215)))));
            this.panel2.Controls.Add(this.labelGoalBudget);
            this.panel2.Controls.Add(this.labelGoalDate);
            this.panel2.Location = new System.Drawing.Point(3, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 100);
            this.panel2.TabIndex = 50;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelGoalBudget
            // 
            this.labelGoalBudget.AutoSize = true;
            this.labelGoalBudget.BackColor = System.Drawing.Color.Transparent;
            this.labelGoalBudget.Font = new System.Drawing.Font("Century Gothic", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalBudget.Location = new System.Drawing.Point(59, 16);
            this.labelGoalBudget.Name = "labelGoalBudget";
            this.labelGoalBudget.Size = new System.Drawing.Size(99, 34);
            this.labelGoalBudget.TabIndex = 45;
            this.labelGoalBudget.Text = "label2";
            // 
            // labelGoalDate
            // 
            this.labelGoalDate.AutoSize = true;
            this.labelGoalDate.BackColor = System.Drawing.Color.Transparent;
            this.labelGoalDate.Font = new System.Drawing.Font("Century Gothic", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.labelGoalDate.Location = new System.Drawing.Point(59, 57);
            this.labelGoalDate.Name = "labelGoalDate";
            this.labelGoalDate.Size = new System.Drawing.Size(99, 34);
            this.labelGoalDate.TabIndex = 46;
            this.labelGoalDate.Text = "label3";
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2CircleProgressBar1.FillThickness = 9;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(427, 166);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2CircleProgressBar1.ProgressThickness = 8;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(65, 63);
            this.guna2CircleProgressBar1.TabIndex = 49;
            this.guna2CircleProgressBar1.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // labelGoalName
            // 
            this.labelGoalName.AutoSize = true;
            this.labelGoalName.BackColor = System.Drawing.Color.Transparent;
            this.labelGoalName.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoalName.Location = new System.Drawing.Point(138, 118);
            this.labelGoalName.Name = "labelGoalName";
            this.labelGoalName.Size = new System.Drawing.Size(118, 40);
            this.labelGoalName.TabIndex = 44;
            this.labelGoalName.Text = "label1";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(-76, -3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(674, 396);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 43;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 35;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // BtnAddAmount_Click
            // 
            this.BtnAddAmount_Click.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddAmount_Click.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddAmount_Click.Image")));
            this.BtnAddAmount_Click.ImageActive = null;
            this.BtnAddAmount_Click.Location = new System.Drawing.Point(295, 445);
            this.BtnAddAmount_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddAmount_Click.Name = "BtnAddAmount_Click";
            this.BtnAddAmount_Click.Size = new System.Drawing.Size(130, 92);
            this.BtnAddAmount_Click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnAddAmount_Click.TabIndex = 39;
            this.BtnAddAmount_Click.TabStop = false;
            this.BtnAddAmount_Click.Zoom = 10;
            this.BtnAddAmount_Click.Click += new System.EventHandler(this.BtnAddAmount_Click_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(114, 445);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(118, 96);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 40;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // Done
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.BtnAddAmount_Click);
            this.Controls.Add(this.panel1);
            this.Name = "Done";
            this.Size = new System.Drawing.Size(612, 549);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAddAmount_Click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label labelGoalName;
        private System.Windows.Forms.Label labelGoalBudget;
        private System.Windows.Forms.Label labelGoalDate;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Bunifu.Framework.UI.BunifuImageButton BtnAddAmount_Click;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
    }
}

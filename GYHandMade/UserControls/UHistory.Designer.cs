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
            this.labelType = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
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
            this.labelD.Location = new System.Drawing.Point(1101, 58);
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
            this.labelM.Location = new System.Drawing.Point(476, 58);
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
            this.labelDate.Location = new System.Drawing.Point(1426, 58);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(89, 40);
            this.labelDate.TabIndex = 49;
            this.labelDate.Text = "TYPE";
            // 
            // UHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelType);
            this.Name = "UHistory";
            this.Size = new System.Drawing.Size(1700, 164);
            this.Load += new System.EventHandler(this.UHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelDate;
    }
}

namespace GYHandMade.UserControls
{
    partial class AddIncome
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
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.BorderColor = System.Drawing.Color.SlateBlue;
            this.date.BorderRadius = 20;
            this.date.BorderThickness = 1;
            this.date.Checked = true;
            this.date.CheckedState.Parent = this.date;
            this.date.FillColor = System.Drawing.Color.White;
            this.date.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Indigo;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date.HoverState.Parent = this.date;
            this.date.Location = new System.Drawing.Point(457, 214);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.ShadowDecoration.Parent = this.date;
            this.date.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.date.Size = new System.Drawing.Size(443, 63);
            this.date.TabIndex = 0;
            this.date.Value = new System.DateTime(2024, 5, 2, 18, 15, 31, 726);
            // 
            // amount
            // 
            this.amount.Animated = true;
            this.amount.BorderColor = System.Drawing.Color.Indigo;
            this.amount.BorderRadius = 25;
            this.amount.BorderThickness = 2;
            this.amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount.DefaultText = "";
            this.amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount.DisabledState.Parent = this.amount;
            this.amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount.FocusedState.Parent = this.amount;
            this.amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amount.HoverState.Parent = this.amount;
            this.amount.IconLeftSize = new System.Drawing.Size(42, 42);
            this.amount.Location = new System.Drawing.Point(457, 108);
            this.amount.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.amount.Name = "amount";
            this.amount.Padding = new System.Windows.Forms.Padding(10);
            this.amount.PasswordChar = '\0';
            this.amount.PlaceholderText = "";
            this.amount.SelectedText = "";
            this.amount.ShadowDecoration.Parent = this.amount;
            this.amount.Size = new System.Drawing.Size(443, 59);
            this.amount.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(70, 108);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 17);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "Transaction Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Transaction Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(230, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Description";
            // 
            // desc
            // 
            this.desc.Animated = true;
            this.desc.BorderColor = System.Drawing.Color.Indigo;
            this.desc.BorderRadius = 25;
            this.desc.BorderThickness = 2;
            this.desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.desc.DefaultText = "";
            this.desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.desc.DisabledState.Parent = this.desc;
            this.desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.desc.FocusedState.Parent = this.desc;
            this.desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.desc.HoverState.Parent = this.desc;
            this.desc.IconLeftSize = new System.Drawing.Size(42, 42);
            this.desc.Location = new System.Drawing.Point(376, 349);
            this.desc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.desc.Name = "desc";
            this.desc.Padding = new System.Windows.Forms.Padding(9);
            this.desc.PasswordChar = '\0';
            this.desc.PlaceholderText = "";
            this.desc.SelectedText = "";
            this.desc.ShadowDecoration.Parent = this.desc;
            this.desc.Size = new System.Drawing.Size(388, 51);
            this.desc.TabIndex = 36;
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.BorderRadius = 25;
            this.guna2GradientTileButton1.Checked = true;
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(300, 420);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(439, 93);
            this.guna2GradientTileButton1.TabIndex = 40;
            this.guna2GradientTileButton1.Text = "ADD";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click_1);
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.date);
            this.Font = new System.Drawing.Font("Century Gothic", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddIncome";
            this.Size = new System.Drawing.Size(1419, 941);
            this.Load += new System.EventHandler(this.AddIncome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker date;
        private Guna.UI2.WinForms.Guna2TextBox amount;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox desc;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
    }
}

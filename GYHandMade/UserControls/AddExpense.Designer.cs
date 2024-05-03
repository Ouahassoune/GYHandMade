namespace GYHandMade.UserControls
{
    partial class AddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpense));
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
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

            this.guna2GradientTileButton1.Location = new System.Drawing.Point(482, 726);

            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(165, 39);
            this.guna2GradientTileButton1.TabIndex = 47;
            this.guna2GradientTileButton1.Text = "ADD";
            this.guna2GradientTileButton1.Click += new System.EventHandler(this.guna2GradientTileButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 46;
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
            this.desc.IconLeft = ((System.Drawing.Image)(resources.GetObject("desc.IconLeft")));
            this.desc.IconLeftSize = new System.Drawing.Size(42, 42);
            this.desc.Location = new System.Drawing.Point(184, 235);
            this.desc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.desc.Name = "desc";
            this.desc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desc.PasswordChar = '\0';
            this.desc.PlaceholderText = "";
            this.desc.SelectedText = "";
            this.desc.ShadowDecoration.Parent = this.desc;
            this.desc.Size = new System.Drawing.Size(146, 21);
            this.desc.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Transaction Date";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(39, 35);
            this.Label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 17);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "Transaction Amount";
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
            this.amount.IconLeft = ((System.Drawing.Image)(resources.GetObject("amount.IconLeft")));
            this.amount.IconLeftSize = new System.Drawing.Size(42, 42);
            this.amount.Location = new System.Drawing.Point(184, 35);
            this.amount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amount.Name = "amount";
            this.amount.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amount.PasswordChar = '\0';
            this.amount.PlaceholderText = "";
            this.amount.SelectedText = "";
            this.amount.ShadowDecoration.Parent = this.amount;
            this.amount.Size = new System.Drawing.Size(166, 25);
            this.amount.TabIndex = 42;
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
            this.date.Location = new System.Drawing.Point(184, 79);
            this.date.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.ShadowDecoration.Parent = this.date;
            this.date.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.date.Size = new System.Drawing.Size(166, 26);
            this.date.TabIndex = 41;
            this.date.Value = new System.DateTime(2024, 5, 2, 18, 15, 31, 726);
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.date);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "AddExpense";
            this.Size = new System.Drawing.Size(532, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private Guna.UI2.WinForms.Guna2TextBox amount;
        private Guna.UI2.WinForms.Guna2DateTimePicker date;
    }
}

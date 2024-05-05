namespace GYHandMade
{
    partial class testForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.img = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // img
            // 
            this.img.Image = global::GYHandMade.Properties.Resources.icons8_car_48;
            this.img.Location = new System.Drawing.Point(93, 46);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(180, 131);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(279, 123);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "upload";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // pic1
            // 
            this.pic1.Image = global::GYHandMade.Properties.Resources.icons8_car_48;
            this.pic1.Location = new System.Drawing.Point(489, 71);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(157, 50);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            // 
            // pic2
            // 
            this.pic2.Image = global::GYHandMade.Properties.Resources.icons8_car_48;
            this.pic2.Location = new System.Drawing.Point(489, 164);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(157, 74);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 4;
            this.pic2.TabStop = false;
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.img);
            this.Name = "testForm";
            this.Text = "testForm";
            this.Load += new System.EventHandler(this.testForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
    }
}
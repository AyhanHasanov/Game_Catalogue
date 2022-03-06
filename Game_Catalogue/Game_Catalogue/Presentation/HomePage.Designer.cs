namespace Game_Catalogue.Presentation
{
    partial class HomePage
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
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.MaximizeBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBox
            // 
            this.closeBox.Image = global::Game_Catalogue.Properties.Resources.icons8_close_52;
            this.closeBox.Location = new System.Drawing.Point(1363, 12);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(25, 25);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBox.TabIndex = 0;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MaximizeBox
            // 
            this.MaximizeBox.Image = global::Game_Catalogue.Properties.Resources.icons8_maximize_button_52;
            this.MaximizeBox.Location = new System.Drawing.Point(1332, 12);
            this.MaximizeBox.Name = "MaximizeBox";
            this.MaximizeBox.Size = new System.Drawing.Size(25, 25);
            this.MaximizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaximizeBox.TabIndex = 0;
            this.MaximizeBox.TabStop = false;
            this.MaximizeBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = global::Game_Catalogue.Properties.Resources.icons8_subtract_52;
            this.minimizeBox.Location = new System.Drawing.Point(1301, 12);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(25, 25);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBox.TabIndex = 0;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.MaximizeBox);
            this.Controls.Add(this.closeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox closeBox;
        private PictureBox MaximizeBox;
        private PictureBox minimizeBox;
    }
}
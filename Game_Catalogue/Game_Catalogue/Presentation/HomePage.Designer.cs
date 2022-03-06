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
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.addGameUserControl1 = new Game_Catalogue.Presentation.UserControls.AddGameUserControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBox
            // 
            this.closeBox.Image = global::Game_Catalogue.Properties.Resources.icons8_final_state_52;
            this.closeBox.Location = new System.Drawing.Point(1363, 9);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(25, 25);
            this.closeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeBox.TabIndex = 0;
            this.closeBox.TabStop = false;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            this.closeBox.MouseEnter += new System.EventHandler(this.closeBox_MouseEnter);
            this.closeBox.MouseLeave += new System.EventHandler(this.closeBox_MouseLeave);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = global::Game_Catalogue.Properties.Resources.icons8_final_state_52__2_;
            this.minimizeBox.Location = new System.Drawing.Point(1331, 9);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(25, 25);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBox.TabIndex = 0;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            this.minimizeBox.MouseEnter += new System.EventHandler(this.minimizeBox_MouseEnter);
            this.minimizeBox.MouseLeave += new System.EventHandler(this.minimizeBox_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(49)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 700);
            this.panel2.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 185);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(199, 88);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Add Game";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // addGameUserControl1
            // 
            this.addGameUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.addGameUserControl1.Location = new System.Drawing.Point(312, 88);
            this.addGameUserControl1.Name = "addGameUserControl1";
            this.addGameUserControl1.Size = new System.Drawing.Size(1000, 600);
            this.addGameUserControl1.TabIndex = 3;
            this.addGameUserControl1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(675, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sladuri games idk";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addGameUserControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.minimizeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox closeBox;
        private PictureBox minimizeBox;
        private Panel panel2;
        private UserControls.AddGameUserControl addGameUserControl1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
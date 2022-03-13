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
            this.components = new System.ComponentModel.Container();
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.myProfileBttn = new FontAwesome.Sharp.IconButton();
            this.myListBttn = new FontAwesome.Sharp.IconButton();
            this.addGamePageBttn = new FontAwesome.Sharp.IconButton();
            this.addGameUserControl1 = new Game_Catalogue.Presentation.UserControls.AddGameUserControl();
            this.label1 = new System.Windows.Forms.Label();
            this.myListUserControl1 = new Game_Catalogue.Presentation.MyListUserControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myProfile1 = new Game_Catalogue.Presentation.UserControls.MyProfile();
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.myProfileBttn);
            this.panel2.Controls.Add(this.myListBttn);
            this.panel2.Controls.Add(this.addGamePageBttn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 700);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "time";
            // 
            // myProfileBttn
            // 
            this.myProfileBttn.FlatAppearance.BorderSize = 0;
            this.myProfileBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfileBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myProfileBttn.ForeColor = System.Drawing.Color.White;
            this.myProfileBttn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.myProfileBttn.IconColor = System.Drawing.Color.White;
            this.myProfileBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.myProfileBttn.Location = new System.Drawing.Point(0, 396);
            this.myProfileBttn.Name = "myProfileBttn";
            this.myProfileBttn.Size = new System.Drawing.Size(199, 88);
            this.myProfileBttn.TabIndex = 5;
            this.myProfileBttn.Text = "My profile";
            this.myProfileBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.myProfileBttn.UseVisualStyleBackColor = true;
            this.myProfileBttn.Click += new System.EventHandler(this.myProfileBttn_Click);
            // 
            // myListBttn
            // 
            this.myListBttn.FlatAppearance.BorderSize = 0;
            this.myListBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myListBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myListBttn.ForeColor = System.Drawing.Color.White;
            this.myListBttn.IconChar = FontAwesome.Sharp.IconChar.UserSecret;
            this.myListBttn.IconColor = System.Drawing.Color.White;
            this.myListBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.myListBttn.Location = new System.Drawing.Point(0, 276);
            this.myListBttn.Name = "myListBttn";
            this.myListBttn.Size = new System.Drawing.Size(199, 88);
            this.myListBttn.TabIndex = 5;
            this.myListBttn.Text = "My List";
            this.myListBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.myListBttn.UseVisualStyleBackColor = true;
            this.myListBttn.Click += new System.EventHandler(this.myListBttn_Click);
            // 
            // addGamePageBttn
            // 
            this.addGamePageBttn.FlatAppearance.BorderSize = 0;
            this.addGamePageBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGamePageBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGamePageBttn.ForeColor = System.Drawing.Color.White;
            this.addGamePageBttn.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addGamePageBttn.IconColor = System.Drawing.Color.White;
            this.addGamePageBttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addGamePageBttn.Location = new System.Drawing.Point(0, 149);
            this.addGamePageBttn.Name = "addGamePageBttn";
            this.addGamePageBttn.Size = new System.Drawing.Size(199, 88);
            this.addGamePageBttn.TabIndex = 4;
            this.addGamePageBttn.Text = "Add Game";
            this.addGamePageBttn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addGamePageBttn.UseVisualStyleBackColor = true;
            this.addGamePageBttn.Click += new System.EventHandler(this.addGamePageBttn_Click);
            // 
            // addGameUserControl1
            // 
            this.addGameUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.addGameUserControl1.Location = new System.Drawing.Point(325, 87);
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
            this.label1.Location = new System.Drawing.Point(673, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sladuri games idk";
            // 
            // myListUserControl1
            // 
            this.myListUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.myListUserControl1.Location = new System.Drawing.Point(205, 84);
            this.myListUserControl1.Name = "myListUserControl1";
            this.myListUserControl1.Size = new System.Drawing.Size(1160, 616);
            this.myListUserControl1.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myProfile1
            // 
            this.myProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.myProfile1.Location = new System.Drawing.Point(452, 111);
            this.myProfile1.Name = "myProfile1";
            this.myProfile1.Size = new System.Drawing.Size(700, 545);
            this.myProfile1.TabIndex = 6;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.myProfile1);
            this.Controls.Add(this.myListUserControl1);
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
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox closeBox;
        private PictureBox minimizeBox;
        private Panel panel2;
        private UserControls.AddGameUserControl addGameUserControl1;
        private Label label1;
        private FontAwesome.Sharp.IconButton addGamePageBttn;
        private FontAwesome.Sharp.IconButton myListBttn;
        private MyListUserControl myListUserControl1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton myProfileBttn;
        private UserControls.MyProfile myProfile1;
    }
}
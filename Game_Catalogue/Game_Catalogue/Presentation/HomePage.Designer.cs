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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.closeBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.myProfileBttn = new FontAwesome.Sharp.IconButton();
            this.myListBttn = new FontAwesome.Sharp.IconButton();
            this.addGamePageBttn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.myProfilePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myProfileCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myProfileJoined = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.myProfileName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.addGamePanel = new System.Windows.Forms.Panel();
            this.browsePic = new Game_Catalogue.Presentation.Components.CustomButton();
            this.label10 = new System.Windows.Forms.Label();
            this.nameAGTxtBox = new System.Windows.Forms.TextBox();
            this.genresAGCombo = new Game_Catalogue.Presentation.Components.FlatCombo();
            this.descrpAGTxtBox = new System.Windows.Forms.TextBox();
            this.addGameBttn = new Game_Catalogue.Presentation.Components.CustomButton();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.playedAGRadioButton = new System.Windows.Forms.RadioButton();
            this.descrpPanel = new System.Windows.Forms.Panel();
            this.playingAGRadioButton = new System.Windows.Forms.RadioButton();
            this.planToPlayAGRadioBttn = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.myListPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.viewImageBttn = new Game_Catalogue.Presentation.Components.CustomButton();
            this.RfrshButt1 = new Game_Catalogue.Presentation.Components.CustomButton();
            this.genresMLCombo = new Game_Catalogue.Presentation.Components.FlatCombo();
            this.deleteBttn = new Game_Catalogue.Presentation.Components.CustomButton();
            this.playedMLButton = new System.Windows.Forms.RadioButton();
            this.playingMLButton = new System.Windows.Forms.RadioButton();
            this.planToPlayMLBttn = new System.Windows.Forms.RadioButton();
            this.descpPanel = new System.Windows.Forms.Panel();
            this.editDescriptionMLBttn = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.editNameMLBttn = new System.Windows.Forms.TextBox();
            this.updateBttn = new Game_Catalogue.Presentation.Components.CustomButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.myProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.addGamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.myListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBox
            // 
            this.closeBox.Image = global::Game_Catalogue.Properties.Resources.icons8_final_state_52;
            this.closeBox.Location = new System.Drawing.Point(1381, 9);
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
            this.minimizeBox.Location = new System.Drawing.Point(1349, 9);
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
            this.panel2.Size = new System.Drawing.Size(199, 714);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(700, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sladuri Games";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // myProfilePanel
            // 
            this.myProfilePanel.BackgroundImage = global::Game_Catalogue.Properties.Resources.Artboard_4_copy_2___whitened_for_the_background;
            this.myProfilePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.myProfilePanel.Controls.Add(this.pictureBox1);
            this.myProfilePanel.Controls.Add(this.myProfileCount);
            this.myProfilePanel.Controls.Add(this.label7);
            this.myProfilePanel.Controls.Add(this.label3);
            this.myProfilePanel.Controls.Add(this.myProfileJoined);
            this.myProfilePanel.Controls.Add(this.label4);
            this.myProfilePanel.Controls.Add(this.myProfileName);
            this.myProfilePanel.Controls.Add(this.label9);
            this.myProfilePanel.Location = new System.Drawing.Point(544, 47);
            this.myProfilePanel.Name = "myProfilePanel";
            this.myProfilePanel.Size = new System.Drawing.Size(556, 728);
            this.myProfilePanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Game_Catalogue.Properties.Resources.user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(233, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // myProfileCount
            // 
            this.myProfileCount.AutoSize = true;
            this.myProfileCount.BackColor = System.Drawing.Color.Transparent;
            this.myProfileCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myProfileCount.ForeColor = System.Drawing.Color.White;
            this.myProfileCount.Location = new System.Drawing.Point(95, 432);
            this.myProfileCount.Name = "myProfileCount";
            this.myProfileCount.Size = new System.Drawing.Size(36, 28);
            this.myProfileCount.TabIndex = 4;
            this.myProfileCount.Text = "00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.label7.Location = new System.Drawing.Point(4, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(549, 56);
            this.label7.TabIndex = 5;
            this.label7.Text = "Developed by Ayhan, Simona, Yuliana AKA THE SLADURI\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.label3.Location = new System.Drawing.Point(91, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 56);
            this.label3.TabIndex = 5;
            this.label3.Text = "You have that many games in your list\r\n\r\n";
            // 
            // myProfileJoined
            // 
            this.myProfileJoined.AutoSize = true;
            this.myProfileJoined.BackColor = System.Drawing.Color.Transparent;
            this.myProfileJoined.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myProfileJoined.ForeColor = System.Drawing.Color.White;
            this.myProfileJoined.Location = new System.Drawing.Point(95, 332);
            this.myProfileJoined.Name = "myProfileJoined";
            this.myProfileJoined.Size = new System.Drawing.Size(104, 28);
            this.myProfileJoined.TabIndex = 6;
            this.myProfileJoined.Text = "Joined on";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.label4.Location = new System.Drawing.Point(95, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "You joined us on";
            // 
            // myProfileName
            // 
            this.myProfileName.AutoSize = true;
            this.myProfileName.BackColor = System.Drawing.Color.Transparent;
            this.myProfileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.myProfileName.ForeColor = System.Drawing.Color.White;
            this.myProfileName.Location = new System.Drawing.Point(95, 241);
            this.myProfileName.Name = "myProfileName";
            this.myProfileName.Size = new System.Drawing.Size(68, 28);
            this.myProfileName.TabIndex = 8;
            this.myProfileName.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.label9.Location = new System.Drawing.Point(95, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(371, 28);
            this.label9.TabIndex = 9;
            this.label9.Text = "We know you as: (aka your username)";
            // 
            // addGamePanel
            // 
            this.addGamePanel.Controls.Add(this.browsePic);
            this.addGamePanel.Controls.Add(this.label10);
            this.addGamePanel.Controls.Add(this.nameAGTxtBox);
            this.addGamePanel.Controls.Add(this.genresAGCombo);
            this.addGamePanel.Controls.Add(this.descrpAGTxtBox);
            this.addGamePanel.Controls.Add(this.addGameBttn);
            this.addGamePanel.Controls.Add(this.gamePanel);
            this.addGamePanel.Controls.Add(this.playedAGRadioButton);
            this.addGamePanel.Controls.Add(this.descrpPanel);
            this.addGamePanel.Controls.Add(this.playingAGRadioButton);
            this.addGamePanel.Controls.Add(this.planToPlayAGRadioBttn);
            this.addGamePanel.Controls.Add(this.pictureBox2);
            this.addGamePanel.Location = new System.Drawing.Point(263, 94);
            this.addGamePanel.Name = "addGamePanel";
            this.addGamePanel.Size = new System.Drawing.Size(997, 597);
            this.addGamePanel.TabIndex = 11;
            // 
            // browsePic
            // 
            this.browsePic.BorderColor = System.Drawing.Color.White;
            this.browsePic.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.browsePic.FlatAppearance.BorderSize = 0;
            this.browsePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsePic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browsePic.ForeColor = System.Drawing.Color.White;
            this.browsePic.Location = new System.Drawing.Point(888, 485);
            this.browsePic.Name = "browsePic";
            this.browsePic.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.browsePic.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.browsePic.OnHoverTextColor = System.Drawing.Color.White;
            this.browsePic.Size = new System.Drawing.Size(60, 59);
            this.browsePic.TabIndex = 9;
            this.browsePic.Text = "...";
            this.browsePic.TextColor = System.Drawing.Color.White;
            this.browsePic.UseVisualStyleBackColor = true;
            this.browsePic.Click += new System.EventHandler(this.browsePic_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(391, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 45);
            this.label10.TabIndex = 0;
            this.label10.Text = "Add Game";
            // 
            // nameAGTxtBox
            // 
            this.nameAGTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.nameAGTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameAGTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameAGTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameAGTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.nameAGTxtBox.Location = new System.Drawing.Point(91, 149);
            this.nameAGTxtBox.MaxLength = 255;
            this.nameAGTxtBox.Name = "nameAGTxtBox";
            this.nameAGTxtBox.Size = new System.Drawing.Size(375, 30);
            this.nameAGTxtBox.TabIndex = 1;
            this.nameAGTxtBox.Text = "Name of game";
            this.nameAGTxtBox.Click += new System.EventHandler(this.nameAGTxtBox_Click);
            this.nameAGTxtBox.Enter += new System.EventHandler(this.nameAGTxtBox_Enter);
            this.nameAGTxtBox.Leave += new System.EventHandler(this.nameAGTxtBox_Leave);
            this.nameAGTxtBox.MouseEnter += new System.EventHandler(this.nameAGTxtBox_MouseEnter);
            this.nameAGTxtBox.MouseLeave += new System.EventHandler(this.nameAGTxtBox_MouseLeave);
            // 
            // genresAGCombo
            // 
            this.genresAGCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.genresAGCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.genresAGCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genresAGCombo.Font = new System.Drawing.Font("Segoe UI", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genresAGCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.genresAGCombo.FormattingEnabled = true;
            this.genresAGCombo.Location = new System.Drawing.Point(92, 339);
            this.genresAGCombo.Name = "genresAGCombo";
            this.genresAGCombo.Size = new System.Drawing.Size(376, 38);
            this.genresAGCombo.TabIndex = 7;
            // 
            // descrpAGTxtBox
            // 
            this.descrpAGTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.descrpAGTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descrpAGTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descrpAGTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descrpAGTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.descrpAGTxtBox.Location = new System.Drawing.Point(538, 149);
            this.descrpAGTxtBox.Multiline = true;
            this.descrpAGTxtBox.Name = "descrpAGTxtBox";
            this.descrpAGTxtBox.Size = new System.Drawing.Size(407, 137);
            this.descrpAGTxtBox.TabIndex = 2;
            this.descrpAGTxtBox.Text = "Description";
            this.descrpAGTxtBox.Click += new System.EventHandler(this.descrpAGTxtBox_Click);
            this.descrpAGTxtBox.Enter += new System.EventHandler(this.descrpAGTxtBox_Enter);
            this.descrpAGTxtBox.Leave += new System.EventHandler(this.descrpAGTxtBox_Leave);
            this.descrpAGTxtBox.MouseEnter += new System.EventHandler(this.descrpAGTxtBox_MouseEnter);
            this.descrpAGTxtBox.MouseLeave += new System.EventHandler(this.descrpAGTxtBox_MouseLeave);
            // 
            // addGameBttn
            // 
            this.addGameBttn.BorderColor = System.Drawing.Color.White;
            this.addGameBttn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.addGameBttn.FlatAppearance.BorderSize = 0;
            this.addGameBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGameBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addGameBttn.ForeColor = System.Drawing.Color.White;
            this.addGameBttn.Location = new System.Drawing.Point(91, 469);
            this.addGameBttn.Name = "addGameBttn";
            this.addGameBttn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.addGameBttn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.addGameBttn.OnHoverTextColor = System.Drawing.Color.White;
            this.addGameBttn.Size = new System.Drawing.Size(168, 74);
            this.addGameBttn.TabIndex = 6;
            this.addGameBttn.Text = "Add Game";
            this.addGameBttn.TextColor = System.Drawing.Color.White;
            this.addGameBttn.UseVisualStyleBackColor = true;
            this.addGameBttn.Click += new System.EventHandler(this.addGameBttn_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.gamePanel.Location = new System.Drawing.Point(90, 183);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(376, 6);
            this.gamePanel.TabIndex = 3;
            // 
            // playedAGRadioButton
            // 
            this.playedAGRadioButton.AutoSize = true;
            this.playedAGRadioButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playedAGRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.playedAGRadioButton.Location = new System.Drawing.Point(353, 213);
            this.playedAGRadioButton.Name = "playedAGRadioButton";
            this.playedAGRadioButton.Size = new System.Drawing.Size(98, 34);
            this.playedAGRadioButton.TabIndex = 5;
            this.playedAGRadioButton.TabStop = true;
            this.playedAGRadioButton.Text = "Played";
            this.playedAGRadioButton.UseVisualStyleBackColor = true;
            this.playedAGRadioButton.CheckedChanged += new System.EventHandler(this.playedAGRadioButton_CheckedChanged);
            // 
            // descrpPanel
            // 
            this.descrpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.descrpPanel.Location = new System.Drawing.Point(541, 287);
            this.descrpPanel.Name = "descrpPanel";
            this.descrpPanel.Size = new System.Drawing.Size(407, 6);
            this.descrpPanel.TabIndex = 3;
            // 
            // playingAGRadioButton
            // 
            this.playingAGRadioButton.AutoSize = true;
            this.playingAGRadioButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playingAGRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.playingAGRadioButton.Location = new System.Drawing.Point(244, 213);
            this.playingAGRadioButton.Name = "playingAGRadioButton";
            this.playingAGRadioButton.Size = new System.Drawing.Size(103, 34);
            this.playingAGRadioButton.TabIndex = 4;
            this.playingAGRadioButton.TabStop = true;
            this.playingAGRadioButton.Text = "Playing";
            this.playingAGRadioButton.UseVisualStyleBackColor = true;
            this.playingAGRadioButton.CheckedChanged += new System.EventHandler(this.playingAGRadioButton_CheckedChanged);
            // 
            // planToPlayAGRadioBttn
            // 
            this.planToPlayAGRadioBttn.AutoSize = true;
            this.planToPlayAGRadioBttn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.planToPlayAGRadioBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.planToPlayAGRadioBttn.Location = new System.Drawing.Point(92, 213);
            this.planToPlayAGRadioBttn.Name = "planToPlayAGRadioBttn";
            this.planToPlayAGRadioBttn.Size = new System.Drawing.Size(146, 34);
            this.planToPlayAGRadioBttn.TabIndex = 3;
            this.planToPlayAGRadioBttn.TabStop = true;
            this.planToPlayAGRadioBttn.Text = "Plan to play";
            this.planToPlayAGRadioBttn.UseVisualStyleBackColor = true;
            this.planToPlayAGRadioBttn.CheckedChanged += new System.EventHandler(this.planToPlayAGRadioBttn_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(541, 339);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(404, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // myListPanel
            // 
            this.myListPanel.Controls.Add(this.label6);
            this.myListPanel.Controls.Add(this.label5);
            this.myListPanel.Controls.Add(this.viewImageBttn);
            this.myListPanel.Controls.Add(this.RfrshButt1);
            this.myListPanel.Controls.Add(this.genresMLCombo);
            this.myListPanel.Controls.Add(this.deleteBttn);
            this.myListPanel.Controls.Add(this.playedMLButton);
            this.myListPanel.Controls.Add(this.playingMLButton);
            this.myListPanel.Controls.Add(this.planToPlayMLBttn);
            this.myListPanel.Controls.Add(this.descpPanel);
            this.myListPanel.Controls.Add(this.editDescriptionMLBttn);
            this.myListPanel.Controls.Add(this.panel4);
            this.myListPanel.Controls.Add(this.editNameMLBttn);
            this.myListPanel.Controls.Add(this.updateBttn);
            this.myListPanel.Controls.Add(this.dataGridView1);
            this.myListPanel.Controls.Add(this.pictureBox3);
            this.myListPanel.Location = new System.Drawing.Point(212, 64);
            this.myListPanel.Name = "myListPanel";
            this.myListPanel.Size = new System.Drawing.Size(1176, 636);
            this.myListPanel.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.label6.Location = new System.Drawing.Point(645, 605);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(528, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "To view the image in full size click the specific row and then this button :)\r\n";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "To change data click on a specific row!\r\n\r\n";
            // 
            // viewImageBttn
            // 
            this.viewImageBttn.BorderColor = System.Drawing.Color.White;
            this.viewImageBttn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.viewImageBttn.FlatAppearance.BorderSize = 0;
            this.viewImageBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewImageBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewImageBttn.ForeColor = System.Drawing.Color.White;
            this.viewImageBttn.Location = new System.Drawing.Point(977, 555);
            this.viewImageBttn.Name = "viewImageBttn";
            this.viewImageBttn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.viewImageBttn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.viewImageBttn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewImageBttn.Size = new System.Drawing.Size(196, 47);
            this.viewImageBttn.TabIndex = 18;
            this.viewImageBttn.Text = "View Image";
            this.viewImageBttn.TextColor = System.Drawing.Color.White;
            this.viewImageBttn.UseVisualStyleBackColor = true;
            this.viewImageBttn.Click += new System.EventHandler(this.viewImageBttn_Click);
            // 
            // RfrshButt1
            // 
            this.RfrshButt1.BorderColor = System.Drawing.Color.White;
            this.RfrshButt1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.RfrshButt1.FlatAppearance.BorderSize = 0;
            this.RfrshButt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RfrshButt1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RfrshButt1.ForeColor = System.Drawing.Color.White;
            this.RfrshButt1.Location = new System.Drawing.Point(121, 502);
            this.RfrshButt1.Name = "RfrshButt1";
            this.RfrshButt1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.RfrshButt1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.RfrshButt1.OnHoverTextColor = System.Drawing.Color.White;
            this.RfrshButt1.Size = new System.Drawing.Size(112, 47);
            this.RfrshButt1.TabIndex = 17;
            this.RfrshButt1.Text = "Refresh";
            this.RfrshButt1.TextColor = System.Drawing.Color.White;
            this.RfrshButt1.UseVisualStyleBackColor = true;
            this.RfrshButt1.Click += new System.EventHandler(this.RfrshButt1_Click);
            // 
            // genresMLCombo
            // 
            this.genresMLCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.genresMLCombo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.genresMLCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genresMLCombo.Font = new System.Drawing.Font("Segoe UI", 13.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genresMLCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.genresMLCombo.FormattingEnabled = true;
            this.genresMLCombo.Location = new System.Drawing.Point(17, 293);
            this.genresMLCombo.Name = "genresMLCombo";
            this.genresMLCombo.Size = new System.Drawing.Size(216, 38);
            this.genresMLCombo.TabIndex = 16;
            // 
            // deleteBttn
            // 
            this.deleteBttn.BorderColor = System.Drawing.Color.White;
            this.deleteBttn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.deleteBttn.FlatAppearance.BorderSize = 0;
            this.deleteBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteBttn.ForeColor = System.Drawing.Color.White;
            this.deleteBttn.Location = new System.Drawing.Point(3, 555);
            this.deleteBttn.Name = "deleteBttn";
            this.deleteBttn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.deleteBttn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.deleteBttn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBttn.Size = new System.Drawing.Size(230, 47);
            this.deleteBttn.TabIndex = 14;
            this.deleteBttn.Text = "Delete";
            this.deleteBttn.TextColor = System.Drawing.Color.White;
            this.deleteBttn.UseVisualStyleBackColor = true;
            this.deleteBttn.Click += new System.EventHandler(this.deleteBttn_Click);
            // 
            // playedMLButton
            // 
            this.playedMLButton.AutoSize = true;
            this.playedMLButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playedMLButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.playedMLButton.Location = new System.Drawing.Point(17, 447);
            this.playedMLButton.Name = "playedMLButton";
            this.playedMLButton.Size = new System.Drawing.Size(98, 34);
            this.playedMLButton.TabIndex = 13;
            this.playedMLButton.TabStop = true;
            this.playedMLButton.Text = "Played";
            this.playedMLButton.UseVisualStyleBackColor = true;
            // 
            // playingMLButton
            // 
            this.playingMLButton.AutoSize = true;
            this.playingMLButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playingMLButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.playingMLButton.Location = new System.Drawing.Point(17, 399);
            this.playingMLButton.Name = "playingMLButton";
            this.playingMLButton.Size = new System.Drawing.Size(103, 34);
            this.playingMLButton.TabIndex = 12;
            this.playingMLButton.TabStop = true;
            this.playingMLButton.Text = "Playing";
            this.playingMLButton.UseVisualStyleBackColor = true;
            // 
            // planToPlayMLBttn
            // 
            this.planToPlayMLBttn.AutoSize = true;
            this.planToPlayMLBttn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.planToPlayMLBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.planToPlayMLBttn.Location = new System.Drawing.Point(17, 354);
            this.planToPlayMLBttn.Name = "planToPlayMLBttn";
            this.planToPlayMLBttn.Size = new System.Drawing.Size(146, 34);
            this.planToPlayMLBttn.TabIndex = 11;
            this.planToPlayMLBttn.TabStop = true;
            this.planToPlayMLBttn.Text = "Plan to play";
            this.planToPlayMLBttn.UseVisualStyleBackColor = true;
            // 
            // descpPanel
            // 
            this.descpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.descpPanel.Location = new System.Drawing.Point(17, 254);
            this.descpPanel.Name = "descpPanel";
            this.descpPanel.Size = new System.Drawing.Size(216, 6);
            this.descpPanel.TabIndex = 10;
            // 
            // editDescriptionMLBttn
            // 
            this.editDescriptionMLBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.editDescriptionMLBttn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editDescriptionMLBttn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editDescriptionMLBttn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editDescriptionMLBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.editDescriptionMLBttn.Location = new System.Drawing.Point(17, 122);
            this.editDescriptionMLBttn.Multiline = true;
            this.editDescriptionMLBttn.Name = "editDescriptionMLBttn";
            this.editDescriptionMLBttn.Size = new System.Drawing.Size(216, 126);
            this.editDescriptionMLBttn.TabIndex = 10;
            this.editDescriptionMLBttn.Text = "Edit description";
            this.editDescriptionMLBttn.Click += new System.EventHandler(this.editDescriptionMLBttn_Click);
            this.editDescriptionMLBttn.Enter += new System.EventHandler(this.editDescriptionMLBttn_Enter);
            this.editDescriptionMLBttn.Leave += new System.EventHandler(this.editDescriptionMLBttn_Leave);
            this.editDescriptionMLBttn.MouseEnter += new System.EventHandler(this.editDescriptionMLBttn_MouseEnter);
            this.editDescriptionMLBttn.MouseLeave += new System.EventHandler(this.editDescriptionMLBttn_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.panel4.Location = new System.Drawing.Point(17, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 6);
            this.panel4.TabIndex = 9;
            // 
            // editNameMLBttn
            // 
            this.editNameMLBttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.editNameMLBttn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editNameMLBttn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.editNameMLBttn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.editNameMLBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.editNameMLBttn.Location = new System.Drawing.Point(17, 39);
            this.editNameMLBttn.MaxLength = 255;
            this.editNameMLBttn.Name = "editNameMLBttn";
            this.editNameMLBttn.Size = new System.Drawing.Size(216, 30);
            this.editNameMLBttn.TabIndex = 8;
            this.editNameMLBttn.Text = "Edit name";
            this.editNameMLBttn.Click += new System.EventHandler(this.editNameMLBttn_Click);
            this.editNameMLBttn.Enter += new System.EventHandler(this.editNameMLBttn_Enter);
            this.editNameMLBttn.Leave += new System.EventHandler(this.editNameMLBttn_Leave);
            this.editNameMLBttn.MouseEnter += new System.EventHandler(this.editNameMLBttn_MouseEnter);
            this.editNameMLBttn.MouseLeave += new System.EventHandler(this.editNameMLBttn_MouseLeave);
            // 
            // updateBttn
            // 
            this.updateBttn.BorderColor = System.Drawing.Color.White;
            this.updateBttn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.updateBttn.FlatAppearance.BorderSize = 0;
            this.updateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBttn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBttn.ForeColor = System.Drawing.Color.White;
            this.updateBttn.Location = new System.Drawing.Point(3, 502);
            this.updateBttn.Name = "updateBttn";
            this.updateBttn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.updateBttn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.updateBttn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBttn.Size = new System.Drawing.Size(112, 47);
            this.updateBttn.TabIndex = 7;
            this.updateBttn.Text = "Update";
            this.updateBttn.TextColor = System.Drawing.Color.White;
            this.updateBttn.UseVisualStyleBackColor = true;
            this.updateBttn.Click += new System.EventHandler(this.updateBttn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.dataGridView1.Location = new System.Drawing.Point(266, 34);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 47;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(876, 568);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Game_Catalogue.Properties.Resources.clickbait;
            this.pictureBox3.Location = new System.Drawing.Point(2, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(264, 580);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1425, 714);
            this.Controls.Add(this.myProfilePanel);
            this.Controls.Add(this.myListPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.addGamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.myProfilePanel.ResumeLayout(false);
            this.myProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.addGamePanel.ResumeLayout(false);
            this.addGamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.myListPanel.ResumeLayout(false);
            this.myListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox closeBox;
        private PictureBox minimizeBox;
        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton addGamePageBttn;
        private FontAwesome.Sharp.IconButton myListBttn;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton myProfileBttn;
        private Panel myProfilePanel;
        private PictureBox pictureBox1;
        private Label myProfileCount;
        private Label label3;
        private Label myProfileJoined;
        private Label label4;
        private Label myProfileName;
        private Label label9;
        private Panel addGamePanel;
        private Components.CustomButton browsePic;
        private Label label10;
        private TextBox nameAGTxtBox;
        private Components.FlatCombo genresAGCombo;
        private TextBox descrpAGTxtBox;
        private Components.CustomButton addGameBttn;
        private Panel gamePanel;
        private RadioButton playedAGRadioButton;
        private Panel descrpPanel;
        private RadioButton playingAGRadioButton;
        private RadioButton planToPlayAGRadioBttn;
        private PictureBox pictureBox2;
        private Panel myListPanel;
        private Components.FlatCombo genresMLCombo;
        private Components.CustomButton deleteBttn;
        private RadioButton playedMLButton;
        private RadioButton playingMLButton;
        private RadioButton planToPlayMLBttn;
        private Panel descpPanel;
        private TextBox editDescriptionMLBttn;
        private Panel panel4;
        private TextBox editNameMLBttn;
        private Components.CustomButton updateBttn;
        private DataGridView dataGridView1;
        private Components.CustomButton RfrshButt1;
        private Components.CustomButton viewImageBttn;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
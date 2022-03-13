namespace Game_Catalogue.Presentation
{
    partial class Registration
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
            this.Registration_Button = new Game_Catalogue.Presentation.Components.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.email_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Registration_Button
            // 
            this.Registration_Button.BorderColor = System.Drawing.Color.White;
            this.Registration_Button.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.Registration_Button.FlatAppearance.BorderSize = 0;
            this.Registration_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Registration_Button.ForeColor = System.Drawing.Color.White;
            this.Registration_Button.Location = new System.Drawing.Point(129, 459);
            this.Registration_Button.Name = "Registration_Button";
            this.Registration_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Registration_Button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.Registration_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.Registration_Button.Size = new System.Drawing.Size(137, 42);
            this.Registration_Button.TabIndex = 8;
            this.Registration_Button.Text = "Register";
            this.Registration_Button.TextColor = System.Drawing.Color.White;
            this.Registration_Button.UseVisualStyleBackColor = true;
            this.Registration_Button.Click += new System.EventHandler(this.Registration_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.panel1.Location = new System.Drawing.Point(72, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 6);
            this.panel1.TabIndex = 16;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.gamePanel.Location = new System.Drawing.Point(72, 275);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(256, 6);
            this.gamePanel.TabIndex = 15;
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.password_textbox.Location = new System.Drawing.Point(72, 378);
            this.password_textbox.MaxLength = 255;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(256, 27);
            this.password_textbox.TabIndex = 14;
            this.password_textbox.Text = "Password";
            this.password_textbox.Click += new System.EventHandler(this.password_textbox_Click);
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            this.password_textbox.Enter += new System.EventHandler(this.password_textbox_Enter);
            this.password_textbox.Leave += new System.EventHandler(this.password_textbox_Leave);
            this.password_textbox.MouseEnter += new System.EventHandler(this.password_textbox_MouseEnter);
            this.password_textbox.MouseLeave += new System.EventHandler(this.password_textbox_MouseLeave);
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.username_textbox.Location = new System.Drawing.Point(72, 240);
            this.username_textbox.MaxLength = 255;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(256, 27);
            this.username_textbox.TabIndex = 13;
            this.username_textbox.Text = "Username";
            this.username_textbox.Click += new System.EventHandler(this.username_textbox_Click);
            this.username_textbox.Enter += new System.EventHandler(this.username_textbox_Enter);
            this.username_textbox.Leave += new System.EventHandler(this.username_textbox_Leave);
            this.username_textbox.MouseEnter += new System.EventHandler(this.username_textbox_MouseEnter);
            this.username_textbox.MouseLeave += new System.EventHandler(this.username_textbox_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.panel2.Location = new System.Drawing.Point(72, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 6);
            this.panel2.TabIndex = 18;
            // 
            // email_textBox1
            // 
            this.email_textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.email_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_textBox1.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.email_textBox1.Location = new System.Drawing.Point(72, 313);
            this.email_textBox1.MaxLength = 255;
            this.email_textBox1.Name = "email_textBox1";
            this.email_textBox1.Size = new System.Drawing.Size(256, 27);
            this.email_textBox1.TabIndex = 17;
            this.email_textBox1.Text = "Email Address";
            this.email_textBox1.Click += new System.EventHandler(this.email_textBox1_Click);
            this.email_textBox1.Enter += new System.EventHandler(this.email_textBox1_Enter);
            this.email_textBox1.Leave += new System.EventHandler(this.email_textBox1_Leave);
            this.email_textBox1.MouseEnter += new System.EventHandler(this.email_textBox1_MouseEnter);
            this.email_textBox1.MouseLeave += new System.EventHandler(this.email_textBox1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 42);
            this.label1.TabIndex = 19;
            this.label1.Text = "Create an Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_Catalogue.Properties.Resources.Artboard_4_copy_4;
            this.pictureBox1.Location = new System.Drawing.Point(151, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Game_Catalogue.Properties.Resources.icons8_uchiha_eyes_50;
            this.pictureBox2.Location = new System.Drawing.Point(34, 378);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseClick);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(408, 532);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.email_textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.Registration_Button);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.CustomButton Registration_Button;
        private Panel panel1;
        private Panel gamePanel;
        private TextBox password_textbox;
        private TextBox username_textbox;
        private Panel panel2;
        private TextBox email_textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
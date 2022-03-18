namespace Game_Catalogue.Presentation
{
    partial class LogIn_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_Form));
            this.LogIn_Button = new Game_Catalogue.Presentation.Components.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eyeBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogIn_Button
            // 
            this.LogIn_Button.BorderColor = System.Drawing.Color.White;
            this.LogIn_Button.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.LogIn_Button.FlatAppearance.BorderSize = 0;
            this.LogIn_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogIn_Button.ForeColor = System.Drawing.Color.White;
            this.LogIn_Button.Location = new System.Drawing.Point(129, 460);
            this.LogIn_Button.Name = "LogIn_Button";
            this.LogIn_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.LogIn_Button.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.LogIn_Button.OnHoverTextColor = System.Drawing.Color.White;
            this.LogIn_Button.Size = new System.Drawing.Size(137, 44);
            this.LogIn_Button.TabIndex = 3;
            this.LogIn_Button.Text = "LogIn";
            this.LogIn_Button.TextColor = System.Drawing.Color.White;
            this.LogIn_Button.UseVisualStyleBackColor = true;
            this.LogIn_Button.Click += new System.EventHandler(this.LogIn_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Don\'t have an account?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textbox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.username_textbox.Location = new System.Drawing.Point(56, 242);
            this.username_textbox.MaxLength = 255;
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(294, 30);
            this.username_textbox.TabIndex = 1;
            this.username_textbox.Text = "Username";
            this.username_textbox.Click += new System.EventHandler(this.username_textbox_Click);
            this.username_textbox.Enter += new System.EventHandler(this.username_textbox_Enter);
            this.username_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_textbox_KeyDown);
            this.username_textbox.Leave += new System.EventHandler(this.username_textbox_Leave);
            this.username_textbox.MouseEnter += new System.EventHandler(this.username_textbox_MouseEnter);
            this.username_textbox.MouseLeave += new System.EventHandler(this.username_textbox_MouseLeave);
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.password_textbox.Location = new System.Drawing.Point(56, 324);
            this.password_textbox.MaxLength = 255;
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(256, 30);
            this.password_textbox.TabIndex = 2;
            this.password_textbox.Text = "Password";
            this.password_textbox.Click += new System.EventHandler(this.password_textbox_Click);
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            this.password_textbox.Enter += new System.EventHandler(this.password_textbox_Enter);
            this.password_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_textbox_KeyDown);
            this.password_textbox.Leave += new System.EventHandler(this.password_textbox_Leave);
            this.password_textbox.MouseEnter += new System.EventHandler(this.password_textbox_MouseEnter);
            this.password_textbox.MouseLeave += new System.EventHandler(this.password_textbox_MouseLeave);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.gamePanel.Location = new System.Drawing.Point(56, 278);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(294, 6);
            this.gamePanel.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.panel1.Location = new System.Drawing.Point(56, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 6);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(149, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 45);
            this.label2.TabIndex = 20;
            this.label2.Text = "LogIn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_Catalogue.Properties.Resources.Artboard_4_copy_4;
            this.pictureBox1.Location = new System.Drawing.Point(153, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // eyeBox
            // 
            this.eyeBox.Image = global::Game_Catalogue.Properties.Resources.icons8_uchiha_eyes_50;
            this.eyeBox.Location = new System.Drawing.Point(318, 318);
            this.eyeBox.Name = "eyeBox";
            this.eyeBox.Size = new System.Drawing.Size(32, 36);
            this.eyeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eyeBox.TabIndex = 22;
            this.eyeBox.TabStop = false;
            this.eyeBox.Click += new System.EventHandler(this.eyeBox_Click);
            // 
            // LogIn_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(408, 564);
            this.Controls.Add(this.eyeBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogIn_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn_Form";
            this.Text = "LogIn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogIn_Form_FormClosing);
            this.Load += new System.EventHandler(this.LogIn_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eyeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.CustomButton LogIn_Button;
        private Label label1;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private Panel gamePanel;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox eyeBox;
    }
}
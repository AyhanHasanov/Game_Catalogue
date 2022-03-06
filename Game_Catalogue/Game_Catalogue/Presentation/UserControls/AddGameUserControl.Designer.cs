﻿namespace Game_Catalogue.Presentation.UserControls
{
    partial class AddGameUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.gameTxtBox = new System.Windows.Forms.TextBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.descrpTxtBox = new System.Windows.Forms.TextBox();
            this.descrpPanel = new System.Windows.Forms.Panel();
            this.planToPlayRadioBttn = new System.Windows.Forms.RadioButton();
            this.playingRadioButton = new System.Windows.Forms.RadioButton();
            this.playedRadioButton = new System.Windows.Forms.RadioButton();
            this.customButton1 = new Game_Catalogue.Presentation.Components.CustomButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(396, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Game";
            // 
            // gameTxtBox
            // 
            this.gameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.gameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gameTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.gameTxtBox.Location = new System.Drawing.Point(53, 136);
            this.gameTxtBox.MaxLength = 255;
            this.gameTxtBox.Name = "gameTxtBox";
            this.gameTxtBox.Size = new System.Drawing.Size(407, 30);
            this.gameTxtBox.TabIndex = 1;
            this.gameTxtBox.Text = "Name of game";
            this.gameTxtBox.Click += new System.EventHandler(this.gameTxtBox_Click);
            this.gameTxtBox.Enter += new System.EventHandler(this.gameTxtBox_Enter);
            this.gameTxtBox.Leave += new System.EventHandler(this.gameTxtBox_Leave);
            this.gameTxtBox.MouseEnter += new System.EventHandler(this.gameTxtBox_MouseEnter);
            this.gameTxtBox.MouseLeave += new System.EventHandler(this.gameTxtBox_MouseLeave);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.gamePanel.Location = new System.Drawing.Point(52, 169);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(407, 6);
            this.gamePanel.TabIndex = 3;
            // 
            // descrpTxtBox
            // 
            this.descrpTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.descrpTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descrpTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descrpTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descrpTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.descrpTxtBox.Location = new System.Drawing.Point(49, 237);
            this.descrpTxtBox.Multiline = true;
            this.descrpTxtBox.Name = "descrpTxtBox";
            this.descrpTxtBox.Size = new System.Drawing.Size(407, 137);
            this.descrpTxtBox.TabIndex = 2;
            this.descrpTxtBox.Text = "Description";
            this.descrpTxtBox.Click += new System.EventHandler(this.descrpTxtBox_Click);
            this.descrpTxtBox.Enter += new System.EventHandler(this.descrpTxtBox_Enter);
            this.descrpTxtBox.Leave += new System.EventHandler(this.descrpTxtBox_Leave);
            this.descrpTxtBox.MouseEnter += new System.EventHandler(this.descrpTxtBox_MouseEnter);
            this.descrpTxtBox.MouseLeave += new System.EventHandler(this.descrpTxtBox_MouseLeave);
            // 
            // descrpPanel
            // 
            this.descrpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.descrpPanel.Location = new System.Drawing.Point(52, 374);
            this.descrpPanel.Name = "descrpPanel";
            this.descrpPanel.Size = new System.Drawing.Size(407, 6);
            this.descrpPanel.TabIndex = 3;
            // 
            // planToPlayRadioBttn
            // 
            this.planToPlayRadioBttn.AutoSize = true;
            this.planToPlayRadioBttn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.planToPlayRadioBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.planToPlayRadioBttn.Location = new System.Drawing.Point(625, 180);
            this.planToPlayRadioBttn.Name = "planToPlayRadioBttn";
            this.planToPlayRadioBttn.Size = new System.Drawing.Size(146, 34);
            this.planToPlayRadioBttn.TabIndex = 3;
            this.planToPlayRadioBttn.TabStop = true;
            this.planToPlayRadioBttn.Text = "Plan to play";
            this.planToPlayRadioBttn.UseVisualStyleBackColor = true;
            this.planToPlayRadioBttn.CheckedChanged += new System.EventHandler(this.planToPlayRadioBttn_CheckedChanged);
            // 
            // playingRadioButton
            // 
            this.playingRadioButton.AutoSize = true;
            this.playingRadioButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playingRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.playingRadioButton.Location = new System.Drawing.Point(625, 240);
            this.playingRadioButton.Name = "playingRadioButton";
            this.playingRadioButton.Size = new System.Drawing.Size(103, 34);
            this.playingRadioButton.TabIndex = 4;
            this.playingRadioButton.TabStop = true;
            this.playingRadioButton.Text = "Playing";
            this.playingRadioButton.UseVisualStyleBackColor = true;
            this.playingRadioButton.CheckedChanged += new System.EventHandler(this.playingRadioButton_CheckedChanged);
            // 
            // playedRadioButton
            // 
            this.playedRadioButton.AutoSize = true;
            this.playedRadioButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playedRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.playedRadioButton.Location = new System.Drawing.Point(625, 300);
            this.playedRadioButton.Name = "playedRadioButton";
            this.playedRadioButton.Size = new System.Drawing.Size(98, 34);
            this.playedRadioButton.TabIndex = 5;
            this.playedRadioButton.TabStop = true;
            this.playedRadioButton.Text = "Played";
            this.playedRadioButton.UseVisualStyleBackColor = true;
            this.playedRadioButton.CheckedChanged += new System.EventHandler(this.playedRadioButton_CheckedChanged);
            // 
            // customButton1
            // 
            this.customButton1.BorderColor = System.Drawing.Color.White;
            this.customButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(49, 471);
            this.customButton1.Name = "customButton1";
            this.customButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.customButton1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.customButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.customButton1.Size = new System.Drawing.Size(168, 74);
            this.customButton1.TabIndex = 6;
            this.customButton1.Text = "Add Game";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = true;
            // 
            // AddGameUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.playedRadioButton);
            this.Controls.Add(this.playingRadioButton);
            this.Controls.Add(this.planToPlayRadioBttn);
            this.Controls.Add(this.descrpPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.descrpTxtBox);
            this.Controls.Add(this.gameTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "AddGameUserControl";
            this.Size = new System.Drawing.Size(1000, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox gameTxtBox;
        private Panel gamePanel;
        private TextBox descrpTxtBox;
        private Panel descrpPanel;
        private RadioButton planToPlayRadioBttn;
        private RadioButton playingRadioButton;
        private RadioButton playedRadioButton;
        private Components.CustomButton customButton1;
    }
}

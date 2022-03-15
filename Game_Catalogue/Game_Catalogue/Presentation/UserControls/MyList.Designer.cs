namespace Game_Catalogue.Presentation
{
    partial class MyListUserControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateButton = new Game_Catalogue.Presentation.Components.CustomButton();
            this.gameTxtBox = new System.Windows.Forms.TextBox();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.descrpTxtBox = new System.Windows.Forms.TextBox();
            this.descpPanel = new System.Windows.Forms.Panel();
            this.playedRadioButton = new System.Windows.Forms.RadioButton();
            this.playingRadioButton = new System.Windows.Forms.RadioButton();
            this.planToPlayRadioBttn = new System.Windows.Forms.RadioButton();
            this.delButton1 = new Game_Catalogue.Presentation.Components.CustomButton();
            this.addButton1 = new Game_Catalogue.Presentation.Components.CustomButton();
            this.flatCombo1 = new Game_Catalogue.Presentation.Components.FlatCombo();
            this.gameCatalogueContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameCatalogueContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameCatalogueContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameCatalogueContextBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameName,
            this.gameDescription,
            this.gameGenre,
            this.gameState,
            this.gameImage});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.dataGridView1.Location = new System.Drawing.Point(241, 51);
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
            this.dataGridView1.Size = new System.Drawing.Size(884, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // gameName
            // 
            this.gameName.DataPropertyName = "name";
            this.gameName.HeaderText = "Name";
            this.gameName.MinimumWidth = 6;
            this.gameName.Name = "gameName";
            this.gameName.Width = 115;
            // 
            // gameDescription
            // 
            this.gameDescription.DataPropertyName = "opinion";
            this.gameDescription.HeaderText = "Description";
            this.gameDescription.MinimumWidth = 6;
            this.gameDescription.Name = "gameDescription";
            this.gameDescription.Width = 115;
            // 
            // gameGenre
            // 
            this.gameGenre.HeaderText = "Genre";
            this.gameGenre.MinimumWidth = 6;
            this.gameGenre.Name = "gameGenre";
            this.gameGenre.Width = 115;
            // 
            // gameState
            // 
            this.gameState.DataPropertyName = "state";
            this.gameState.HeaderText = "State";
            this.gameState.MinimumWidth = 6;
            this.gameState.Name = "gameState";
            this.gameState.Width = 115;
            // 
            // gameImage
            // 
            this.gameImage.DataPropertyName = "image";
            this.gameImage.HeaderText = "Image";
            this.gameImage.MinimumWidth = 6;
            this.gameImage.Name = "gameImage";
            this.gameImage.Width = 115;
            // 
            // updateButton
            // 
            this.updateButton.BorderColor = System.Drawing.Color.White;
            this.updateButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.updateButton.Enabled = false;
            this.updateButton.FlatAppearance.BorderSize = 0;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(316, 500);
            this.updateButton.Name = "updateButton";
            this.updateButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.updateButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.updateButton.OnHoverTextColor = System.Drawing.Color.White;
            this.updateButton.Size = new System.Drawing.Size(168, 74);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.TextColor = System.Drawing.Color.White;
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // gameTxtBox
            // 
            this.gameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.gameTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gameTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.gameTxtBox.Location = new System.Drawing.Point(25, 51);
            this.gameTxtBox.MaxLength = 255;
            this.gameTxtBox.Name = "gameTxtBox";
            this.gameTxtBox.Size = new System.Drawing.Size(200, 30);
            this.gameTxtBox.TabIndex = 8;
            this.gameTxtBox.Text = "Edit name";
            this.gameTxtBox.Click += new System.EventHandler(this.gameTxtBox_Click);
            this.gameTxtBox.TextChanged += new System.EventHandler(this.gameTxtBox_TextChanged);
            this.gameTxtBox.Enter += new System.EventHandler(this.gameTxtBox_Enter);
            this.gameTxtBox.Leave += new System.EventHandler(this.gameTxtBox_Leave);
            this.gameTxtBox.MouseEnter += new System.EventHandler(this.gameTxtBox_MouseEnter);
            this.gameTxtBox.MouseLeave += new System.EventHandler(this.gameTxtBox_MouseLeave);
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.gamePanel.Location = new System.Drawing.Point(25, 85);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(201, 6);
            this.gamePanel.TabIndex = 9;
            // 
            // descrpTxtBox
            // 
            this.descrpTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.descrpTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descrpTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.descrpTxtBox.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descrpTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.descrpTxtBox.Location = new System.Drawing.Point(25, 134);
            this.descrpTxtBox.Multiline = true;
            this.descrpTxtBox.Name = "descrpTxtBox";
            this.descrpTxtBox.Size = new System.Drawing.Size(201, 126);
            this.descrpTxtBox.TabIndex = 10;
            this.descrpTxtBox.Text = "Edit description";
            this.descrpTxtBox.Click += new System.EventHandler(this.descrpTxtBox_Click);
            this.descrpTxtBox.Enter += new System.EventHandler(this.descrpTxtBox_Enter);
            this.descrpTxtBox.Leave += new System.EventHandler(this.descrpTxtBox_Leave);
            this.descrpTxtBox.MouseEnter += new System.EventHandler(this.descrpTxtBox_MouseEnter);
            this.descrpTxtBox.MouseLeave += new System.EventHandler(this.descrpTxtBox_MouseLeave);
            // 
            // descpPanel
            // 
            this.descpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.descpPanel.Location = new System.Drawing.Point(25, 266);
            this.descpPanel.Name = "descpPanel";
            this.descpPanel.Size = new System.Drawing.Size(201, 6);
            this.descpPanel.TabIndex = 10;
            // 
            // playedRadioButton
            // 
            this.playedRadioButton.AutoSize = true;
            this.playedRadioButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playedRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.playedRadioButton.Location = new System.Drawing.Point(25, 440);
            this.playedRadioButton.Name = "playedRadioButton";
            this.playedRadioButton.Size = new System.Drawing.Size(98, 34);
            this.playedRadioButton.TabIndex = 13;
            this.playedRadioButton.TabStop = true;
            this.playedRadioButton.Text = "Played";
            this.playedRadioButton.UseVisualStyleBackColor = true;
            // 
            // playingRadioButton
            // 
            this.playingRadioButton.AutoSize = true;
            this.playingRadioButton.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playingRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.playingRadioButton.Location = new System.Drawing.Point(25, 398);
            this.playingRadioButton.Name = "playingRadioButton";
            this.playingRadioButton.Size = new System.Drawing.Size(103, 34);
            this.playingRadioButton.TabIndex = 12;
            this.playingRadioButton.TabStop = true;
            this.playingRadioButton.Text = "Playing";
            this.playingRadioButton.UseVisualStyleBackColor = true;
            // 
            // planToPlayRadioBttn
            // 
            this.planToPlayRadioBttn.AutoSize = true;
            this.planToPlayRadioBttn.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.planToPlayRadioBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.planToPlayRadioBttn.Location = new System.Drawing.Point(25, 356);
            this.planToPlayRadioBttn.Name = "planToPlayRadioBttn";
            this.planToPlayRadioBttn.Size = new System.Drawing.Size(146, 34);
            this.planToPlayRadioBttn.TabIndex = 11;
            this.planToPlayRadioBttn.TabStop = true;
            this.planToPlayRadioBttn.Text = "Plan to play";
            this.planToPlayRadioBttn.UseVisualStyleBackColor = true;
            // 
            // delButton1
            // 
            this.delButton1.BorderColor = System.Drawing.Color.White;
            this.delButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.delButton1.Enabled = false;
            this.delButton1.FlatAppearance.BorderSize = 0;
            this.delButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delButton1.ForeColor = System.Drawing.Color.White;
            this.delButton1.Location = new System.Drawing.Point(511, 500);
            this.delButton1.Name = "delButton1";
            this.delButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.delButton1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.delButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.delButton1.Size = new System.Drawing.Size(168, 74);
            this.delButton1.TabIndex = 14;
            this.delButton1.Text = "Delete";
            this.delButton1.TextColor = System.Drawing.Color.White;
            this.delButton1.UseVisualStyleBackColor = true;
            // 
            // addButton1
            // 
            this.addButton1.BorderColor = System.Drawing.Color.White;
            this.addButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.addButton1.Enabled = false;
            this.addButton1.FlatAppearance.BorderSize = 0;
            this.addButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton1.ForeColor = System.Drawing.Color.White;
            this.addButton1.Location = new System.Drawing.Point(704, 500);
            this.addButton1.Name = "addButton1";
            this.addButton1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.addButton1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(142)))));
            this.addButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.addButton1.Size = new System.Drawing.Size(168, 74);
            this.addButton1.TabIndex = 15;
            this.addButton1.Text = "Add";
            this.addButton1.TextColor = System.Drawing.Color.White;
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // flatCombo1
            // 
            this.flatCombo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.flatCombo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(167)))), ((int)(((byte)(198)))));
            this.flatCombo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatCombo1.Font = new System.Drawing.Font("Segoe UI", 13.09091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatCombo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(183)))));
            this.flatCombo1.FormattingEnabled = true;
            this.flatCombo1.Location = new System.Drawing.Point(25, 302);
            this.flatCombo1.Name = "flatCombo1";
            this.flatCombo1.Size = new System.Drawing.Size(200, 38);
            this.flatCombo1.TabIndex = 16;
            // 
            // gameCatalogueContextBindingSource
            // 
            this.gameCatalogueContextBindingSource.DataSource = typeof(Game_Data.GameCatalogueContext);
            // 
            // gameCatalogueContextBindingSource1
            // 
            this.gameCatalogueContextBindingSource1.DataSource = typeof(Game_Data.GameCatalogueContext);
            // 
            // MyListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.flatCombo1);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.delButton1);
            this.Controls.Add(this.playedRadioButton);
            this.Controls.Add(this.playingRadioButton);
            this.Controls.Add(this.planToPlayRadioBttn);
            this.Controls.Add(this.descpPanel);
            this.Controls.Add(this.descrpTxtBox);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.gameTxtBox);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyListUserControl";
            this.Size = new System.Drawing.Size(1147, 600);
            this.Load += new System.EventHandler(this.MyListUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameCatalogueContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameCatalogueContextBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Components.CustomButton updateButton;
        private TextBox gameTxtBox;
        private Panel gamePanel;
        private TextBox descrpTxtBox;
        private Panel descpPanel;
        private RadioButton playedRadioButton;
        private RadioButton playingRadioButton;
        private RadioButton planToPlayRadioBttn;
        private Components.CustomButton delButton1;
        private Components.CustomButton addButton1;
        private Components.FlatCombo flatCombo1;
        private BindingSource gameCatalogueContextBindingSource;
        private BindingSource gameCatalogueContextBindingSource1;
        private DataGridViewTextBoxColumn gameName;
        private DataGridViewTextBoxColumn gameDescription;
        private DataGridViewTextBoxColumn gameGenre;
        private DataGridViewTextBoxColumn gameState;
        private DataGridViewTextBoxColumn gameImage;
    }
}

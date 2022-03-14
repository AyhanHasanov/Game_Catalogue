using Game_Catalogue.Businesss;
using Game_Data;
using Game_Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Catalogue.Presentation
{
    public partial class MyListUserControl : UserControl
    {
        public MyListUserControl()
        {
            InitializeComponent();
        }

        public static bool addGameVisible = false;

        Color activePanelColor = Color.FromArgb(245, 87, 142);
        Color inactivePanelColor = Color.FromArgb(245, 167, 198);
        Color activeTextColor = Color.FromArgb(247, 247, 247);
        Color inactiveTextColor = Color.FromArgb(150, 142, 183);


        private void addButton1_Click(object sender, EventArgs e)
        {
            addGameVisible = true;  
        }

        private void MyListUserControl_Load(object sender, EventArgs e)
        {
            //Filling the comboBox with genres from the database
            Genre_Logic genre_Logic = new Genre_Logic();
            int end = genre_Logic.GetCount();
            for (int i = 1; i <= end; i++)
            {
                Genre genre = genre_Logic.GetGenre(i);
                if (genre != null)
                    flatCombo1.Items.Add(genre.Name.ToString());
            }

            LoadDataGridRecords();
        }

        private void gameTxtBox_Click(object sender, EventArgs e)
        {
            if (gameTxtBox.Text == "Name of game")
            {
                gameTxtBox.Text = "";
                gameTxtBox.ForeColor = activeTextColor;
            }
        }

        private void gameTxtBox_MouseEnter(object sender, EventArgs e)
        {
            gamePanel.BackColor = activePanelColor;
        }

        private void gameTxtBox_MouseLeave(object sender, EventArgs e)
        {
            gamePanel.BackColor = inactivePanelColor;
        }

        private void gameTxtBox_Enter(object sender, EventArgs e)
        {
            if (gameTxtBox.Text == "Edit name")
            {
                gameTxtBox.Text = "";
                gameTxtBox.ForeColor = activeTextColor;
            }
            gamePanel.BackColor = activePanelColor;
        }

        private void gameTxtBox_Leave(object sender, EventArgs e)
        { 
            if (gameTxtBox.Text == "")
            {
                gameTxtBox.Text = "Edit name";
                gameTxtBox.ForeColor = inactiveTextColor;
            }
            gamePanel.BackColor = inactivePanelColor;
        }
  
        private void descrpTxtBox_Click(object sender, EventArgs e)
        {
            if (descrpTxtBox.Text == "Edit descriptoin")
            {
                descrpTxtBox.ForeColor = activeTextColor;
                descrpTxtBox.Text = "";
            }
        }

        private void descrpTxtBox_MouseEnter(object sender, EventArgs e)
        {
            descpPanel.BackColor = activePanelColor;
        }

        private void descrpTxtBox_MouseLeave(object sender, EventArgs e)
        {
            descpPanel.BackColor = inactivePanelColor;
        }

        private void descrpTxtBox_Enter(object sender, EventArgs e)
        {
            if(descrpTxtBox.Text == "Edit description") 
            {
                descrpTxtBox.Text = "";
                descrpTxtBox.ForeColor= activeTextColor;
            }
            descpPanel.BackColor = activePanelColor;
        }

        private void descrpTxtBox_Leave(object sender, EventArgs e)
        {
            if (descrpTxtBox.Text == "")
            {
                descrpTxtBox.Text = "Edit description";
                descrpTxtBox.ForeColor = inactiveTextColor;
            }
            descpPanel.BackColor = activePanelColor;
        }

        void LoadDataGridRecords()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (GameCatalogueContext context = new GameCatalogueContext())
            {
                dataGridView1.DataSource = context.Games.ToList<Game>();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void gameTxtBox_TextChanged(object sender, EventArgs e)
        {
            addButton1.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Model;
using System.IO;
using Data;
using System.Data.SqlClient;
using Game_Catalogue.Business;

namespace Game_Catalogue.Presentation.UserControls
{
    public partial class AddGameUserControl : UserControl
    {
        public AddGameUserControl()
        {
            InitializeComponent();
        }

        Color activePanelColor = Color.FromArgb(245, 87, 142);
        Color inactivePanelColor = Color.FromArgb(245, 167, 198);
        Color activeTextColor = Color.FromArgb(247, 247, 247);
        Color inactiveTextColor = Color.FromArgb(150, 142, 183);

        GameCatalogueContext gameCatalogue = new GameCatalogueContext();
        Game_Logic addGame_Logic = new Game_Logic();
        UsersGame_Logic usersGame_Logic = new UsersGame_Logic();
        User_Logic users_Logic = new User_Logic();

        /// <summary>
        /// Adding game to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customButton1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                if (imgLocation != "")
                {
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(stream);
                    images = binaryReader.ReadBytes((int)stream.Length);
                }

                int genreId = flatCombo1.SelectedIndex + 1;
                Game game = new Game();

                game.Name = gameTxtBox.Text;
                game.Opinion = descrpTxtBox.Text;
                game.IdGenre = genreId;

                if (planToPlayRadioBttn.Checked == true)
                {
                    game.State = "Plan to play";
                }
                else if (playingRadioButton.Checked == true)
                {
                    game.State = "Playing";
                }
                else if (playedRadioButton.Checked == true)
                {
                    game.State = "Played";
                }

                game.Image = images;

                int userID = -1;
                using (var reader = new StreamReader("username.txt"))
                {
                    string username = reader.ReadToEnd().Trim()
                        .Replace("\r", "").Replace("\n", "").ToString();
                    userID = users_Logic.GetUserByUsername(username).Id;
                }

                addGame_Logic.Add(game);

                UsersGame ug = new UsersGame();
                ug.UserId = userID;
                ug.GameId = game.IdGame;
                usersGame_Logic.Add(ug);

                MessageBox.Show("Added game successfuly! :)");

            }
            catch (Exception)
            {
                MessageBox.Show("Failed adding game! :(");
            }
        }

        string imgLocation = "";

        /// <summary>
        /// Browsing images
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void customButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void AddGameUserControl_Load(object sender, EventArgs e)
        {
            //Filling the comboBox with genres from the database
            Genre_Logic genre_Logic = new Genre_Logic();
            int end = genre_Logic.GetCount();
            for (int i = 1; i <= end; i++)
            {
                Genre genre = genre_Logic.GetGenre(i);
                if (genre != null)
                    flatCombo1.Items.Add(genre.GenreName.ToString());
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

        private void gameTxtBox_Click(object sender, EventArgs e)
        {
            if (gameTxtBox.Text == "Name of game")
            {
                gameTxtBox.Text = "";
                gameTxtBox.ForeColor = activeTextColor;
            }
        }
        private void gameTxtBox_Enter(object sender, EventArgs e)
        {
            if (gameTxtBox.Text == "Name of game")
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
                gameTxtBox.Text = "Name of game";
                gameTxtBox.ForeColor = inactiveTextColor;
            }
            gamePanel.BackColor = inactivePanelColor;
        }

        // DESCRIPTION TEXT BOX
        private void descrpTxtBox_MouseEnter(object sender, EventArgs e)
        {
            descrpPanel.BackColor = activePanelColor;
        }

        private void descrpTxtBox_MouseLeave(object sender, EventArgs e)
        {
            descrpPanel.BackColor = inactivePanelColor;
        }

        private void descrpTxtBox_Click(object sender, EventArgs e)
        {
            if (descrpTxtBox.Text == "Description")
            {
                descrpTxtBox.Text = "";
                descrpTxtBox.ForeColor = activeTextColor;
            }
        }

        private void descrpTxtBox_Enter(object sender, EventArgs e)
        {
            if (descrpTxtBox.Text == "Description")
            {
                descrpTxtBox.Text = "";
                descrpTxtBox.ForeColor = activeTextColor;
            }
            descrpPanel.BackColor = activePanelColor;
        }

        private void descrpTxtBox_Leave(object sender, EventArgs e)
        {
            if (descrpTxtBox.Text == "")
            {
                descrpTxtBox.Text = "Description";
                descrpTxtBox.ForeColor = inactiveTextColor;
            }
            descrpPanel.BackColor = inactivePanelColor;
        }

        private void planToPlayRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (planToPlayRadioBttn.Checked)
                planToPlayRadioBttn.ForeColor = activeTextColor;
            else
                planToPlayRadioBttn.ForeColor = inactiveTextColor;
        }

        private void playingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (playingRadioButton.Checked)
                playingRadioButton.ForeColor = activeTextColor;
            else
                playingRadioButton.ForeColor = inactiveTextColor;
        }

        private void playedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (playedRadioButton.Checked)
                playedRadioButton.ForeColor = activeTextColor;
            else
                playedRadioButton.ForeColor = inactiveTextColor;
        }


    }
}

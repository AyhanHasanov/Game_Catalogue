﻿using Data;
using Data.Model;
using Game_Catalogue.Business;
using System.Data;
using System.Data.SqlClient;

namespace Game_Catalogue.Presentation
{
    /// <summary>
    /// UI
    /// </summary> />
    public partial class HomePage : Form
    {

        /// <summary>
        /// Database Context
        /// </summary>
        private GameCatalogueContext games = new GameCatalogueContext();

        bool addGame = MyListUserControl.addGameVisible;

        Color activePanelColor = Color.FromArgb(245, 87, 142);
        Color inactivePanelColor = Color.FromArgb(245, 167, 198);
        Color activeTextColor = Color.FromArgb(247, 247, 247);
        Color inactiveTextColor = Color.FromArgb(150, 142, 183);

        GameCatalogueContext gameCatalogue = new GameCatalogueContext();
        Game_Logic game_Logic = new Game_Logic();
        UsersGame_Logic usersGame_Logic = new UsersGame_Logic();
        User_Logic users_Logic = new User_Logic();
        User currentUser = new User();


        /// <summary>
        ///  Constructor
        /// </summary>
        public HomePage()
        {
            InitializeComponent();
        }


        //  CLOSE AND MINIMIZE BUTTON ANIMATIONS 

        /// <summary>
        /// Handles the Click event of the closeBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void closeBox_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void closeBox_MouseEnter(object sender, EventArgs e)
        {
            IncreasePictureBoxSize(closeBox);
        }

        private void closeBox_MouseLeave(object sender, EventArgs e)
        {
            DecreasePictureBoxSize(closeBox);
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeBox_MouseEnter(object sender, EventArgs e)
        {
            IncreasePictureBoxSize(minimizeBox);
        }

        private void minimizeBox_MouseLeave(object sender, EventArgs e)
        {
            DecreasePictureBoxSize(minimizeBox);
        }

        private void IncreasePictureBoxSize(PictureBox pB)
        {
            pB.Height = 30;
            pB.Width = 30;
            pB.Location = new Point(pB.Location.X - 5, pB.Location.Y - 5);
        }

        private void DecreasePictureBoxSize(PictureBox pB)
        {
            pB.Height = 25;
            pB.Width = 25;
            pB.Location = new Point(pB.Location.X + 5, pB.Location.Y + 5);
        }



        private void HomePage_Load(object sender, EventArgs e)
        {
            this.Draggable(true);
            addGamePanel.Visible = false;
            myProfilePanel.Visible = true;
            myListPanel.Visible = false;
            timer1.Start();

            Genre_Logic genre_Logic = new Genre_Logic();
            int end = genre_Logic.GetCount();
            for (int i = 1; i <= end; i++)
            {
                Genre genre = genre_Logic.GetGenre(i);
                if (genre != null)
                {
                    genresAGCombo.Items.Add(genre.GenreName.ToString());
                    genresMLCombo.Items.Add(genre.GenreName.ToString());
                }
            }

            editNameMLBttn.Enabled = false;
            editDescriptionMLBttn.Enabled = false;
            genresMLCombo.Enabled = false;
            planToPlayMLBttn.Enabled = false;
            playedMLButton.Enabled = false;
            playingMLButton.Enabled = false;
            updateBttn.Enabled = false;
            deleteBttn.Enabled = false;

            currentUser = users_Logic.GetUserFromTxtFile();
            LoadMyProfileInfo();
        }


        // Menu bttns and manipulation
        private void myListBttn_Click(object sender, EventArgs e)
        {

            addGamePanel.Visible = false;
            myProfilePanel.Visible = false;
            myListPanel.Visible = true;
            LoadDataGridRecords();

        }

        private void addGamePageBttn_Click(object sender, EventArgs e)
        {
            addGamePanel.Visible = true;
            myProfilePanel.Visible = false;
            myListPanel.Visible = false;
        }

        private void myProfileBttn_Click(object sender, EventArgs e)
        {
            addGamePanel.Visible = false;
            myProfilePanel.Visible = true;
            myListPanel.Visible = false;
            LoadMyProfileInfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM");
        }


        // My List Buttons
        private void updateBttn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {

        }

        private void addBttn_Click(object sender, EventArgs e)
        {

        }


        // Add Game Panel Methods
        string imgLocation = "";
        private void addGameBttn_Click(object sender, EventArgs e)
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

                int genreId = genresAGCombo.SelectedIndex + 1;
                Game game = new Game();

                game.Name = nameAGTxtBox.Text;
                game.Opinion = descrpAGTxtBox.Text;
                game.IdGenre = genreId;

                if (planToPlayAGRadioBttn.Checked == true)
                {
                    game.State = "Plan to play";
                }
                else if (playingAGRadioButton.Checked == true)
                {
                    game.State = "Playing";
                }
                else if (playedAGRadioButton.Checked == true)
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

                game_Logic.Add(game);

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

        public void LoadDataGridRecords()
        {
            dataGridView1.AutoGenerateColumns = false;
            using (GameCatalogueContext context = new GameCatalogueContext())
            {

                /*var gamesList = from userGames in context.UsersGames
                                join games in context.Games on userGames.GameId equals games.IdGame
                                join genre in context.Genres on games.IdGenre equals genre.IdGenre
                                select new
                                {
                                    UserId = userGames.UserId,
                                    Name = games.Name,
                                    Opinion = games.Opinion,
                                    Genre = genre.GenreName,
                                    State = games.State,
                                    Image = games.Image
                                };

                var list = gamesList.ToList().Where(u => u.UserId.Equals(currentUser.Id));
                dataGridView1.DataSource = list;*/

                var conn = DataBase.GetConnection();
                conn.Open();
                using (conn)
                {
                    /*SqlDataAdapter commmand = new SqlDataAdapter(
                        $"SELECT Games.name, games.opinion, genres.name, games.state, games.image " +
                        $"FROM Games " +
                        $"JOIN Genres on games.id_genre = genres.id_genre " +
                        $"Where Games.id_game IN(SELECT Users_games.game_id FROM Users_games Where Users_games.user_id = {this.currentUser.Id})", conn);
                    
                    DataTable gameTable = new DataTable();
                    commmand.Fill(gameTable);
                    dataGridView2.DataSource = gameTable;*/

                    string sql = $"SELECT Users_games.user_id, Games.name, Games.opinion, Genres.name, Games.state, Games.image " +
                                      $"FROM Users_games " +
                                      $"JOIN Games on Users_games.game_id = Games.id_game " +
                                      $"JOIN Genres on Games.id_genre = Genres.id_genre " +
                                      $"WHERE Users_games.user_id = {this.currentUser.Id} ";

                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    using (reader)
                    {
                        int user_id = (int)reader["Id"];
                        string game_name = (string)reader["Name"];
                        string game_opinion = (string)reader["Opinion"];
                        string genre = (string)reader["Name"];
                        string state = (string)reader["State"];
                        Image image = (Image)reader["Image"];

                    }
                }

                //dataGridView1.DataSource = list;
            }
        }


        public void LoadMyProfileInfo()
        {
            myProfileName.Text = currentUser.Username;
            myProfileJoined.Text = currentUser.CreatedAt.ToString();
            int count = usersGame_Logic.GetAllGamesForCurrentUser(currentUser).Count;
            myProfileCount.Text = count.ToString();
        }
        private void browsePic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox2.ImageLocation = imgLocation;
            }
        }

        private void nameAGTxtBox_Click(object sender, EventArgs e)
        {
            if (nameAGTxtBox.Text == "Name of game")
            {
                nameAGTxtBox.Text = "";
                nameAGTxtBox.ForeColor = activeTextColor;
            }

        }

        private void nameAGTxtBox_Enter(object sender, EventArgs e)
        {
            if (nameAGTxtBox.Text == "Name of game")
            {
                nameAGTxtBox.Text = "";
                nameAGTxtBox.ForeColor = activeTextColor;
            }
            gamePanel.BackColor = activePanelColor;

        }

        private void nameAGTxtBox_Leave(object sender, EventArgs e)
        {
            if (nameAGTxtBox.Text == "")
            {
                nameAGTxtBox.Text = "Name of game";
                nameAGTxtBox.ForeColor = inactiveTextColor;
            }
            gamePanel.BackColor = inactivePanelColor;

        }

        private void nameAGTxtBox_MouseEnter(object sender, EventArgs e)
        {
            gamePanel.BackColor = activePanelColor;
        }

        private void nameAGTxtBox_MouseLeave(object sender, EventArgs e)
        {
            gamePanel.BackColor = inactivePanelColor;

        }


        // DESCRIPTION TEXT BOX
        private void descrpAGTxtBox_Click(object sender, EventArgs e)
        {
            if (descrpAGTxtBox.Text == "Description")
            {
                descrpAGTxtBox.Text = "";
                descrpAGTxtBox.ForeColor = activeTextColor;
            }
        }

        private void descrpAGTxtBox_Enter(object sender, EventArgs e)
        {
            if (descrpAGTxtBox.Text == "Description")
            {
                descrpAGTxtBox.Text = "";
                descrpAGTxtBox.ForeColor = activeTextColor;
            }
            descrpPanel.BackColor = activePanelColor;
        }

        private void descrpAGTxtBox_Leave(object sender, EventArgs e)
        {
            if (descrpAGTxtBox.Text == "")
            {
                descrpAGTxtBox.Text = "Description";
                descrpAGTxtBox.ForeColor = inactiveTextColor;
            }
            descrpPanel.BackColor = inactivePanelColor;
        }

        private void descrpAGTxtBox_MouseEnter(object sender, EventArgs e)
        {

            descrpPanel.BackColor = activePanelColor;
        }

        private void descrpAGTxtBox_MouseLeave(object sender, EventArgs e)
        {
            descrpPanel.BackColor = inactivePanelColor;

        }

        private void descrpTxtBox_MouseEnter(object sender, EventArgs e)
        {
            descrpPanel.BackColor = activePanelColor;
        }

        private void descrpTxtBox_MouseLeave(object sender, EventArgs e)
        {
            descrpPanel.BackColor = inactivePanelColor;
        }

        // Radio Buttons Animation on Add Game 

        private void planToPlayAGRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (planToPlayAGRadioBttn.Checked)
                planToPlayAGRadioBttn.ForeColor = activeTextColor;
            else
                planToPlayAGRadioBttn.ForeColor = inactiveTextColor;
        }

        private void playingAGRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (playingAGRadioButton.Checked)
                playingAGRadioButton.ForeColor = activeTextColor;
            else
                playingAGRadioButton.ForeColor = inactiveTextColor;
        }

        private void playedAGRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (playedAGRadioButton.Checked)
                playedAGRadioButton.ForeColor = activeTextColor;
            else
                playedAGRadioButton.ForeColor = inactiveTextColor;
        }


        //  My List Animations

        private void editNameMLBttn_Click(object sender, EventArgs e)
        {
            if (editNameMLBttn.Text == "Edit name")
            {
                editNameMLBttn.Text = "";
                editNameMLBttn.ForeColor = activeTextColor;
            }
        }

        private void editNameMLBttn_Enter(object sender, EventArgs e)
        {

            if (editNameMLBttn.Text == "Edit name")
            {
                editNameMLBttn.Text = "";
                editNameMLBttn.ForeColor = activeTextColor;
            }
            panel4.BackColor = activePanelColor;
        }

        private void editNameMLBttn_Leave(object sender, EventArgs e)
        {
            if (editNameMLBttn.Text == "")
            {
                editNameMLBttn.Text = "Edit name";
                editNameMLBttn.ForeColor = inactiveTextColor;
            }
            panel4.BackColor = inactivePanelColor;
        }

        private void editNameMLBttn_MouseEnter(object sender, EventArgs e)
        {
            panel4.BackColor = activePanelColor;
        }

        private void editNameMLBttn_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = inactivePanelColor;
        }

        private void editDescriptionMLBttn_Click(object sender, EventArgs e)
        {
            if (editDescriptionMLBttn.Text == "Edit descriptoin")
            {
                editDescriptionMLBttn.ForeColor = activeTextColor;
                editDescriptionMLBttn.Text = "";
            }
        }

        private void editDescriptionMLBttn_Enter(object sender, EventArgs e)
        {
            if (editDescriptionMLBttn.Text == "Edit description")
            {
                editDescriptionMLBttn.Text = "";
                editDescriptionMLBttn.ForeColor = activeTextColor;
            }
            descpPanel.BackColor = activePanelColor;
        }

        private void editDescriptionMLBttn_Leave(object sender, EventArgs e)
        {
            if (editDescriptionMLBttn.Text == "")
            {
                editDescriptionMLBttn.Text = "Edit description";
                editDescriptionMLBttn.ForeColor = inactiveTextColor;
            }
            descpPanel.BackColor = activePanelColor;
        }

        private void editDescriptionMLBttn_MouseEnter(object sender, EventArgs e)
        {
            descpPanel.BackColor = activePanelColor;
        }

        private void editDescriptionMLBttn_MouseLeave(object sender, EventArgs e)
        {
            descpPanel.BackColor = inactivePanelColor;
        }

    }
}

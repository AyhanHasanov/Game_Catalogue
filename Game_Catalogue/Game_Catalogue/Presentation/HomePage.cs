using Data;
using Data.Model;
using Game_Catalogue.Business;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Game_Catalogue.Presentation
{
    /// <summary>
    /// Form class HomePage
    /// </summary> />
    public partial class HomePage : Form
    {

        /// <summary>
        /// Database Context
        /// </summary>
        private GameCatalogueContext games = new GameCatalogueContext();

        // Colors needed for animation
        Color activePanelColor = Color.FromArgb(245, 87, 142);
        Color inactivePanelColor = Color.FromArgb(245, 167, 198);
        Color activeTextColor = Color.FromArgb(247, 247, 247);
        Color inactiveTextColor = Color.FromArgb(150, 142, 183);

        GameCatalogueContext gameCatalogue = new GameCatalogueContext();
        Game_Logic game_Logic = new Game_Logic();
        UsersGame_Logic usersGame_Logic = new UsersGame_Logic();
        User_Logic users_Logic = new User_Logic();
        User currentUser = new User();
        Genre_Logic genre_Logic = new Genre_Logic();

        /// <summary>
        /// HomePage Constructor
        /// </summary>
        public HomePage()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// HomePage form load method
        /// </summary>
        private void HomePage_Load(object sender, EventArgs e)
        {
            this.Draggable(true);

            // Prefixed visibility of panels
            addGamePanel.Visible = false;
            myProfilePanel.Visible = true;
            myListPanel.Visible = false;
            timer1.Start();

            // Filling combo boxes with genres from database
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

            editNameMLBttn.Visible = false;
            editDescriptionMLBttn.Visible = false;
            genresMLCombo.Visible = false;
            planToPlayMLBttn.Visible = false;
            playedMLButton.Visible = false;
            playingMLButton.Visible = false;
            updateBttn.Visible = false;
            deleteBttn.Visible = false;
            RfrshButt1.Visible = false;

            //Gets the current user and loads user's profile information
            currentUser = users_Logic.GetUserFromTxtFile();
            LoadMyProfileInfo();
        }

        // Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss  dd/MM");
        }

        // Sidebar menu buttons and manipulations
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

            nameAGTxtBox.Text = "Name of game";
            nameAGTxtBox.ForeColor = inactiveTextColor;
            planToPlayAGRadioBttn.Checked = false;
            playingAGRadioButton.Checked = false;
            playedAGRadioButton.Checked = false;
            genresAGCombo.Text = "";
            descrpAGTxtBox.Text = "Description";
            descrpAGTxtBox.ForeColor = inactiveTextColor;
            pictureBox2.Image = null;
        }
        private void myProfileBttn_Click(object sender, EventArgs e)
        {
            addGamePanel.Visible = false;
            myProfilePanel.Visible = true;
            myListPanel.Visible = false;
            LoadMyProfileInfo();
        }


        // My List Buttons

        private int Selected_Index;

        /// <summary>
        /// Updates the information about the user's selected game in the database
        /// </summary>
        private void updateBttn_Click(object sender, EventArgs e)
        {
            //Initializing the variables
            string genre_name = this.genresMLCombo.GetItemText(genresMLCombo.SelectedItem);
            int genreId = genre_Logic.GetGenreIdByName(genre_name);
            string name = editNameMLBttn.Text;
            string description = editDescriptionMLBttn.Text;
            string state = "";

            //Checks the state
            if (planToPlayMLBttn.Checked == true)
            {
                state = "Plan to play";
            }
            else if (playingMLButton.Checked == true)
            {
                state = "Playing";
            }
            else if (playedMLButton.Checked == true)
            {
                state = "Played";
            }

            //Assigns the game's properties
            byte[] currentImage = (byte[])dataGridView1.CurrentRow.Cells[6].Value;
            Game game = new Game();
            game.IdGame = Selected_Index;
            game.Name = name;
            game.Opinion = description;
            game.State = state;
            game.IdGenre = genreId;
            game.Image = currentImage;
            game_Logic.Update(game);

        }

        /// <summary>
        /// Deletes the selected game once the Delete button is clicked
        /// </summary>
        private void deleteBttn_Click(object sender, EventArgs e)
        {
            usersGame_Logic.Delete(currentUser.Id, Selected_Index);
        }

        // DataGrid Methods
        private void LoadDataGridRecords()
        {
            // Establiching a connection to the database
            SqlConnection conn = DataBase.GetConnection();

            //Creating a query, joining UsersGame table with Game table and Genre table
            string query = "select Users_games.user_id, Games.id_game, Games.name, Games.opinion, Genres.name, Games.state, Games.image";
            query += " from [dbo].[Users_games] inner join [dbo].[Games] on Users_games.game_id = Games.id_game";
            query += $" inner join [dbo].[Genres] on Games.id_genre = Genres.id_genre where Users_games.user_id = {currentUser.Id}";

            SqlCommand command = new SqlCommand(query, conn);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable gamesList = new DataTable();
            adapter.Fill(gamesList);
            dataGridView1.DataSource = gamesList;
            conn.Close();

            ChangeDataGridDesign();
        }


        /// <summary>
        /// Fixes the DataGrid's design
        /// </summary>
        private void ChangeDataGridDesign()
        {

            // name1 = genreName
            dataGridView1.Columns["id_game"].Visible = false;
            dataGridView1.Columns["user_id"].Visible = false;
            dataGridView1.Columns["name"].HeaderText = "Game Name";
            dataGridView1.Columns["opinion"].HeaderText = "Opinion / description";
            dataGridView1.Columns["name1"].HeaderText = "Genre";
            dataGridView1.Columns["state"].HeaderText = "State";
            dataGridView1.Columns["image"].HeaderText = "Image";

            dataGridView1.Columns["name"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["opinion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["name1"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["state"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["image"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        // Loads the user's profile info
        private void LoadMyProfileInfo()
        {
            myProfileName.Text = currentUser.Username;
            myProfileJoined.Text = currentUser.CreatedAt.ToString();
            int count = usersGame_Logic.GetAllGamesForCurrentUser(currentUser).Count;
            myProfileCount.Text = count.ToString();
        }



        // Add Game Panel Methods
        string imgLocation = "";

        /// <summary>
        /// When clicking the Add Game button a game is added to the database
        /// </summary>
        private void addGameBttn_Click(object sender, EventArgs e)
        {
            //Check
            try
            {
                byte[] images = null;

                //Converts the image into a file stream and then reads the data
                if (imgLocation != "")
                {
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(stream);
                    images = binaryReader.ReadBytes((int)stream.Length);
                }

                string genre_name = this.genresAGCombo.GetItemText(genresAGCombo.SelectedItem);
                int genreId = genre_Logic.GetGenreIdByName(genre_name);

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

                MessageBox.Show("Added game successfully! :)");

            }
            catch (Exception)
            {
                MessageBox.Show("Failed adding game! :(");
            }
        }

        /// <summary>
        /// When clicking the Browse Pic button the user can input an image
        /// </summary>
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

        Bitmap currentSelectedImage;
        MemoryStream imageStream = new MemoryStream();

        /// <summary>
        /// Fills the textboxes, combobox and checks the radio buttons with the selected game's data
        /// </summary>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count != 0 || dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    var idGame = dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                    Selected_Index = (int)idGame;
                }

                editNameMLBttn.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                editDescriptionMLBttn.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                genresMLCombo.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                string state = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                imageStream = new MemoryStream();
                imageStream = new MemoryStream((byte[])dataGridView1.CurrentRow.Cells[6].Value);


                if (state == "Plan to play")
                {
                    planToPlayMLBttn.Checked = true;
                }
                else if (state == "Playing")
                {
                    playingMLButton.Checked = true;
                }
                else if (state == "Played")
                {
                    playedMLButton.Checked = true;
                }
            }
            catch (Exception ex)
            { 
            }

        }

        /// <summary>
        /// Refreshes the DataGrid
        /// </summary>
        private void RfrshButt1_Click(object sender, EventArgs e)
        {
            LoadDataGridRecords();
        }

        /// <summary>
        /// Views a game's image from a clicked cell
        /// </summary>
        private void viewImageBttn_Click(object sender, EventArgs e)
        {
            if (imageStream.Length != 0)
            {
                PictureVisualizer pV = new PictureVisualizer();
                pV.image = currentSelectedImage;
                pV.stream = imageStream;
                pV.Show();
            }
            else
            {
                MessageBox.Show("There isn't any images added to this game!", "Sorry pal u have dumb :P");
            }
        }

        //  HomePage Controls Animations

        /// <summary>
        /// Closes the form
        /// </summary>
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


        // Add Game Panel Animations

        //name textbox animations
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
        //descr text box animations
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
        //radio buttons animations
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


        //  My List Panel Animations

        //edit name animations
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
        //edit descr animations
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
        /// <summary>
        /// Handles the Click event of the dataGridView1 control.
        /// Fills up all the edit boxes with information from dataGridView1
        /// </summary>
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                editNameMLBttn.Visible = true;
                editDescriptionMLBttn.Visible = true;
                genresMLCombo.Visible = true;
                planToPlayMLBttn.Visible = true;
                playedMLButton.Visible = true;
                playingMLButton.Visible = true;
                updateBttn.Visible = true;
                deleteBttn.Visible = true;
                RfrshButt1.Visible = true;
            }
            else
            {
                editNameMLBttn.Visible = false;
                editDescriptionMLBttn.Visible = false;
                genresMLCombo.Visible = false;
                planToPlayMLBttn.Visible = false;
                playedMLButton.Visible = false;
                playingMLButton.Visible = false;
                updateBttn.Visible = false;
                deleteBttn.Visible = false;
                RfrshButt1.Visible = false;
            }
        }
    }
}




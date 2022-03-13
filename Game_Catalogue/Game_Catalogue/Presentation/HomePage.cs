using Game_Data;
using Game_Data.Model;

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

        /// <summary>
        ///  Constructor
        /// </summary>
        public HomePage()
        {
            InitializeComponent();
        }

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
            addGameUserControl1.Visible = false;
            myListUserControl1.Visible = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            addGameUserControl1.Visible = true;
            myListUserControl1.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            addGameUserControl1.Visible = false;
            myListUserControl1.Visible = true;
        }

        public void ShowAddGame()
        {
            
        }

    }
}

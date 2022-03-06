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



        /// <summary>
        ///  Constructor
        /// </summary>
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

namespace Game_Catalogue.Presentation
{
    /// <summary>
    /// Form class PictureVisualizer
    /// </summary>
    public partial class PictureVisualizer : Form
    {
        /// <summary>
        /// PictureVisualizer constrictor
        /// </summary>
        public PictureVisualizer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the image
        /// </summary>
        public Bitmap image { get; set; }

        /// <summary>
        /// Gets or sets the memory stream
        /// </summary>
        public MemoryStream stream { get; set; }

        /// <summary>
        /// Changes to the picture box when the form loads
        /// </summary>
        private void PictureVisualizer_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Size = this.Size;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromStream(stream);
        }
    }
}

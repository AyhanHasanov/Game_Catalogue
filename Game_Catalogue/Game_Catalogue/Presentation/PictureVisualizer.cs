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
    public partial class PictureVisualizer : Form
    {
        public PictureVisualizer()
        {
            InitializeComponent();
        }

        public Bitmap image { get; set; }

        public MemoryStream stream { get; set; }


        private void PictureVisualizer_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Size = this.Size;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromStream(stream);
        }
    }
}

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

        private void addButton1_Click(object sender, EventArgs e)
        {
            addGameVisible = true;  
        }
    }
}

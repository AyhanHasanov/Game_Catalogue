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
    public partial class LogIn_Form : Form
    {
        public LogIn_Form()
        {
            InitializeComponent();
        }
        Color activePanelColor = Color.FromArgb(245, 87, 142);
        Color inactivePanelColor = Color.FromArgb(245, 167, 198);
        Color activeTextColor = Color.FromArgb(247, 247, 247);
        Color inactiveTextColor = Color.FromArgb(150, 142, 183);

        private void label1_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.ToString();
            string passwornd = password_textbox.ToString();
        }
    }
}

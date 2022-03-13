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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        Color activePanelColor = Color.FromArgb(245, 87, 142);
        Color inactivePanelColor = Color.FromArgb(245, 167, 198);
        Color activeTextColor = Color.FromArgb(247, 247, 247);
        Color inactiveTextColor = Color.FromArgb(150, 142, 183);

        private void Registration_Button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.ToString();
            string passwornd = password_textbox.ToString();
            string email = email_textBox1.ToString();

            LogIn_Form Login = new LogIn_Form();
            Login.Show();
            this.Close();
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            password_textbox.UseSystemPasswordChar = true;
        }

        private void password_textbox_Click(object sender, EventArgs e)
        {
            if (password_textbox.Text == "Password")
            {
                password_textbox.Text = "";
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (password_textbox.UseSystemPasswordChar  == true)
            {
                password_textbox.UseSystemPasswordChar = false;
                pictureBox2.Image = Properties.Resources.icons8_uchiha_eyes_50;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = true;
                pictureBox2.Image = Properties.Resources.icons8_eyelashes_2d_50;
            }
        }

        private void username_textbox_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text == "Username")
            {
                username_textbox.Text = "";
            }
        }

        private void email_textBox1_Click(object sender, EventArgs e)
        {
            if (email_textBox1.Text == "Email Address")
            {
                email_textBox1.Text = "";
            }
        }
        
        //animations
        private void username_textbox_MouseEnter(object sender, EventArgs e)
        {
            username_textbox.ForeColor = activeTextColor;
            gamePanel.BackColor = activePanelColor;
        }

        private void username_textbox_MouseLeave(object sender, EventArgs e)
        {
            username_textbox.ForeColor = inactiveTextColor;
            gamePanel.BackColor = inactivePanelColor;
        }

        private void username_textbox_Enter(object sender, EventArgs e)
        {
            if (username_textbox.Text == "Username")
            {
                username_textbox.Text = "";
                username_textbox.ForeColor = activeTextColor;
            }
        }

        private void username_textbox_Leave(object sender, EventArgs e)
        {
            if (username_textbox.Text == "")
            {
                username_textbox.Text = "Username";
                username_textbox.ForeColor = inactiveTextColor;
            }
        }

        private void email_textBox1_MouseEnter(object sender, EventArgs e)
        {
            email_textBox1.ForeColor = activeTextColor;
            panel2.BackColor = activePanelColor;
        }

        private void email_textBox1_MouseLeave(object sender, EventArgs e)
        {
            email_textBox1.ForeColor = inactiveTextColor;
            panel2.BackColor = inactivePanelColor;
        }

        private void email_textBox1_Enter(object sender, EventArgs e)
        {
            if (email_textBox1.Text == "Email Address")
            {
                email_textBox1.Text = "";
                email_textBox1.ForeColor = activeTextColor;
            }
        }

        private void email_textBox1_Leave(object sender, EventArgs e)
        {
            if (email_textBox1.Text == "")
            {
                email_textBox1.Text = "Email Address";
                email_textBox1.ForeColor = inactiveTextColor;
            }
        }

        private void password_textbox_MouseEnter(object sender, EventArgs e)
        {
            password_textbox.ForeColor = activeTextColor;
            panel1.BackColor = activePanelColor;
        }

        private void password_textbox_MouseLeave(object sender, EventArgs e)
        {
            password_textbox.ForeColor = inactiveTextColor;
            panel1.BackColor = inactivePanelColor;
        }

        private void password_textbox_Enter(object sender, EventArgs e)
        {
            if (password_textbox.Text == "Password")
            {
                password_textbox.Text = "";
                password_textbox.ForeColor = activeTextColor;
            }
        }

        private void password_textbox_Leave(object sender, EventArgs e)
        {
            if (password_textbox.Text == "")
            {
                password_textbox.Text = "Password";
                password_textbox.ForeColor = inactiveTextColor;
            }
        }
    }
}

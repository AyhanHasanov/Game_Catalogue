﻿using Game_Catalogue.Business;
using Game_Catalogue.Businesss;
using Game_Data.Model;

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
        private static LogIn_Form lg = new LogIn_Form();
        User_Logic user_Logic = new User_Logic();

        private void label1_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            Registration.Show();
            this.Hide();
        }

        private void LogIn_Button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.ToString();
            string password = password_textbox.ToString();

            //Check

            try
            {
                user_Logic.CheckPassword(username, password);
                HomePage hp = new HomePage();
                hp.Show();
                lg.Close();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Username and password do not match!", "Login aborted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        // ANIMATIONS

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

        private void username_textbox_Click(object sender, EventArgs e)
        {
            if (username_textbox.Text == "Username")
            {
                username_textbox.Text = "";
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

        private void eyeBox_Click(object sender, EventArgs e)
        {
            if (password_textbox.UseSystemPasswordChar == true)
            {
                password_textbox.UseSystemPasswordChar = false;
                eyeBox.Image = Properties.Resources.icons8_uchiha_eyes_50;
            }
            else
            {
                password_textbox.UseSystemPasswordChar = true;
                eyeBox.Image = Properties.Resources.icons8_eyelashes_2d_50;
            }
        }
        private void LogIn_Form_Load(object sender, EventArgs e)
        {
            Genre_Logic controller = new Genre_Logic();
            if (controller.GetCount() == 0)
            {
                string[] genres = { "Early Access" , "Action" , "Adventure" , "Casual" ,
                    "Indie", "Massively Multiplayer", "Racing", "RPG",
                "Simulation", "Sports", "Strategy" };

                for (int i = 0; i < genres.Length; i++)
                {
                    Genre genre = new Genre();
                    genre.Name = genres[i];
                    controller.Add(genre);
                }
            }
        }
    }
}

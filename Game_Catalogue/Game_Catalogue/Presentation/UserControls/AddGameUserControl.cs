using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Catalogue.Presentation.UserControls
{
    public partial class AddGameUserControl : UserControl
    {
        public AddGameUserControl()
        {
            InitializeComponent();
        }

        Color activePanelColor = Color.FromArgb(245, 87, 142);
        Color inactivePanelColor = Color.FromArgb(245, 167, 198);
        Color activeTextColor = Color.FromArgb(247, 247, 247);
        Color inactiveTextColor = Color.FromArgb(150, 142, 183);

        private void gameTxtBox_MouseEnter(object sender, EventArgs e)
        {
            gamePanel.BackColor = activePanelColor;
        }

        private void gameTxtBox_MouseLeave(object sender, EventArgs e)
        {
            gamePanel.BackColor = inactivePanelColor;
        }

        private void gameTxtBox_Click(object sender, EventArgs e)
        {
            if (gameTxtBox.Text == "Name of game")
            {
                gameTxtBox.Text = "";
                gameTxtBox.ForeColor = activeTextColor;
            }
        }
        private void gameTxtBox_Enter(object sender, EventArgs e)
        {
            if (gameTxtBox.Text == "Name of game")
            {
                gameTxtBox.Text = "";
                gameTxtBox.ForeColor = activeTextColor;
            }
            gamePanel.BackColor = activePanelColor;
        }
        private void gameTxtBox_Leave(object sender, EventArgs e)
        {
            if (gameTxtBox.Text == "")
            {
                gameTxtBox.Text = "Name of game";
                gameTxtBox.ForeColor = inactiveTextColor;
            }
            gamePanel.BackColor = inactivePanelColor;
        }

        // DESCRIPTION TEXT BOX
        private void descrpTxtBox_MouseEnter(object sender, EventArgs e)
        {
            descrpPanel.BackColor = activePanelColor;
        }

        private void descrpTxtBox_MouseLeave(object sender, EventArgs e)
        {
            descrpPanel.BackColor = inactivePanelColor;
        }

        private void descrpTxtBox_Click(object sender, EventArgs e)
        {
            if (descrpTxtBox.Text == "Description")
            {
                descrpTxtBox.Text = "";
                descrpTxtBox.ForeColor = activeTextColor;
            }
        }

        private void descrpTxtBox_Enter(object sender, EventArgs e)
        {
            if (descrpTxtBox.Text == "Description")
            {
                descrpTxtBox.Text = "";
                descrpTxtBox.ForeColor = activeTextColor;
            }
            descrpPanel.BackColor= activePanelColor;
        }

        private void descrpTxtBox_Leave(object sender, EventArgs e)
        {
            if (descrpTxtBox.Text == "")
            {
                descrpTxtBox.Text = "Description";
                descrpTxtBox.ForeColor = inactiveTextColor;
            }
            descrpPanel.BackColor = inactivePanelColor;
        }

        private void planToPlayRadioBttn_CheckedChanged(object sender, EventArgs e)
        {
            if (planToPlayRadioBttn.Checked)
                planToPlayRadioBttn.ForeColor = activeTextColor;
            else
                planToPlayRadioBttn.ForeColor = inactiveTextColor;
        }

        private void playingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(playingRadioButton.Checked)
                playingRadioButton.ForeColor = activeTextColor;
            else
                playingRadioButton.ForeColor = inactiveTextColor;
        }

        private void playedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(playedRadioButton.Checked)
                playedRadioButton.ForeColor = activeTextColor;
            else
                playedRadioButton.ForeColor = inactiveTextColor;
        }
    }
}

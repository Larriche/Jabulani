using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jabulani
{
    public partial class mainMenu : Form
    {
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public mainMenu()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            introForm  intro = new introForm();
            this.Hide();
            intro.ShowDialog();
            this.Close();
        }

        private void highscoreButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            highScore hiscr = new highScore();
            this.Hide();
            hiscr.ShowDialog();
            this.Close();

        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutForm hiscr = new aboutForm();
            hiscr.ShowDialog();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            this.Close();
        }

        private void mainMenu_Load(object sender, EventArgs e)
        {
            Button[] menuButtons = {playButton,highscoreButton,aboutButton,quitButton};

            wplayer.URL = @"welcome.mp3";
            wplayer.controls.play();


            for (int i = 0; i < menuButtons.Length; i++)
            {
                menuButtons[i].FlatAppearance.BorderSize = 0;
                menuButtons[i].BackColor = Color.Transparent;
                menuButtons[i].FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
                menuButtons[i].BackColor = Color.Transparent;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Jabulani
{
    public partial class gameOverForm : Form
    {
        public  int score;
        public gameOverForm()
        {
            InitializeComponent();
        }

        private void saveScoreBttn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text.ToString();
            if (name == "")
                name = "Player";

            System.IO.StreamWriter file = new System.IO.StreamWriter("scores.txt", true);
            file.WriteLine(name);
            file.WriteLine(score.ToString());

            file.Close();

            mainMenu home = new mainMenu();
            this.Hide();
            home.ShowDialog();
            this.Close();

        }

        private void gameOverForm_Load(object sender, EventArgs e)
        {
            scoreLabel.Text = scoreLabel.Text + score;
        }

    }
}

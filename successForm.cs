using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jabulani
{
    public partial class successForm : Form
    {
        public successForm()
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
            file.WriteLine(540); // 800 is the score when user answers all questions correctly

            file.Close();

            mainMenu home = new mainMenu();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }
    }
}

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
    public partial class introForm : Form
    {
        public introForm()
        {
            InitializeComponent();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            questionsForm qstn = new questionsForm();
            this.Hide();
            qstn.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();

        }
    }
}

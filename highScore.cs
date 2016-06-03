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
    public partial class highScore : Form
    {
        public highScore()
        {
            InitializeComponent();
        }

        private void highScore_Load(object sender, EventArgs e)
        {
            var filestream = new FileStream("scores.txt", FileMode.Open, FileAccess.Read);
            var reader = new StreamReader(filestream);
            int[] scores = new int[100];
            String[] names = new string[100];
            int index = 0;

            while (!reader.EndOfStream)
            {
                names[index] = reader.ReadLine().ToString();
                scores[index] =  Convert.ToInt32(reader.ReadLine());
                index++;
            }

            // sorting scores 
            for (int i = 0; i < index - 1; i++)
            {
                for (int j = 0; j <= (index - 2 - i); j++)
                {
                    if (scores[j] < scores[j + 1])
                    {
                        int temp = scores[j];
                        scores[j] = scores[j + 1];
                        scores[j + 1] = temp;

                        string temp_nme = names[j];
                        names[j] = names[j + 1];
                        names[j + 1] = temp_nme;
                    }
                }
            }

            if (index < 5)
            {
                for (int i = index; i <= 5; i++)
                {
                    names[i] = "";
                    scores[i] = -1;
                }
            }

            label2.Text = (names[0].Length > 0)?names[0]:" ";
            label3.Text = (names[1].Length > 0) ? names[1] : " ";
            label4.Text = (names[2].Length > 0) ? names[2] : " ";
            label5.Text = (names[3].Length > 0) ? names[3] : " "; 
            label6.Text = (names[4].Length > 0) ? names[4] : " ";

            label7.Text = (scores[0] >= 0)? scores[0].ToString() : " ";
            label8.Text = (scores[1] >= 0) ? scores[1].ToString() : "";
            label9.Text = (scores[2] >= 0) ? scores[2].ToString() : " ";
            label10.Text = (scores[3] >= 0) ? scores[3].ToString() : " ";
            label11.Text = (scores[4] >= 0) ? scores[4].ToString() : " ";

        }

        private void backBttn_Click(object sender, EventArgs e)
        {
            mainMenu menu = new mainMenu();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        } 
    }
}

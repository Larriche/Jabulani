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
    public partial class questionsForm : Form
    {
        private int score = 0;
        private string answer;
        private bool correct;
        private bool formLocked = false;
        private bool answered = true;
        private Random fileNumGen = new Random();
        private List<int> usedNums = new List<int>();
        public questionsForm()
        {
            InitializeComponent();
        }

        private void questionsForm_Load(object sender, EventArgs e)
        {
            generateQuestion();
        }
        /*
        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            
            answered = true;
            RadioButton[] options = { option1, option2, option3, option4 };
            if (!formLocked)
            {
                for (int i = 0; i < options.Length; i++)
                {

                    if (options[i].Checked)
                    {
                        if (options[i].Text == answer)
                        {
                            correct = true;
                            score += 10;
                            scoreLabel.Text = "SCORE: " + score.ToString();
                        }
                        else
                            correct = false;
                    }
                    
                    if (options[i].Checked && options[i].Text != answer)
                        options[i].ForeColor = Color.Red;
                    if (options[i].Text == answer)
                        options[i].ForeColor = Color.Green;
                }
                formLocked = true;
            }
        }*/

        

        private void generateQuestion()
        {
            string[] countries = {"algeria","angola","benin","botswana","burkina faso","burundi","cameroon",
                                     "cape verde","central africa republic","chad","comoros","congo","cote d'ivoire",
                                     "djibouti","dr congo","egypt","equitorial guinea","eritrea","ethiopia","gabon",
                                     "gambia","ghana","guinea bissau","guinea","kenya","lesotho","liberia","lybia","madagascar",
                                     "malawi","mali","mauritania","mauritius","morocco","mozambique","namibia","niger","nigeria","rwanda",
                                      "senegal","seychelles","sierra leone","somalia","south africa","south sudan","sudan","swaziland",
                                     "tanzania","togo","tunisia","uganda","western sahara","zambia","zimbabwe"
                 };
            int fileNum;

            /*Repainting*/
            Button[] optionBttns = { option1, option2, option3 };
            for (int i = 0; i < optionBttns.Length; i++)
            {
                optionBttns[i].BackColor = Color.LemonChiffon;
                optionBttns[i].ForeColor = Color.DarkGreen;
            }


            do
            {
                 fileNum = fileNumGen.Next(0, 54);

            } while (usedNums.Contains(fileNum));
            usedNums.Add(fileNum);
             
            
            flagBox.Image = new Bitmap("flags/"+countries[fileNum]+".png");
            answer = countries[fileNum];

            string[] options = new string[3];
            options[0] = answer;

            int option_chooser;
            for (int j = 1; j <= 2; j++)
            {
                do
                {
                    option_chooser = fileNumGen.Next(0, 54);

                } while (options.Contains(countries[option_chooser]));
                options[j] = countries[option_chooser];
            }

            /*shuffling array*/
            for (int i = 0; i <= 2; i++)
            {
                int pos1 = fileNumGen.Next(0, 3);
                int pos2 = fileNumGen.Next(0, 3);

                string temp = options[pos1];
                options[pos1] = options[pos2];
                options[pos2] = temp;
            }



            option1.Text = options[0].ToUpper();
            option2.Text = options[1].ToUpper();
            option3.Text = options[2].ToUpper();

            formLocked = false;
            answered = false;
             

        }

        private void button3_Click(object sender, EventArgs e)
        {
            answered = true;

            if (!formLocked)
            {
                if (sender.Equals(option1))
                    assessChoice(option1);

                else if (sender.Equals(option2))
                    assessChoice(option2);

                else
                    assessChoice(option3);
            }

            if (answered && correct)
            {
                if (score < 540)
                    generateQuestion();
                else
                {
                    successForm success = new successForm();
                    this.Hide();
                    success.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                gameOverForm gover = new gameOverForm();
                this.Hide();
                gover.score = score;
                gover.ShowDialog();
                this.Close();
            }
        }

        private void scoreLabel_Click(object sender, EventArgs e)
        {
      
        }

        void assessChoice(Button option)
        {
            if (option.Text.ToLower() != answer)
            {
                option.BackColor = Color.Red;
                option.ForeColor = Color.WhiteSmoke;
                correct = false;
                highlightAnswer();
            }
            else
            {
                option.BackColor = Color.Green;
                option.ForeColor = Color.YellowGreen;
                score += 10;
                scoreLabel.Text = "SCORE: " + score.ToString();
                correct = true;
            }
            formLocked = true;
        }

        void highlightAnswer()
        {
            Button ansBttn;
            if (option1.Text.ToLower() == answer)
                ansBttn = option1;

            else if (option2.Text.ToLower() == answer)
                ansBttn = option2;

            else ansBttn = option2;

            ansBttn.BackColor = Color.Green;
            ansBttn.ForeColor = Color.YellowGreen;
        }

    }

}

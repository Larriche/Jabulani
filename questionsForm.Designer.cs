namespace Jabulani
{
    partial class questionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(questionsForm));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.flagBox = new System.Windows.Forms.PictureBox();
            this.option1 = new System.Windows.Forms.Button();
            this.option2 = new System.Windows.Forms.Button();
            this.option3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flagBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.scoreLabel.Location = new System.Drawing.Point(769, 19);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(84, 19);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "SCORE : 0";
            this.scoreLabel.Click += new System.EventHandler(this.scoreLabel_Click);
            // 
            // flagBox
            // 
            this.flagBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flagBox.Location = new System.Drawing.Point(230, 50);
            this.flagBox.Name = "flagBox";
            this.flagBox.Size = new System.Drawing.Size(437, 249);
            this.flagBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flagBox.TabIndex = 8;
            this.flagBox.TabStop = false;
            // 
            // option1
            // 
            this.option1.BackColor = System.Drawing.Color.LemonChiffon;
            this.option1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.ForeColor = System.Drawing.Color.DarkGreen;
            this.option1.Location = new System.Drawing.Point(230, 345);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(437, 38);
            this.option1.TabIndex = 9;
            this.option1.Text = "option1";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.Click += new System.EventHandler(this.button3_Click);
            // 
            // option2
            // 
            this.option2.BackColor = System.Drawing.Color.LemonChiffon;
            this.option2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.ForeColor = System.Drawing.Color.DarkGreen;
            this.option2.Location = new System.Drawing.Point(230, 389);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(437, 38);
            this.option2.TabIndex = 10;
            this.option2.Text = "button2";
            this.option2.UseVisualStyleBackColor = false;
            this.option2.Click += new System.EventHandler(this.button3_Click);
            // 
            // option3
            // 
            this.option3.BackColor = System.Drawing.Color.LemonChiffon;
            this.option3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.option3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.ForeColor = System.Drawing.Color.DarkGreen;
            this.option3.Location = new System.Drawing.Point(230, 433);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(437, 38);
            this.option3.TabIndex = 11;
            this.option3.Text = "button3";
            this.option3.UseVisualStyleBackColor = false;
            this.option3.Click += new System.EventHandler(this.button3_Click);
            // 
            // questionsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.flagBox);
            this.Controls.Add(this.scoreLabel);
            this.ForeColor = System.Drawing.Color.Ivory;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "questionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jabulani v1.0";
            this.Load += new System.EventHandler(this.questionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flagBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.PictureBox flagBox;
        private System.Windows.Forms.Button option1;
        private System.Windows.Forms.Button option2;
        private System.Windows.Forms.Button option3;
    }
}
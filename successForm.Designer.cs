namespace Jabulani
{
    partial class successForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.saveScoreBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(218, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Congratulations,you are really made of black!";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Maroon;
            this.scoreLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.scoreLabel.Location = new System.Drawing.Point(202, 186);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(133, 23);
            this.scoreLabel.TabIndex = 8;
            this.scoreLabel.Text = "Your Score: 530";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label3.Location = new System.Drawing.Point(201, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your Name:";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Snow;
            this.nameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.ForeColor = System.Drawing.Color.Maroon;
            this.nameBox.Location = new System.Drawing.Point(204, 247);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(448, 30);
            this.nameBox.TabIndex = 6;
            // 
            // saveScoreBttn
            // 
            this.saveScoreBttn.BackColor = System.Drawing.Color.IndianRed;
            this.saveScoreBttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.saveScoreBttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveScoreBttn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveScoreBttn.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.saveScoreBttn.Location = new System.Drawing.Point(323, 360);
            this.saveScoreBttn.Name = "saveScoreBttn";
            this.saveScoreBttn.Size = new System.Drawing.Size(224, 39);
            this.saveScoreBttn.TabIndex = 9;
            this.saveScoreBttn.Text = "Save Score";
            this.saveScoreBttn.UseVisualStyleBackColor = false;
            this.saveScoreBttn.Click += new System.EventHandler(this.saveScoreBttn_Click);
            // 
            // successForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
    
            this.ClientSize = new System.Drawing.Size(884, 466);
            this.Controls.Add(this.saveScoreBttn);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(900, 504);
            this.MinimumSize = new System.Drawing.Size(900, 504);
            this.Name = "successForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Jabulani v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button saveScoreBttn;
    }
}
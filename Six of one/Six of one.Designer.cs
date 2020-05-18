namespace Six_of_one
{
    partial class SixOfOne
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Roll1 = new System.Windows.Forms.Button();
            this.tbxDice1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpPlayer1 = new System.Windows.Forms.GroupBox();
            this.lblplayer1Winturn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblplayer1Score = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPlayer1name = new System.Windows.Forms.Label();
            this.gpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblplayer2Winturn = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblplayer2Score = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlayer2name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDice2 = new System.Windows.Forms.TextBox();
            this.Roll2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            this.gpTurn = new System.Windows.Forms.GroupBox();
            this.rdPlayer2 = new System.Windows.Forms.RadioButton();
            this.rdPlayer1 = new System.Windows.Forms.RadioButton();
            this.lblGoal = new System.Windows.Forms.Label();
            this.picbx1 = new System.Windows.Forms.PictureBox();
            this.picbx4 = new System.Windows.Forms.PictureBox();
            this.picbx5 = new System.Windows.Forms.PictureBox();
            this.picbx3 = new System.Windows.Forms.PictureBox();
            this.picbx2 = new System.Windows.Forms.PictureBox();
            this.picbx6 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playAgain = new System.Windows.Forms.Button();
            this.gpPlayer1.SuspendLayout();
            this.gpPlayer2.SuspendLayout();
            this.gpTurn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx6)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // tbxOutput
            // 
            this.tbxOutput.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxOutput.Location = new System.Drawing.Point(12, 232);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.ReadOnly = true;
            this.tbxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxOutput.Size = new System.Drawing.Size(596, 167);
            this.tbxOutput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // Roll1
            // 
            this.Roll1.Location = new System.Drawing.Point(6, 118);
            this.Roll1.Name = "Roll1";
            this.Roll1.Size = new System.Drawing.Size(75, 23);
            this.Roll1.TabIndex = 1;
            this.Roll1.Text = "ROLL";
            this.Roll1.UseVisualStyleBackColor = true;
            this.Roll1.Visible = false;
            this.Roll1.Click += new System.EventHandler(this.Roll_Click);
            // 
            // tbxDice1
            // 
            this.tbxDice1.Location = new System.Drawing.Point(6, 84);
            this.tbxDice1.Name = "tbxDice1";
            this.tbxDice1.Size = new System.Drawing.Size(100, 21);
            this.tbxDice1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dice quatity";
            // 
            // gpPlayer1
            // 
            this.gpPlayer1.Controls.Add(this.lblplayer1Winturn);
            this.gpPlayer1.Controls.Add(this.label8);
            this.gpPlayer1.Controls.Add(this.lblplayer1Score);
            this.gpPlayer1.Controls.Add(this.label7);
            this.gpPlayer1.Controls.Add(this.lblPlayer1name);
            this.gpPlayer1.Controls.Add(this.label3);
            this.gpPlayer1.Controls.Add(this.tbxDice1);
            this.gpPlayer1.Controls.Add(this.Roll1);
            this.gpPlayer1.Controls.Add(this.label1);
            this.gpPlayer1.Location = new System.Drawing.Point(12, 29);
            this.gpPlayer1.Name = "gpPlayer1";
            this.gpPlayer1.Size = new System.Drawing.Size(129, 168);
            this.gpPlayer1.TabIndex = 0;
            this.gpPlayer1.TabStop = false;
            this.gpPlayer1.Text = "Player1";
            // 
            // lblplayer1Winturn
            // 
            this.lblplayer1Winturn.AutoSize = true;
            this.lblplayer1Winturn.Location = new System.Drawing.Point(70, 17);
            this.lblplayer1Winturn.Name = "lblplayer1Winturn";
            this.lblplayer1Winturn.Size = new System.Drawing.Size(11, 12);
            this.lblplayer1Winturn.TabIndex = 21;
            this.lblplayer1Winturn.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "Win turn:";
            // 
            // lblplayer1Score
            // 
            this.lblplayer1Score.AutoSize = true;
            this.lblplayer1Score.Location = new System.Drawing.Point(47, 144);
            this.lblplayer1Score.Name = "lblplayer1Score";
            this.lblplayer1Score.Size = new System.Drawing.Size(11, 12);
            this.lblplayer1Score.TabIndex = 17;
            this.lblplayer1Score.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "score:";
            // 
            // lblPlayer1name
            // 
            this.lblPlayer1name.AutoSize = true;
            this.lblPlayer1name.Location = new System.Drawing.Point(47, 42);
            this.lblPlayer1name.Name = "lblPlayer1name";
            this.lblPlayer1name.Size = new System.Drawing.Size(0, 12);
            this.lblPlayer1name.TabIndex = 4;
            // 
            // gpPlayer2
            // 
            this.gpPlayer2.Controls.Add(this.lblplayer2Winturn);
            this.gpPlayer2.Controls.Add(this.label9);
            this.gpPlayer2.Controls.Add(this.lblplayer2Score);
            this.gpPlayer2.Controls.Add(this.label6);
            this.gpPlayer2.Controls.Add(this.lblPlayer2name);
            this.gpPlayer2.Controls.Add(this.label4);
            this.gpPlayer2.Controls.Add(this.tbxDice2);
            this.gpPlayer2.Controls.Add(this.Roll2);
            this.gpPlayer2.Controls.Add(this.label2);
            this.gpPlayer2.Location = new System.Drawing.Point(178, 29);
            this.gpPlayer2.Name = "gpPlayer2";
            this.gpPlayer2.Size = new System.Drawing.Size(129, 168);
            this.gpPlayer2.TabIndex = 4;
            this.gpPlayer2.TabStop = false;
            this.gpPlayer2.Text = "Player2";
            // 
            // lblplayer2Winturn
            // 
            this.lblplayer2Winturn.AutoSize = true;
            this.lblplayer2Winturn.Location = new System.Drawing.Point(71, 17);
            this.lblplayer2Winturn.Name = "lblplayer2Winturn";
            this.lblplayer2Winturn.Size = new System.Drawing.Size(11, 12);
            this.lblplayer2Winturn.TabIndex = 20;
            this.lblplayer2Winturn.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "Win turn:";
            // 
            // lblplayer2Score
            // 
            this.lblplayer2Score.AutoSize = true;
            this.lblplayer2Score.Location = new System.Drawing.Point(53, 144);
            this.lblplayer2Score.Name = "lblplayer2Score";
            this.lblplayer2Score.Size = new System.Drawing.Size(11, 12);
            this.lblplayer2Score.TabIndex = 18;
            this.lblplayer2Score.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "score:";
            // 
            // lblPlayer2name
            // 
            this.lblPlayer2name.AutoSize = true;
            this.lblPlayer2name.Location = new System.Drawing.Point(55, 42);
            this.lblPlayer2name.Name = "lblPlayer2name";
            this.lblPlayer2name.Size = new System.Drawing.Size(0, 12);
            this.lblPlayer2name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dice quatity";
            // 
            // tbxDice2
            // 
            this.tbxDice2.Location = new System.Drawing.Point(6, 84);
            this.tbxDice2.Name = "tbxDice2";
            this.tbxDice2.Size = new System.Drawing.Size(100, 21);
            this.tbxDice2.TabIndex = 1;
            // 
            // Roll2
            // 
            this.Roll2.Location = new System.Drawing.Point(6, 118);
            this.Roll2.Name = "Roll2";
            this.Roll2.Size = new System.Drawing.Size(75, 23);
            this.Roll2.TabIndex = 1;
            this.Roll2.Text = "ROLL";
            this.Roll2.UseVisualStyleBackColor = true;
            this.Roll2.Visible = false;
            this.Roll2.Click += new System.EventHandler(this.Roll2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Goal:";
            // 
            // startGame
            // 
            this.startGame.Location = new System.Drawing.Point(20, 203);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(75, 23);
            this.startGame.TabIndex = 7;
            this.startGame.Text = "Start";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // gpTurn
            // 
            this.gpTurn.Controls.Add(this.rdPlayer2);
            this.gpTurn.Controls.Add(this.rdPlayer1);
            this.gpTurn.Location = new System.Drawing.Point(48, 335);
            this.gpTurn.Name = "gpTurn";
            this.gpTurn.Size = new System.Drawing.Size(220, 45);
            this.gpTurn.TabIndex = 8;
            this.gpTurn.TabStop = false;
            this.gpTurn.Text = "Player turn";
            this.gpTurn.Visible = false;
            // 
            // rdPlayer2
            // 
            this.rdPlayer2.AutoSize = true;
            this.rdPlayer2.Location = new System.Drawing.Point(130, 20);
            this.rdPlayer2.Name = "rdPlayer2";
            this.rdPlayer2.Size = new System.Drawing.Size(65, 16);
            this.rdPlayer2.TabIndex = 10;
            this.rdPlayer2.Text = "Player2";
            this.rdPlayer2.UseVisualStyleBackColor = true;
            this.rdPlayer2.CheckedChanged += new System.EventHandler(this.rdPlayer2_CheckedChanged);
            // 
            // rdPlayer1
            // 
            this.rdPlayer1.AutoSize = true;
            this.rdPlayer1.Location = new System.Drawing.Point(6, 20);
            this.rdPlayer1.Name = "rdPlayer1";
            this.rdPlayer1.Size = new System.Drawing.Size(65, 16);
            this.rdPlayer1.TabIndex = 9;
            this.rdPlayer1.Text = "Player1";
            this.rdPlayer1.UseVisualStyleBackColor = true;
            this.rdPlayer1.CheckedChanged += new System.EventHandler(this.rdPlayer1_CheckedChanged);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(489, 208);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(0, 12);
            this.lblGoal.TabIndex = 9;
            // 
            // picbx1
            // 
            this.picbx1.BackColor = System.Drawing.SystemColors.Control;
            this.picbx1.Location = new System.Drawing.Point(31, 20);
            this.picbx1.Name = "picbx1";
            this.picbx1.Size = new System.Drawing.Size(60, 60);
            this.picbx1.TabIndex = 10;
            this.picbx1.TabStop = false;
            // 
            // picbx4
            // 
            this.picbx4.Location = new System.Drawing.Point(31, 101);
            this.picbx4.Name = "picbx4";
            this.picbx4.Size = new System.Drawing.Size(60, 60);
            this.picbx4.TabIndex = 11;
            this.picbx4.TabStop = false;
            // 
            // picbx5
            // 
            this.picbx5.Location = new System.Drawing.Point(123, 101);
            this.picbx5.Name = "picbx5";
            this.picbx5.Size = new System.Drawing.Size(60, 60);
            this.picbx5.TabIndex = 12;
            this.picbx5.TabStop = false;
            // 
            // picbx3
            // 
            this.picbx3.Location = new System.Drawing.Point(210, 20);
            this.picbx3.Name = "picbx3";
            this.picbx3.Size = new System.Drawing.Size(60, 60);
            this.picbx3.TabIndex = 13;
            this.picbx3.TabStop = false;
            // 
            // picbx2
            // 
            this.picbx2.Location = new System.Drawing.Point(123, 20);
            this.picbx2.Name = "picbx2";
            this.picbx2.Size = new System.Drawing.Size(60, 60);
            this.picbx2.TabIndex = 14;
            this.picbx2.TabStop = false;
            // 
            // picbx6
            // 
            this.picbx6.Location = new System.Drawing.Point(210, 103);
            this.picbx6.Name = "picbx6";
            this.picbx6.Size = new System.Drawing.Size(60, 60);
            this.picbx6.TabIndex = 15;
            this.picbx6.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picbx6);
            this.groupBox1.Controls.Add(this.picbx2);
            this.groupBox1.Controls.Add(this.picbx3);
            this.groupBox1.Controls.Add(this.picbx5);
            this.groupBox1.Controls.Add(this.picbx4);
            this.groupBox1.Controls.Add(this.picbx1);
            this.groupBox1.Location = new System.Drawing.Point(327, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 175);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dice picture";
            // 
            // playAgain
            // 
            this.playAgain.Location = new System.Drawing.Point(178, 203);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(102, 23);
            this.playAgain.TabIndex = 25;
            this.playAgain.Text = "Play agian!";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // SixOfOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 411);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.gpTurn);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gpPlayer2);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.gpPlayer1);
            this.Name = "SixOfOne";
            this.Text = "Six of one";
            this.gpPlayer1.ResumeLayout(false);
            this.gpPlayer1.PerformLayout();
            this.gpPlayer2.ResumeLayout(false);
            this.gpPlayer2.PerformLayout();
            this.gpTurn.ResumeLayout(false);
            this.gpTurn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx6)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Roll1;
        private System.Windows.Forms.TextBox tbxDice1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpPlayer1;
        private System.Windows.Forms.GroupBox gpPlayer2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDice2;
        private System.Windows.Forms.Button Roll2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.GroupBox gpTurn;
        private System.Windows.Forms.RadioButton rdPlayer2;
        private System.Windows.Forms.RadioButton rdPlayer1;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblPlayer1name;
        private System.Windows.Forms.Label lblPlayer2name;
        private System.Windows.Forms.PictureBox picbx1;
        private System.Windows.Forms.PictureBox picbx4;
        private System.Windows.Forms.PictureBox picbx5;
        private System.Windows.Forms.PictureBox picbx3;
        private System.Windows.Forms.PictureBox picbx2;
        private System.Windows.Forms.PictureBox picbx6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblplayer1Score;
        private System.Windows.Forms.Label lblplayer2Score;
        private System.Windows.Forms.Label lblplayer1Winturn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblplayer2Winturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button playAgain;
    }
}


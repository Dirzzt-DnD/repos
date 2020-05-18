namespace Six_of_one
{
    partial class GameSelect
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
            this.twoPlayer = new System.Windows.Forms.Button();
            this.singlePlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // twoPlayer
            // 
            this.twoPlayer.Location = new System.Drawing.Point(80, 133);
            this.twoPlayer.Name = "twoPlayer";
            this.twoPlayer.Size = new System.Drawing.Size(75, 23);
            this.twoPlayer.TabIndex = 0;
            this.twoPlayer.Text = "2-player";
            this.twoPlayer.UseVisualStyleBackColor = true;
            this.twoPlayer.Click += new System.EventHandler(this.twoPlayer_Click);
            // 
            // singlePlayer
            // 
            this.singlePlayer.Location = new System.Drawing.Point(80, 66);
            this.singlePlayer.Name = "singlePlayer";
            this.singlePlayer.Size = new System.Drawing.Size(75, 23);
            this.singlePlayer.TabIndex = 1;
            this.singlePlayer.Text = "1-player";
            this.singlePlayer.UseVisualStyleBackColor = true;
            this.singlePlayer.Click += new System.EventHandler(this.singlePlayer_Click);
            // 
            // GameSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 214);
            this.Controls.Add(this.singlePlayer);
            this.Controls.Add(this.twoPlayer);
            this.Name = "GameSelect";
            this.Text = "GameSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button twoPlayer;
        private System.Windows.Forms.Button singlePlayer;
    }
}
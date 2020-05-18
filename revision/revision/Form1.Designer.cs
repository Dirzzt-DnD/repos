namespace revision
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.warnWord = new System.Windows.Forms.Label();
            this.tbxCapacity = new System.Windows.Forms.TextBox();
            this.tbxWine = new System.Windows.Forms.TextBox();
            this.picWine = new System.Windows.Forms.PictureBox();
            this.trackWine = new System.Windows.Forms.TrackBar();
            this.bMax = new System.Windows.Forms.Label();
            this.bMid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.redChecked = new System.Windows.Forms.RadioButton();
            this.whiteChecked = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picWine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWine)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "capacity of bottle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "wine in bottle";
            // 
            // warnWord
            // 
            this.warnWord.AutoSize = true;
            this.warnWord.BackColor = System.Drawing.Color.Firebrick;
            this.warnWord.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.warnWord.Location = new System.Drawing.Point(32, 351);
            this.warnWord.Name = "warnWord";
            this.warnWord.Size = new System.Drawing.Size(0, 19);
            this.warnWord.TabIndex = 5;
            this.warnWord.Visible = false;
            // 
            // tbxCapacity
            // 
            this.tbxCapacity.Location = new System.Drawing.Point(36, 186);
            this.tbxCapacity.Name = "tbxCapacity";
            this.tbxCapacity.Size = new System.Drawing.Size(100, 21);
            this.tbxCapacity.TabIndex = 6;
            this.tbxCapacity.Text = "770";
            // 
            // tbxWine
            // 
            this.tbxWine.Location = new System.Drawing.Point(36, 284);
            this.tbxWine.Name = "tbxWine";
            this.tbxWine.Size = new System.Drawing.Size(100, 21);
            this.tbxWine.TabIndex = 7;
            this.tbxWine.Text = "750";
            // 
            // picWine
            // 
            this.picWine.BackColor = System.Drawing.Color.Maroon;
            this.picWine.Location = new System.Drawing.Point(271, 21);
            this.picWine.Name = "picWine";
            this.picWine.Size = new System.Drawing.Size(52, 423);
            this.picWine.TabIndex = 8;
            this.picWine.TabStop = false;
            // 
            // trackWine
            // 
            this.trackWine.Location = new System.Drawing.Point(373, 21);
            this.trackWine.Name = "trackWine";
            this.trackWine.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackWine.Size = new System.Drawing.Size(45, 423);
            this.trackWine.TabIndex = 9;
            this.trackWine.Scroll += new System.EventHandler(this.trackWine_Scroll);
            // 
            // bMax
            // 
            this.bMax.AutoSize = true;
            this.bMax.Location = new System.Drawing.Point(242, 21);
            this.bMax.Name = "bMax";
            this.bMax.Size = new System.Drawing.Size(23, 12);
            this.bMax.TabIndex = 10;
            this.bMax.Text = "770";
            // 
            // bMid
            // 
            this.bMid.AutoSize = true;
            this.bMid.Location = new System.Drawing.Point(242, 195);
            this.bMid.Name = "bMid";
            this.bMid.Size = new System.Drawing.Size(23, 12);
            this.bMid.TabIndex = 11;
            this.bMid.Text = "335";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.whiteChecked);
            this.groupBox1.Controls.Add(this.redChecked);
            this.groupBox1.Location = new System.Drawing.Point(36, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of wine";
            // 
            // redChecked
            // 
            this.redChecked.AutoSize = true;
            this.redChecked.Checked = true;
            this.redChecked.Location = new System.Drawing.Point(6, 29);
            this.redChecked.Name = "redChecked";
            this.redChecked.Size = new System.Drawing.Size(41, 16);
            this.redChecked.TabIndex = 0;
            this.redChecked.TabStop = true;
            this.redChecked.Text = "red";
            this.redChecked.UseVisualStyleBackColor = true;
            this.redChecked.CheckedChanged += new System.EventHandler(this.redChecked_CheckedChanged);
            // 
            // whiteChecked
            // 
            this.whiteChecked.AutoSize = true;
            this.whiteChecked.Location = new System.Drawing.Point(6, 67);
            this.whiteChecked.Name = "whiteChecked";
            this.whiteChecked.Size = new System.Drawing.Size(53, 16);
            this.whiteChecked.TabIndex = 1;
            this.whiteChecked.Text = "white";
            this.whiteChecked.UseVisualStyleBackColor = true;
            this.whiteChecked.CheckedChanged += new System.EventHandler(this.whiteChecked_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 471);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bMid);
            this.Controls.Add(this.bMax);
            this.Controls.Add(this.trackWine);
            this.Controls.Add(this.picWine);
            this.Controls.Add(this.tbxWine);
            this.Controls.Add(this.tbxCapacity);
            this.Controls.Add(this.warnWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picWine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackWine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label warnWord;
        private System.Windows.Forms.TextBox tbxCapacity;
        private System.Windows.Forms.TextBox tbxWine;
        private System.Windows.Forms.PictureBox picWine;
        private System.Windows.Forms.TrackBar trackWine;
        private System.Windows.Forms.Label bMax;
        private System.Windows.Forms.Label bMid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton whiteChecked;
        private System.Windows.Forms.RadioButton redChecked;
    }
}


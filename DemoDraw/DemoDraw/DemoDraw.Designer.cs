namespace DemoDraw
{
    partial class DemoDraw
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
            this.pbxDrawing = new System.Windows.Forms.PictureBox();
            this.btnDraw_click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDrawing
            // 
            this.pbxDrawing.Location = new System.Drawing.Point(92, 22);
            this.pbxDrawing.Name = "pbxDrawing";
            this.pbxDrawing.Size = new System.Drawing.Size(597, 306);
            this.pbxDrawing.TabIndex = 0;
            this.pbxDrawing.TabStop = false;
            // 
            // btnDraw_click
            // 
            this.btnDraw_click.Location = new System.Drawing.Point(176, 380);
            this.btnDraw_click.Name = "btnDraw_click";
            this.btnDraw_click.Size = new System.Drawing.Size(392, 58);
            this.btnDraw_click.TabIndex = 1;
            this.btnDraw_click.Text = "CLick";
            this.btnDraw_click.UseVisualStyleBackColor = true;
            this.btnDraw_click.Click += new System.EventHandler(this.changed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDraw_click);
            this.Controls.Add(this.pbxDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDrawing;
        private System.Windows.Forms.Button btnDraw_click;
    }
}


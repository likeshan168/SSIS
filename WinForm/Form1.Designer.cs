namespace WinForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnbrowser = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnbrowser
            // 
            this.btnbrowser.Location = new System.Drawing.Point(324, 63);
            this.btnbrowser.Name = "btnbrowser";
            this.btnbrowser.Size = new System.Drawing.Size(75, 23);
            this.btnbrowser.TabIndex = 0;
            this.btnbrowser.Text = "浏览..";
            this.btnbrowser.UseVisualStyleBackColor = true;
            this.btnbrowser.Click += new System.EventHandler(this.btnbrowser_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(111, 65);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(185, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(324, 143);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 23);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "生成excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "弹出信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnbrowser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnbrowser;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button button1;
    }
}


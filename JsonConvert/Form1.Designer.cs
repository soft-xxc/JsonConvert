
namespace JsonConvertTO
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
            this.btn_startConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_selectFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_select = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_startConvert
            // 
            this.btn_startConvert.Location = new System.Drawing.Point(693, 44);
            this.btn_startConvert.Name = "btn_startConvert";
            this.btn_startConvert.Size = new System.Drawing.Size(75, 64);
            this.btn_startConvert.TabIndex = 0;
            this.btn_startConvert.Text = "开始转换";
            this.btn_startConvert.UseVisualStyleBackColor = true;
            this.btn_startConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择文件：";
            // 
            // txt_selectFilePath
            // 
            this.txt_selectFilePath.Location = new System.Drawing.Point(95, 44);
            this.txt_selectFilePath.Name = "txt_selectFilePath";
            this.txt_selectFilePath.ReadOnly = true;
            this.txt_selectFilePath.Size = new System.Drawing.Size(468, 21);
            this.txt_selectFilePath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(577, 42);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(93, 23);
            this.btn_select.TabIndex = 3;
            this.btn_select.Text = "选择json文件";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "存放目录：";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(95, 88);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(468, 21);
            this.txt_output.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "选择存放路径";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "执行记录：";
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(95, 132);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(468, 41);
            this.txt_log.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 185);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.txt_selectFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_startConvert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "json文件转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_selectFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_log;
    }
}


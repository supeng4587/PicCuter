namespace ImageCuttingTools
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
            this.btnChoice = new System.Windows.Forms.Button();
            this.txtWidePixel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.btnExecuteCutting = new System.Windows.Forms.Button();
            this.btnOpenSavePath = new System.Windows.Forms.Button();
            this.txtChoicePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.txtSaveFolder = new System.Windows.Forms.TextBox();
            this.btnCleanChoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoice
            // 
            this.btnChoice.Location = new System.Drawing.Point(80, 40);
            this.btnChoice.Name = "btnChoice";
            this.btnChoice.Size = new System.Drawing.Size(80, 60);
            this.btnChoice.TabIndex = 0;
            this.btnChoice.Text = "选择文件";
            this.btnChoice.UseVisualStyleBackColor = true;
            this.btnChoice.Click += new System.EventHandler(this.btnChoice_Click);
            // 
            // txtWidePixel
            // 
            this.txtWidePixel.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtWidePixel.Location = new System.Drawing.Point(198, 70);
            this.txtWidePixel.Multiline = true;
            this.txtWidePixel.Name = "txtWidePixel";
            this.txtWidePixel.Size = new System.Drawing.Size(120, 30);
            this.txtWidePixel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(196, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "横向像素";
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(80, 140);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(80, 60);
            this.btnSavePath.TabIndex = 3;
            this.btnSavePath.Text = "存储路径";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // btnExecuteCutting
            // 
            this.btnExecuteCutting.Location = new System.Drawing.Point(80, 240);
            this.btnExecuteCutting.Name = "btnExecuteCutting";
            this.btnExecuteCutting.Size = new System.Drawing.Size(80, 60);
            this.btnExecuteCutting.TabIndex = 4;
            this.btnExecuteCutting.Text = "开始缩放";
            this.btnExecuteCutting.UseVisualStyleBackColor = true;
            this.btnExecuteCutting.Click += new System.EventHandler(this.btnExecuteCutting_Click);
            // 
            // btnOpenSavePath
            // 
            this.btnOpenSavePath.Location = new System.Drawing.Point(80, 340);
            this.btnOpenSavePath.Name = "btnOpenSavePath";
            this.btnOpenSavePath.Size = new System.Drawing.Size(80, 60);
            this.btnOpenSavePath.TabIndex = 5;
            this.btnOpenSavePath.Text = "打开\r\n文件夹";
            this.btnOpenSavePath.UseVisualStyleBackColor = true;
            // 
            // txtChoicePath
            // 
            this.txtChoicePath.Enabled = false;
            this.txtChoicePath.Location = new System.Drawing.Point(369, 60);
            this.txtChoicePath.Multiline = true;
            this.txtChoicePath.Name = "txtChoicePath";
            this.txtChoicePath.Size = new System.Drawing.Size(500, 140);
            this.txtChoicePath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "选择文件路径";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "存储文件路径";
            // 
            // txtSavePath
            // 
            this.txtSavePath.Enabled = false;
            this.txtSavePath.Location = new System.Drawing.Point(369, 260);
            this.txtSavePath.Multiline = true;
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(500, 140);
            this.txtSavePath.TabIndex = 10;
            // 
            // txtSaveFolder
            // 
            this.txtSaveFolder.Enabled = false;
            this.txtSaveFolder.Location = new System.Drawing.Point(198, 140);
            this.txtSaveFolder.Multiline = true;
            this.txtSaveFolder.Name = "txtSaveFolder";
            this.txtSaveFolder.Size = new System.Drawing.Size(120, 60);
            this.txtSaveFolder.TabIndex = 11;
            // 
            // btnCleanChoice
            // 
            this.btnCleanChoice.Location = new System.Drawing.Point(794, 30);
            this.btnCleanChoice.Name = "btnCleanChoice";
            this.btnCleanChoice.Size = new System.Drawing.Size(75, 20);
            this.btnCleanChoice.TabIndex = 12;
            this.btnCleanChoice.Text = "清空";
            this.btnCleanChoice.UseVisualStyleBackColor = true;
            this.btnCleanChoice.Click += new System.EventHandler(this.btnCleanChoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnCleanChoice);
            this.Controls.Add(this.txtSaveFolder);
            this.Controls.Add(this.txtSavePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChoicePath);
            this.Controls.Add(this.btnOpenSavePath);
            this.Controls.Add(this.btnExecuteCutting);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWidePixel);
            this.Controls.Add(this.btnChoice);
            this.Name = "Form1";
            this.Text = "图片缩放";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoice;
        private System.Windows.Forms.TextBox txtWidePixel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Button btnExecuteCutting;
        private System.Windows.Forms.Button btnOpenSavePath;
        private System.Windows.Forms.TextBox txtChoicePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.TextBox txtSaveFolder;
        private System.Windows.Forms.Button btnCleanChoice;
    }
}


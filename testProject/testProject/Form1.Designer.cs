﻿namespace com
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest1 = new System.Windows.Forms.Button();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTestOdbc = new System.Windows.Forms.Button();
            this.btnTestService1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(25, 107);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(75, 23);
            this.btnTest1.TabIndex = 0;
            this.btnTest1.Text = "button1";
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(25, 52);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(100, 21);
            this.tbClientName.TabIndex = 1;
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(25, 216);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 2;
            this.btnTest2.Text = "btnTest2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTestOdbc
            // 
            this.btnTestOdbc.Location = new System.Drawing.Point(25, 267);
            this.btnTestOdbc.Name = "btnTestOdbc";
            this.btnTestOdbc.Size = new System.Drawing.Size(75, 23);
            this.btnTestOdbc.TabIndex = 3;
            this.btnTestOdbc.Text = "btnTestOdbc";
            this.btnTestOdbc.UseVisualStyleBackColor = true;
            this.btnTestOdbc.Click += new System.EventHandler(this.btnTestOdbc_Click);
            // 
            // btnTestService1
            // 
            this.btnTestService1.Location = new System.Drawing.Point(25, 319);
            this.btnTestService1.Name = "btnTestService1";
            this.btnTestService1.Size = new System.Drawing.Size(75, 23);
            this.btnTestService1.TabIndex = 4;
            this.btnTestService1.Text = "btnTestService1";
            this.btnTestService1.UseVisualStyleBackColor = true;
            this.btnTestService1.Click += new System.EventHandler(this.btnTestService1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 413);
            this.Controls.Add(this.btnTestService1);
            this.Controls.Add(this.btnTestOdbc);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.btnTest1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTestOdbc;
        private System.Windows.Forms.Button btnTestService1;
    }
}


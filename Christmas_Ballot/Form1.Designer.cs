namespace Christmas_Ballot
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.butt_run = new System.Windows.Forms.Button();
            this.butt_rebuild = new System.Windows.Forms.Button();
            this.textstart = new System.Windows.Forms.TextBox();
            this.textend = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.butt_toright = new System.Windows.Forms.Button();
            this.butt_toleft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("新細明體", 20F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(12, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 436);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 475F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(307, 12);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(689, 577);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butt_run
            // 
            this.butt_run.Font = new System.Drawing.Font("新細明體", 30F);
            this.butt_run.Location = new System.Drawing.Point(155, 18);
            this.butt_run.Name = "butt_run";
            this.butt_run.Size = new System.Drawing.Size(114, 88);
            this.butt_run.TabIndex = 2;
            this.butt_run.Text = "抽！";
            this.butt_run.UseVisualStyleBackColor = true;
            // 
            // butt_rebuild
            // 
            this.butt_rebuild.Location = new System.Drawing.Point(84, 74);
            this.butt_rebuild.Name = "butt_rebuild";
            this.butt_rebuild.Size = new System.Drawing.Size(42, 32);
            this.butt_rebuild.TabIndex = 3;
            this.butt_rebuild.Text = "重建";
            this.butt_rebuild.UseVisualStyleBackColor = true;
            // 
            // textstart
            // 
            this.textstart.Location = new System.Drawing.Point(65, 18);
            this.textstart.Name = "textstart";
            this.textstart.Size = new System.Drawing.Size(55, 22);
            this.textstart.TabIndex = 4;
            // 
            // textend
            // 
            this.textend.Location = new System.Drawing.Point(65, 46);
            this.textend.Name = "textend";
            this.textend.Size = new System.Drawing.Size(55, 22);
            this.textend.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("新細明體", 20F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 27;
            this.listBox2.Location = new System.Drawing.Point(167, 24);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 436);
            this.listBox2.TabIndex = 6;
            // 
            // butt_toright
            // 
            this.butt_toright.Location = new System.Drawing.Point(138, 136);
            this.butt_toright.Name = "butt_toright";
            this.butt_toright.Size = new System.Drawing.Size(23, 23);
            this.butt_toright.TabIndex = 7;
            this.butt_toright.Text = ">";
            this.butt_toright.UseVisualStyleBackColor = true;
            // 
            // butt_toleft
            // 
            this.butt_toleft.Location = new System.Drawing.Point(138, 282);
            this.butt_toleft.Name = "butt_toleft";
            this.butt_toleft.Size = new System.Drawing.Size(23, 23);
            this.butt_toleft.TabIndex = 8;
            this.butt_toleft.Text = "<";
            this.butt_toleft.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "未抽區";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "已抽區";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "起始碼：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "結束碼：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textstart);
            this.groupBox1.Controls.Add(this.textend);
            this.groupBox1.Controls.Add(this.butt_run);
            this.groupBox1.Controls.Add(this.butt_rebuild);
            this.groupBox1.Location = new System.Drawing.Point(12, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 112);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 90);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "關閉音效";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "省時模式";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butt_toleft);
            this.Controls.Add(this.butt_toright);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "Form1";
            this.Text = "抽籤機";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button butt_run;
        private System.Windows.Forms.Button butt_rebuild;
        private System.Windows.Forms.TextBox textstart;
        private System.Windows.Forms.TextBox textend;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button butt_toright;
        private System.Windows.Forms.Button butt_toleft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}


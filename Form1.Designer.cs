namespace FileRenamerProject
{
    partial class MainForm
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
            this.browseFolder_btn = new System.Windows.Forms.Button();
            this.apply_btn = new System.Windows.Forms.Button();
            this.containWord_lbl = new System.Windows.Forms.Label();
            this.Replace_lbl = new System.Windows.Forms.Label();
            this.contain_tbx = new System.Windows.Forms.TextBox();
            this.replace_tbx = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBar_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.test_tbx = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseFolder_btn
            // 
            this.browseFolder_btn.Location = new System.Drawing.Point(43, 277);
            this.browseFolder_btn.Margin = new System.Windows.Forms.Padding(4);
            this.browseFolder_btn.Name = "browseFolder_btn";
            this.browseFolder_btn.Size = new System.Drawing.Size(100, 28);
            this.browseFolder_btn.TabIndex = 0;
            this.browseFolder_btn.Text = "Browse";
            this.browseFolder_btn.UseVisualStyleBackColor = true;
            this.browseFolder_btn.Click += new System.EventHandler(this.BrowseFolder_btn_Click);
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(281, 277);
            this.apply_btn.Margin = new System.Windows.Forms.Padding(4);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(100, 28);
            this.apply_btn.TabIndex = 1;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // containWord_lbl
            // 
            this.containWord_lbl.AutoSize = true;
            this.containWord_lbl.Location = new System.Drawing.Point(35, 34);
            this.containWord_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.containWord_lbl.Name = "containWord_lbl";
            this.containWord_lbl.Size = new System.Drawing.Size(102, 17);
            this.containWord_lbl.TabIndex = 2;
            this.containWord_lbl.Text = "Contain Word :";
            // 
            // Replace_lbl
            // 
            this.Replace_lbl.AutoSize = true;
            this.Replace_lbl.Location = new System.Drawing.Point(39, 101);
            this.Replace_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Replace_lbl.Name = "Replace_lbl";
            this.Replace_lbl.Size = new System.Drawing.Size(100, 17);
            this.Replace_lbl.TabIndex = 3;
            this.Replace_lbl.Text = "Replace With :";
            // 
            // contain_tbx
            // 
            this.contain_tbx.Location = new System.Drawing.Point(185, 34);
            this.contain_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.contain_tbx.Name = "contain_tbx";
            this.contain_tbx.Size = new System.Drawing.Size(195, 22);
            this.contain_tbx.TabIndex = 6;
            // 
            // replace_tbx
            // 
            this.replace_tbx.Location = new System.Drawing.Point(185, 101);
            this.replace_tbx.Margin = new System.Windows.Forms.Padding(4);
            this.replace_tbx.Name = "replace_tbx";
            this.replace_tbx.Size = new System.Drawing.Size(191, 22);
            this.replace_tbx.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(43, 165);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "CaseSensitive Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(281, 165);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 21);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "File Mode";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(43, 215);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(162, 21);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "SubFolder Replacing";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusBar_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(429, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 20);
            this.toolStripStatusLabel1.Text = "Selected Path:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.ToolStripStatusLabel1_Click);
            // 
            // statusBar_lbl
            // 
            this.statusBar_lbl.Name = "statusBar_lbl";
            this.statusBar_lbl.Size = new System.Drawing.Size(0, 20);
            // 
            // test_tbx
            // 
            this.test_tbx.Location = new System.Drawing.Point(43, 348);
            this.test_tbx.Multiline = true;
            this.test_tbx.Name = "test_tbx";
            this.test_tbx.Size = new System.Drawing.Size(338, 123);
            this.test_tbx.TabIndex = 12;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 511);
            this.Controls.Add(this.test_tbx);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.replace_tbx);
            this.Controls.Add(this.contain_tbx);
            this.Controls.Add(this.Replace_lbl);
            this.Controls.Add(this.containWord_lbl);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.browseFolder_btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "FileRenamer V 0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseFolder_btn;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.Label containWord_lbl;
        private System.Windows.Forms.Label Replace_lbl;
        private System.Windows.Forms.TextBox contain_tbx;
        private System.Windows.Forms.TextBox replace_tbx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_lbl;
        private System.Windows.Forms.TextBox test_tbx;
    }
}


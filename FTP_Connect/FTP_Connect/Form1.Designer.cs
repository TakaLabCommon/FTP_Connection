
namespace FTP_Connect
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextboxIP = new System.Windows.Forms.TextBox();
            this.TextboxID = new System.Windows.Forms.TextBox();
            this.TextboxPass = new System.Windows.Forms.TextBox();
            this.ButtonDownload = new System.Windows.Forms.Button();
            this.ButtonRef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextboxCopyTo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabpageDownload = new System.Windows.Forms.TabPage();
            this.TabpageUpload = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabpageDownload.SuspendLayout();
            this.TabpageUpload.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextboxIP
            // 
            this.TextboxIP.Location = new System.Drawing.Point(74, 42);
            this.TextboxIP.Name = "TextboxIP";
            this.TextboxIP.Size = new System.Drawing.Size(147, 23);
            this.TextboxIP.TabIndex = 0;
            // 
            // TextboxID
            // 
            this.TextboxID.Location = new System.Drawing.Point(74, 74);
            this.TextboxID.Name = "TextboxID";
            this.TextboxID.Size = new System.Drawing.Size(147, 23);
            this.TextboxID.TabIndex = 1;
            // 
            // TextboxPass
            // 
            this.TextboxPass.Location = new System.Drawing.Point(74, 103);
            this.TextboxPass.Name = "TextboxPass";
            this.TextboxPass.PasswordChar = '*';
            this.TextboxPass.Size = new System.Drawing.Size(147, 23);
            this.TextboxPass.TabIndex = 2;
            // 
            // ButtonDownload
            // 
            this.ButtonDownload.Location = new System.Drawing.Point(194, 5);
            this.ButtonDownload.Name = "ButtonDownload";
            this.ButtonDownload.Size = new System.Drawing.Size(102, 26);
            this.ButtonDownload.TabIndex = 3;
            this.ButtonDownload.Text = "ダウンロード";
            this.ButtonDownload.UseVisualStyleBackColor = true;
            this.ButtonDownload.Click += new System.EventHandler(this.ButtonDownload_Click);
            // 
            // ButtonRef
            // 
            this.ButtonRef.Location = new System.Drawing.Point(332, 198);
            this.ButtonRef.Name = "ButtonRef";
            this.ButtonRef.Size = new System.Drawing.Size(76, 23);
            this.ButtonRef.TabIndex = 4;
            this.ButtonRef.Text = "参照";
            this.ButtonRef.UseVisualStyleBackColor = true;
            this.ButtonRef.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "接続先";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "保存先";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // TextboxCopyTo
            // 
            this.TextboxCopyTo.Location = new System.Drawing.Point(43, 198);
            this.TextboxCopyTo.Name = "TextboxCopyTo";
            this.TextboxCopyTo.Size = new System.Drawing.Size(281, 23);
            this.TextboxCopyTo.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(392, 159);
            this.textBox1.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabpageDownload);
            this.tabControl1.Controls.Add(this.TabpageUpload);
            this.tabControl1.Location = new System.Drawing.Point(12, 132);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 64);
            this.tabControl1.TabIndex = 12;
            // 
            // TabpageDownload
            // 
            this.TabpageDownload.Controls.Add(this.ButtonDownload);
            this.TabpageDownload.Controls.Add(this.label2);
            this.TabpageDownload.Location = new System.Drawing.Point(4, 24);
            this.TabpageDownload.Name = "TabpageDownload";
            this.TabpageDownload.Padding = new System.Windows.Forms.Padding(3);
            this.TabpageDownload.Size = new System.Drawing.Size(308, 36);
            this.TabpageDownload.TabIndex = 0;
            this.TabpageDownload.Text = "ダウンロード";
            this.TabpageDownload.UseVisualStyleBackColor = true;
            // 
            // TabpageUpload
            // 
            this.TabpageUpload.Controls.Add(this.button1);
            this.TabpageUpload.Controls.Add(this.label6);
            this.TabpageUpload.Location = new System.Drawing.Point(4, 24);
            this.TabpageUpload.Name = "TabpageUpload";
            this.TabpageUpload.Padding = new System.Windows.Forms.Padding(3);
            this.TabpageUpload.Size = new System.Drawing.Size(308, 36);
            this.TabpageUpload.TabIndex = 1;
            this.TabpageUpload.Text = "アップロード";
            this.TabpageUpload.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "元ファイル";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "ダウンロード";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 432);
            this.Controls.Add(this.TextboxCopyTo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ButtonRef);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxPass);
            this.Controls.Add(this.TextboxID);
            this.Controls.Add(this.TextboxIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabpageDownload.ResumeLayout(false);
            this.TabpageDownload.PerformLayout();
            this.TabpageUpload.ResumeLayout(false);
            this.TabpageUpload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextboxIP;
        private System.Windows.Forms.TextBox TextboxID;
        private System.Windows.Forms.TextBox TextboxPass;
        private System.Windows.Forms.Button ButtonDownload;
        private System.Windows.Forms.Button ButtonRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextboxCopyTo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabpageDownload;
        private System.Windows.Forms.TabPage TabpageUpload;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}


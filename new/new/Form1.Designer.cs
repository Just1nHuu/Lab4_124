namespace @new
{
    partial class Form1
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
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.btn_Download = new System.Windows.Forms.Button();
            this.rtxt_HTML = new System.Windows.Forms.RichTextBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Url
            // 
            this.txt_Url.Location = new System.Drawing.Point(17, 17);
            this.txt_Url.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(503, 22);
            this.txt_Url.TabIndex = 0;
            this.txt_Url.Text = "https://www.uit.edu.vn/";
            // 
            // btn_Download
            // 
            this.btn_Download.Location = new System.Drawing.Point(529, 16);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(100, 28);
            this.btn_Download.TabIndex = 1;
            this.btn_Download.Text = "Download";
            this.btn_Download.UseVisualStyleBackColor = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // rtxt_HTML
            // 
            this.rtxt_HTML.BackColor = System.Drawing.Color.White;
            this.rtxt_HTML.Location = new System.Drawing.Point(17, 81);
            this.rtxt_HTML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxt_HTML.Name = "rtxt_HTML";
            this.rtxt_HTML.ReadOnly = true;
            this.rtxt_HTML.Size = new System.Drawing.Size(611, 347);
            this.rtxt_HTML.TabIndex = 2;
            this.rtxt_HTML.Text = "";
            // 
            // txt_Path
            // 
            this.txt_Path.Location = new System.Drawing.Point(17, 49);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(503, 22);
            this.txt_Path.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.txt_Path);
            this.Controls.Add(this.rtxt_HTML);
            this.Controls.Add(this.btn_Download);
            this.Controls.Add(this.txt_Url);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_Download;
        private System.Windows.Forms.RichTextBox rtxt_HTML;
        private System.Windows.Forms.TextBox txt_Path;
    }
}


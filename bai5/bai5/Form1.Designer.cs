using System.Drawing;
using System.Windows.Forms;

namespace bai5
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
            this.url = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_response = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(28, 42);
            this.url.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(37, 16);
            this.url.TabIndex = 0;
            this.url.Text = "URL:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(28, 90);
            this.email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(70, 16);
            this.email.TabIndex = 1;
            this.email.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(28, 146);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(70, 16);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(130, 142);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(2);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(306, 22);
            this.txt_pass.TabIndex = 3;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(130, 86);
            this.txt_email.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(306, 22);
            this.txt_email.TabIndex = 4;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(130, 38);
            this.txt_url.Margin = new System.Windows.Forms.Padding(2);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(426, 22);
            this.txt_url.TabIndex = 5;
            // 
            // txt_response
            // 
            this.txt_response.Location = new System.Drawing.Point(28, 181);
            this.txt_response.Margin = new System.Windows.Forms.Padding(2);
            this.txt_response.Name = "txt_response";
            this.txt_response.Size = new System.Drawing.Size(528, 147);
            this.txt_response.TabIndex = 6;
            this.txt_response.Text = "";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(505, 90);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(111, 67);
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "LOGIN";
            this.btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 368);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txt_response);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.url);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label url;
        private Label email;
        private Label password;
        private TextBox txt_pass;
        private TextBox txt_email;
        private TextBox txt_url;
        private RichTextBox txt_response;
        private Button btnPost;
    }
}


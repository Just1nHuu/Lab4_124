using System.Drawing;
using System.Windows.Forms;

namespace bai6
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
            this.name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
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
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(28, 90);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Username";
         
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
            this.txt_pass.Size = new System.Drawing.Size(292, 22);
            this.txt_pass.TabIndex = 3;
       
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(130, 86);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(292, 22);
            this.txt_name.TabIndex = 4;
           
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
            this.txt_response.Size = new System.Drawing.Size(509, 164);
            this.txt_response.TabIndex = 6;
            this.txt_response.Text = "";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(522, 86);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(85, 72);
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 368);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txt_response);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.url);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label url;
        private Label name;
        private Label password;
        private TextBox txt_pass;
        private TextBox txt_name;
        private TextBox txt_url;
        private RichTextBox txt_response;
        private Button btnPost;
    }
}


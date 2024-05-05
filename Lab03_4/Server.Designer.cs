namespace Lab03_4
{
    partial class Server
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
            button1 = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(257, 278);
            button1.Name = "button1";
            button1.Size = new Size(119, 39);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(364, 234);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 329);
            Controls.Add(listView1);
            Controls.Add(button1);
            Name = "Server";
            Text = "Server Cinema";
            Load += Server_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private RichTextBox richTextBox1;
        private ListView listView1;
    }
}
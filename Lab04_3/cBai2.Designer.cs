namespace Lab04
{
    partial class cBai2
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(98, 16);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 34);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(397, 58);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 43);
            button1.TabIndex = 1;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(38, 28);
            label1.TabIndex = 3;
            label1.Text = "Url";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 3;
            label2.Text = "Path filer";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(98, 63);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 34);
            textBox2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(250, 576);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(135, 43);
            button3.TabIndex = 1;
            button3.Text = "Down Files";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button2_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(131, 576);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(113, 43);
            button2.TabIndex = 1;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button4_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(12, 576);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(113, 43);
            button4.TabIndex = 1;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button3_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(391, 576);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(185, 43);
            button5.TabIndex = 1;
            button5.Text = "Down Resources";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 12F);
            richTextBox1.Location = new Point(12, 110);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(564, 458);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // cBai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 632);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "cBai2";
            Text = "Bài 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private RichTextBox richTextBox1;
    }
}

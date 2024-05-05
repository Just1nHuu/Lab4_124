namespace Lab04
{
    partial class cDanhSach
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(76, 103);
            button1.Name = "button1";
            button1.Size = new Size(106, 47);
            button1.TabIndex = 0;
            button1.Text = "Bài tập 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(212, 103);
            button2.Name = "button2";
            button2.Size = new Size(106, 47);
            button2.TabIndex = 0;
            button2.Text = "Bài tập 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(346, 103);
            button3.Name = "button3";
            button3.Size = new Size(106, 47);
            button3.TabIndex = 0;
            button3.Text = "Bài tập 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(76, 192);
            button4.Name = "button4";
            button4.Size = new Size(106, 47);
            button4.TabIndex = 0;
            button4.Text = "Bài tập 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(212, 192);
            button5.Name = "button5";
            button5.Size = new Size(106, 47);
            button5.TabIndex = 0;
            button5.Text = "Bài tập 5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(346, 192);
            button6.Name = "button6";
            button6.Size = new Size(106, 47);
            button6.TabIndex = 0;
            button6.Text = "Bài tập 6";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(121, 31);
            label1.Name = "label1";
            label1.Size = new Size(292, 38);
            label1.TabIndex = 1;
            label1.Text = "Bài tập thực hành số 4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 266);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Danh sách các bài tập ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
    }
}
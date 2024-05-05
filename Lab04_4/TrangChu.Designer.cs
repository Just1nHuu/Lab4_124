namespace Lab04_4
{
    partial class TrangChu
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(40, 19);
            label1.Name = "label1";
            label1.Size = new Size(320, 54);
            label1.TabIndex = 0;
            label1.Text = "Phim đang chiếu";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(42, 83);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(635, 444);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // pBar
            // 
            pBar.Location = new Point(40, 546);
            pBar.Name = "pBar";
            pBar.Size = new Size(637, 29);
            pBar.TabIndex = 2;
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 592);
            Controls.Add(pBar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "TrangChu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bài 4";
            Load += TrangChu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ProgressBar pBar;
    }
}

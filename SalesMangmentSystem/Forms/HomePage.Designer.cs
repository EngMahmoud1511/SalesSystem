namespace SalesMangmentSystem
{
    partial class HomePage
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button1.Location = new Point(788, 16);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(105, 37);
            button1.TabIndex = 0;
            button1.Text = "المنتجات";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button2.Location = new Point(669, 16);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(86, 37);
            button2.TabIndex = 0;
            button2.Text = "الاصناف";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button3.Location = new Point(559, 16);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(86, 37);
            button3.TabIndex = 0;
            button3.Text = "العملاء";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button4.Location = new Point(306, 16);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(104, 37);
            button4.TabIndex = 0;
            button4.Text = "المبيعات";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(128, 128, 255);
            button5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button5.Location = new Point(46, 16);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(113, 37);
            button5.TabIndex = 0;
            button5.Text = " تسجيل خروج";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(128, 128, 255);
            button6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            button6.Location = new Point(427, 16);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(108, 37);
            button6.TabIndex = 0;
            button6.Text = "المشتريات";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(128, 128, 255);
            button7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(175, 16);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(116, 37);
            button7.TabIndex = 1;
            button7.Text = "أضافه موظف";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 565);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomePage";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}

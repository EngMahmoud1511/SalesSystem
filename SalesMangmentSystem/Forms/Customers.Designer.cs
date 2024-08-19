namespace SalesMangmentSystem
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.Location = new Point(193, 336);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button1.Location = new Point(805, 552);
            button1.Name = "button1";
            button1.Size = new Size(89, 30);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(50, 343);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 2;
            label1.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Silver;
            label4.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(52, 380);
            label4.Name = "label4";
            label4.Size = new Size(94, 21);
            label4.TabIndex = 5;
            label4.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Silver;
            textBox2.Location = new Point(193, 379);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(131, 23);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Silver;
            label5.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold);
            label5.Location = new Point(281, 473);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 3;
            label5.Text = "Type";
            label5.Click += label5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Silver;
            checkBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(398, 473);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 27);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Male";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Silver;
            checkBox2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(543, 476);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(91, 24);
            checkBox2.TabIndex = 6;
            checkBox2.Text = "Female";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button2.Location = new Point(604, 552);
            button2.Name = "button2";
            button2.Size = new Size(89, 30);
            button2.TabIndex = 1;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button3.Location = new Point(298, 552);
            button3.Name = "button3";
            button3.Size = new Size(95, 30);
            button3.TabIndex = 1;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gray;
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            button4.Location = new Point(83, 552);
            button4.Name = "button4";
            button4.Size = new Size(89, 30);
            button4.TabIndex = 1;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(298, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(495, 242);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(539, 340);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 11;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(543, 396);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 10;
            label2.Text = "Civil No";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.Silver;
            textBox4.Location = new Point(653, 394);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(131, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Silver;
            textBox3.Location = new Point(653, 340);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 9;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1039, 649);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Customers";
            Text = "Customers";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
    }
}
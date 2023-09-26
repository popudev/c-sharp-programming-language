namespace Week4
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
            button1 = new Button();
            Line = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(28, 355);
            button1.Name = "button1";
            button1.Size = new Size(244, 74);
            button1.TabIndex = 0;
            button1.Text = "Thực Hiện";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Line
            // 
            Line.AutoSize = true;
            Line.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Line.ForeColor = Color.Red;
            Line.Location = new Point(210, 35);
            Line.Name = "Line";
            Line.Size = new Size(405, 35);
            Line.TabIndex = 2;
            Line.Text = "Ước Số Chung - Bội Số Chung";
            // 
            // button2
            // 
            button2.Location = new Point(528, 355);
            button2.Name = "button2";
            button2.Size = new Size(244, 74);
            button2.TabIndex = 3;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(278, 355);
            button3.Name = "button3";
            button3.Size = new Size(244, 74);
            button3.TabIndex = 4;
            button3.Text = "Tiếp Tục";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(193, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 257);
            panel1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 27);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(298, 137);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 27);
            textBox3.TabIndex = 8;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(298, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(110, 27);
            textBox4.TabIndex = 9;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 49);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 10;
            label1.Text = "Nhập số a :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 91);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 11;
            label2.Text = "Nhập số b :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 144);
            label3.Name = "label3";
            label3.Size = new Size(198, 22);
            label3.TabIndex = 12;
            label3.Text = "Ước số chung lớn nhất :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 192);
            label4.Name = "label4";
            label4.Size = new Size(193, 22);
            label4.TabIndex = 13;
            label4.Text = "Bội số chung nhỏ nhất :\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Line);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label Line;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
namespace Week4
{
    partial class Bai1
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
            components = new System.ComponentModel.Container();
            button_TH = new Button();
            Line = new Label();
            buttonT = new Button();
            buttonTT = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            bcnn = new TextBox();
            ucln = new TextBox();
            soB = new TextBox();
            soA = new TextBox();
           
            SuspendLayout();
            // 
            // button_TH
            // 
            button_TH.Location = new Point(23, 320);
            button_TH.Margin = new Padding(3, 2, 3, 2);
            button_TH.Name = "button_TH";
            button_TH.Size = new Size(214, 56);
            button_TH.TabIndex = 0;
            button_TH.Text = "Thực Hiện";
            button_TH.UseVisualStyleBackColor = true;
            button_TH.Click += button1_Click;
            // 
            // Line
            // 
            Line.AutoSize = true;
            Line.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Line.ForeColor = Color.Red;
            Line.Location = new Point(184, 26);
            Line.Name = "Line";
            Line.Size = new Size(320, 26);
            Line.TabIndex = 2;
            Line.Text = "Ước Số Chung - Bội Số Chung";
            // 
            // buttonT
            // 
            buttonT.Location = new Point(463, 320);
            buttonT.Margin = new Padding(3, 2, 3, 2);
            buttonT.Name = "buttonT";
            buttonT.Size = new Size(214, 56);
            buttonT.TabIndex = 3;
            buttonT.Text = "Thoát";
            buttonT.UseVisualStyleBackColor = true;
            buttonT.Click += buttonT_Click;
            // 
            // buttonTT
            // 
            buttonTT.Location = new Point(243, 320);
            buttonTT.Margin = new Padding(3, 2, 3, 2);
            buttonTT.Name = "buttonTT";
            buttonTT.Size = new Size(214, 56);
            buttonTT.TabIndex = 4;
            buttonTT.Text = "Tiếp Tục";
            buttonTT.UseVisualStyleBackColor = true;
            buttonTT.Click += buttonTT_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(bcnn);
            panel1.Controls.Add(ucln);
            panel1.Controls.Add(soB);
            panel1.Controls.Add(soA);
            panel1.Location = new Point(169, 69);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 193);
            panel1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 144);
            label4.Name = "label4";
            label4.Size = new Size(149, 19);
            label4.TabIndex = 13;
            label4.Text = "Bội số chung nhỏ nhất :\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 108);
            label3.Name = "label3";
            label3.Size = new Size(151, 19);
            label3.TabIndex = 12;
            label3.Text = "Ước số chung lớn nhất :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 68);
            label2.Name = "label2";
            label2.Size = new Size(80, 19);
            label2.TabIndex = 11;
            label2.Text = "Nhập số b :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 37);
            label1.Name = "label1";
            label1.Size = new Size(79, 19);
            label1.TabIndex = 10;
            label1.Text = "Nhập số a :";
            label1.Click += label1_Click;
            // 
            // bcnn
            // 
            bcnn.Enabled = false;
            bcnn.Location = new Point(261, 139);
            bcnn.Margin = new Padding(3, 2, 3, 2);
            bcnn.Name = "bcnn";
            bcnn.Size = new Size(97, 23);
            bcnn.TabIndex = 9;
            bcnn.TextChanged += textBox4_TextChanged;
            // 
            // ucln
            // 
            ucln.Enabled = false;
            ucln.Location = new Point(261, 103);
            ucln.Margin = new Padding(3, 2, 3, 2);
            ucln.Name = "ucln";
            ucln.Size = new Size(97, 23);
            ucln.TabIndex = 8;
            ucln.TextChanged += textBox3_TextChanged;
            // 
            // soB
            // 
            soB.Location = new Point(173, 66);
            soB.Margin = new Padding(3, 2, 3, 2);
            soB.Name = "soB";
            soB.Size = new Size(184, 23);
            soB.TabIndex = 2;
            soB.TextChanged += textBox2_TextChanged;
            // 
            // soA
            // 
            soA.Location = new Point(173, 32);
            soA.Margin = new Padding(3, 2, 3, 2);
            soA.Name = "soA";
            soA.Size = new Size(184, 23);
            soA.TabIndex = 1;
            soA.TextChanged += textBox1_TextChanged;
            // 
            // errorA
            // 
          
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 436);
            Controls.Add(panel1);
            Controls.Add(buttonTT);
            Controls.Add(buttonT);
            Controls.Add(Line);
            Controls.Add(button_TH);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
         
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_TH;
        private Label Line;
        private Button buttonT;
        private Button buttonTT;
        private Panel panel1;
        private TextBox bcnn;
        private TextBox ucln;
        private TextBox soB;
        private TextBox soA;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private ErrorProvider errA;
        private ErrorProvider errB;

    }
}
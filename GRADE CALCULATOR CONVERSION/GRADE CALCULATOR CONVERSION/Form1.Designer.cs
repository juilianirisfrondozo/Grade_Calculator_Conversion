namespace GRADE_CALCULATOR_CONVERSION
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            Button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 28);
            label1.Name = "label1";
            label1.Size = new Size(810, 56);
            label1.TabIndex = 0;
            label1.Text = "GRADE CALCULATOR PROGRAM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 30);
            label2.Name = "label2";
            label2.Size = new Size(170, 35);
            label2.TabIndex = 1;
            label2.Text = "EQUIVALENCE";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(74, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 53);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(85, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 53);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(45, 318);
            button1.Name = "button1";
            button1.Size = new Size(275, 36);
            button1.TabIndex = 4;
            button1.Text = "Conversion of if then else";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(67, 317);
            button2.Name = "button2";
            button2.Size = new Size(259, 36);
            button2.TabIndex = 5;
            button2.Text = "Conversion in Select Case";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Button3
            // 
            Button3.BackColor = Color.Ivory;
            Button3.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Button3.ForeColor = Color.Red;
            Button3.Location = new Point(223, 553);
            Button3.Name = "Button3";
            Button3.Size = new Size(490, 52);
            Button3.TabIndex = 6;
            Button3.Text = "EXIT";
            Button3.UseVisualStyleBackColor = false;
            Button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(116, 29);
            label3.Name = "label3";
            label3.Size = new Size(170, 35);
            label3.TabIndex = 7;
            label3.Text = "EQUIVALENCE";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 188);
            label4.Name = "label4";
            label4.Size = new Size(308, 35);
            label4.TabIndex = 8;
            label4.Text = "Enter Grade to Compute";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Impact", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(39, 187);
            label5.Name = "label5";
            label5.Size = new Size(308, 35);
            label5.TabIndex = 9;
            label5.Text = "Enter Grade to Compute";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(74, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(216, 53);
            textBox3.TabIndex = 10;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(71, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 391);
            panel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(516, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(388, 390);
            panel2.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Impact", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(85, 247);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(216, 53);
            textBox4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 148);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 11;
            label6.Text = ".";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 147);
            label7.Name = "label7";
            label7.Size = new Size(12, 20);
            label7.TabIndex = 10;
            label7.Text = ".";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(945, 632);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Button3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "GRADE CALCULATOR";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button Button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
    }
}

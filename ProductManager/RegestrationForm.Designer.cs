namespace ProductManager
{
    partial class RegestrationForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(98, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(98, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(98, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 23);
            textBox4.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(98, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(98, 220);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 22);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 66);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Surname";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 107);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Birt Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 147);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 186);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "E-mail";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 314);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Ballance";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(113, 366);
            button1.Name = "button1";
            button1.Size = new Size(132, 31);
            button1.TabIndex = 12;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(98, 266);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(98, 311);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 23);
            textBox7.TabIndex = 14;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 223);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 15;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 269);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 16;
            label8.Text = "Password";
            // 
            // RegestrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 439);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "RegestrationForm";
            Text = "Regestration Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
    }
}
namespace ProductManager
{
    partial class LoginForm
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
            btn_LoginUser = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            btn_BackToLoginOrRegestration = new Button();
            SuspendLayout();
            // 
            // btn_LoginUser
            // 
            btn_LoginUser.BackColor = Color.DeepSkyBlue;
            btn_LoginUser.Location = new Point(79, 166);
            btn_LoginUser.Name = "btn_LoginUser";
            btn_LoginUser.Size = new Size(134, 44);
            btn_LoginUser.TabIndex = 15;
            btn_LoginUser.Text = "Log in";
            btn_LoginUser.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 23);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 23);
            textBox2.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 20;
            label1.Text = "Email";
            // 
            // btn_BackToLoginOrRegestration
            // 
            btn_BackToLoginOrRegestration.BackColor = SystemColors.ActiveCaption;
            btn_BackToLoginOrRegestration.Location = new Point(191, 248);
            btn_BackToLoginOrRegestration.Name = "btn_BackToLoginOrRegestration";
            btn_BackToLoginOrRegestration.Size = new Size(92, 35);
            btn_BackToLoginOrRegestration.TabIndex = 43;
            btn_BackToLoginOrRegestration.Text = "Back ";
            btn_BackToLoginOrRegestration.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 295);
            Controls.Add(btn_BackToLoginOrRegestration);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(btn_LoginUser);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_LoginUser;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button btn_BackToLoginOrRegestration;
    }
}

namespace ProductManager
{
    partial class LogInOrRegestrationForm
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
            btn_Login = new Button();
            btn_Regestration = new Button();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.PaleTurquoise;
            btn_Login.Location = new Point(48, 47);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(157, 45);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Log In";
            btn_Login.UseVisualStyleBackColor = false;
            // 
            // btn_Regestration
            // 
            btn_Regestration.BackColor = Color.DodgerBlue;
            btn_Regestration.Location = new Point(48, 118);
            btn_Regestration.Name = "btn_Regestration";
            btn_Regestration.Size = new Size(157, 48);
            btn_Regestration.TabIndex = 1;
            btn_Regestration.Text = "Regestration";
            btn_Regestration.UseVisualStyleBackColor = false;
            // 
            // LogInOrRegestrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 231);
            Controls.Add(btn_Regestration);
            Controls.Add(btn_Login);
            Name = "LogInOrRegestrationForm";
            Text = "Log In or Regestration";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Login;
        private Button btn_Regestration;
    }
}
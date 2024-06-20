namespace ProductManager
{
    partial class AdminForm
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
            btn_UserManager = new Button();
            btn_Products = new Button();
            btn_BackToLogin = new Button();
            SuspendLayout();
            // 
            // btn_UserManager
            // 
            btn_UserManager.BackColor = Color.DodgerBlue;
            btn_UserManager.Location = new Point(53, 114);
            btn_UserManager.Name = "btn_UserManager";
            btn_UserManager.Size = new Size(157, 48);
            btn_UserManager.TabIndex = 3;
            btn_UserManager.Text = "User Manager";
            btn_UserManager.UseVisualStyleBackColor = false;
            // 
            // btn_Products
            // 
            btn_Products.BackColor = Color.PaleTurquoise;
            btn_Products.Location = new Point(53, 43);
            btn_Products.Name = "btn_Products";
            btn_Products.Size = new Size(157, 45);
            btn_Products.TabIndex = 2;
            btn_Products.Text = "Products Manager";
            btn_Products.UseVisualStyleBackColor = false;
            // 
            // btn_BackToLogin
            // 
            btn_BackToLogin.BackColor = SystemColors.ActiveCaption;
            btn_BackToLogin.Location = new Point(167, 177);
            btn_BackToLogin.Name = "btn_BackToLogin";
            btn_BackToLogin.Size = new Size(92, 35);
            btn_BackToLogin.TabIndex = 44;
            btn_BackToLogin.Text = "Back ";
            btn_BackToLogin.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 224);
            Controls.Add(btn_BackToLogin);
            Controls.Add(btn_UserManager);
            Controls.Add(btn_Products);
            Name = "AdminForm";
            Text = "Admin Panel";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_UserManager;
        private Button btn_Products;
        private Button btn_BackToLogin;
    }
}
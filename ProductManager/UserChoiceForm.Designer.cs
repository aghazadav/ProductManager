namespace ProductManager
{
    partial class UserChoiceForm
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
            btn_ShopUser = new Button();
            btn_AddBalanceUser = new Button();
            btn_BackToLoginForm = new Button();
            SuspendLayout();
            // 
            // btn_ShopUser
            // 
            btn_ShopUser.BackColor = Color.DodgerBlue;
            btn_ShopUser.Location = new Point(48, 116);
            btn_ShopUser.Name = "btn_ShopUser";
            btn_ShopUser.Size = new Size(157, 48);
            btn_ShopUser.TabIndex = 3;
            btn_ShopUser.Text = "Shop";
            btn_ShopUser.UseVisualStyleBackColor = false;
            // 
            // btn_AddBalanceUser
            // 
            btn_AddBalanceUser.BackColor = Color.PaleTurquoise;
            btn_AddBalanceUser.Location = new Point(48, 45);
            btn_AddBalanceUser.Name = "btn_AddBalanceUser";
            btn_AddBalanceUser.Size = new Size(157, 45);
            btn_AddBalanceUser.TabIndex = 2;
            btn_AddBalanceUser.Text = "Add Balance";
            btn_AddBalanceUser.UseVisualStyleBackColor = false;
            // 
            // btn_BackToLoginForm
            // 
            btn_BackToLoginForm.BackColor = SystemColors.ActiveCaption;
            btn_BackToLoginForm.Location = new Point(164, 204);
            btn_BackToLoginForm.Name = "btn_BackToLoginForm";
            btn_BackToLoginForm.Size = new Size(92, 35);
            btn_BackToLoginForm.TabIndex = 46;
            btn_BackToLoginForm.Text = "Back ";
            btn_BackToLoginForm.UseVisualStyleBackColor = false;
            // 
            // UserChoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 251);
            Controls.Add(btn_BackToLoginForm);
            Controls.Add(btn_ShopUser);
            Controls.Add(btn_AddBalanceUser);
            Name = "UserChoiceForm";
            Text = "User Choice";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ShopUser;
        private Button btn_AddBalanceUser;
        private Button btn_BackToLoginForm;
    }
}
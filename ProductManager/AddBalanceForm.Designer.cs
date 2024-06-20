namespace ProductManager
{
    partial class AddBalanceForm
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
            label1 = new Label();
            label2 = new Label();
            btn_AddBalanceUser = new Button();
            btn_BackToUserChoiceForm = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 28);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 2;
            label1.Text = "Current Balance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 87);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 3;
            label2.Text = "Add To Balance";
            // 
            // btn_AddBalanceUser
            // 
            btn_AddBalanceUser.BackColor = Color.PaleGreen;
            btn_AddBalanceUser.Location = new Point(83, 142);
            btn_AddBalanceUser.Name = "btn_AddBalanceUser";
            btn_AddBalanceUser.Size = new Size(125, 39);
            btn_AddBalanceUser.TabIndex = 4;
            btn_AddBalanceUser.Text = "Add Balance";
            btn_AddBalanceUser.UseVisualStyleBackColor = false;
            // 
            // btn_BackToUserChoiceForm
            // 
            btn_BackToUserChoiceForm.BackColor = SystemColors.ActiveCaption;
            btn_BackToUserChoiceForm.Location = new Point(201, 208);
            btn_BackToUserChoiceForm.Name = "btn_BackToUserChoiceForm";
            btn_BackToUserChoiceForm.Size = new Size(92, 35);
            btn_BackToUserChoiceForm.TabIndex = 46;
            btn_BackToUserChoiceForm.Text = "Back ";
            btn_BackToUserChoiceForm.UseVisualStyleBackColor = false;
            // 
            // AddBalanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 255);
            Controls.Add(btn_BackToUserChoiceForm);
            Controls.Add(btn_AddBalanceUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "AddBalanceForm";
            Text = "Add Balance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btn_AddBalanceUser;
        private Button btn_BackToUserChoiceForm;
    }
}
namespace ProductManager
{
    partial class ShopForm
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btn_AddToCart = new Button();
            btn_Payment = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            btn_DeleteFromCart = new Button();
            btn_BackToUserChoiceForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(364, 366);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(473, 68);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(363, 366);
            dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 36);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "PRODUCTS";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(473, 36);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "CART";
            // 
            // btn_AddToCart
            // 
            btn_AddToCart.BackColor = Color.PeachPuff;
            btn_AddToCart.Location = new Point(32, 451);
            btn_AddToCart.Name = "btn_AddToCart";
            btn_AddToCart.Size = new Size(105, 40);
            btn_AddToCart.TabIndex = 4;
            btn_AddToCart.Text = "Add to Cart";
            btn_AddToCart.UseVisualStyleBackColor = false;
            // 
            // btn_Payment
            // 
            btn_Payment.BackColor = Color.YellowGreen;
            btn_Payment.Location = new Point(291, 451);
            btn_Payment.Name = "btn_Payment";
            btn_Payment.Size = new Size(105, 40);
            btn_Payment.TabIndex = 5;
            btn_Payment.Text = "Payment";
            btn_Payment.UseVisualStyleBackColor = false;
            btn_Payment.Click += btn_Payment_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(548, 456);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(473, 464);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Count";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(650, 19);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 8;
            label4.Text = "BALANCE";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(736, 16);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btn_DeleteFromCart
            // 
            btn_DeleteFromCart.BackColor = Color.Red;
            btn_DeleteFromCart.ForeColor = SystemColors.ButtonHighlight;
            btn_DeleteFromCart.Location = new Point(731, 446);
            btn_DeleteFromCart.Name = "btn_DeleteFromCart";
            btn_DeleteFromCart.Size = new Size(105, 40);
            btn_DeleteFromCart.TabIndex = 10;
            btn_DeleteFromCart.Text = "Delete From Cart";
            btn_DeleteFromCart.UseVisualStyleBackColor = false;
            btn_DeleteFromCart.Visible = false;
            // 
            // btn_BackToUserChoiceForm
            // 
            btn_BackToUserChoiceForm.BackColor = SystemColors.ActiveCaption;
            btn_BackToUserChoiceForm.Location = new Point(32, 515);
            btn_BackToUserChoiceForm.Name = "btn_BackToUserChoiceForm";
            btn_BackToUserChoiceForm.Size = new Size(92, 35);
            btn_BackToUserChoiceForm.TabIndex = 46;
            btn_BackToUserChoiceForm.Text = "Back ";
            btn_BackToUserChoiceForm.UseVisualStyleBackColor = false;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 562);
            Controls.Add(btn_BackToUserChoiceForm);
            Controls.Add(btn_DeleteFromCart);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(btn_Payment);
            Controls.Add(btn_AddToCart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "ShopForm";
            Text = "Shop";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Button btn_AddToCart;
        private Button btn_Payment;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Button btn_DeleteFromCart;
        private Button btn_BackToUserChoiceForm;
    }
}
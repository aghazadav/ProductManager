namespace ProductManager
{
    partial class ProductUpdateForm
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
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            btn_UpdateProduct = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            btn_BackToProductsForm = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 170);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 34;
            label1.Text = "Product Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 80);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 33;
            label8.Text = "Product Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 34);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 32;
            label7.Text = "Product Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(147, 122);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 23);
            textBox7.TabIndex = 31;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(147, 77);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 30;
            // 
            // btn_UpdateProduct
            // 
            btn_UpdateProduct.BackColor = Color.DodgerBlue;
            btn_UpdateProduct.Location = new Point(126, 224);
            btn_UpdateProduct.Name = "btn_UpdateProduct";
            btn_UpdateProduct.Size = new Size(141, 49);
            btn_UpdateProduct.TabIndex = 29;
            btn_UpdateProduct.Text = "Update Product";
            btn_UpdateProduct.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 125);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 28;
            label6.Text = "Product Count";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(147, 34);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 27;
            // 
            // btn_BackToProductsForm
            // 
            btn_BackToProductsForm.BackColor = SystemColors.ActiveCaption;
            btn_BackToProductsForm.Location = new Point(265, 306);
            btn_BackToProductsForm.Name = "btn_BackToProductsForm";
            btn_BackToProductsForm.Size = new Size(100, 35);
            btn_BackToProductsForm.TabIndex = 44;
            btn_BackToProductsForm.Text = "Back";
            btn_BackToProductsForm.UseVisualStyleBackColor = false;
            // 
            // ProductUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 353);
            Controls.Add(btn_BackToProductsForm);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(btn_UpdateProduct);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Name = "ProductUpdateForm";
            Text = "Product Update";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private Button btn_UpdateProduct;
        private Label label6;
        private TextBox textBox5;
        private Button btn_BackToProductsForm;
    }
}
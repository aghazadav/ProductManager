namespace ProductManager
{
    partial class ProductsForm
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
            label8 = new Label();
            label7 = new Label();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            btn_AddProduct = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            btn_EditProduct = new Button();
            btn_SoftDeleteProduct = new Button();
            btn_HardDeleteProduct = new Button();
            btn_BackToAdminForm = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 79);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 23;
            label8.Text = "Product Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 33);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 22;
            label7.Text = "Product Name";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(128, 121);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(200, 23);
            textBox7.TabIndex = 21;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(128, 76);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(200, 23);
            textBox6.TabIndex = 20;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.BackColor = Color.DodgerBlue;
            btn_AddProduct.Location = new Point(107, 223);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(141, 49);
            btn_AddProduct.TabIndex = 19;
            btn_AddProduct.Text = "Add Product";
            btn_AddProduct.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 124);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 18;
            label6.Text = "Product Count";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(128, 33);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(354, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(646, 390);
            dataGridView1.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 169);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 25;
            label1.Text = "Product Category";
            // 
            // btn_EditProduct
            // 
            btn_EditProduct.BackColor = Color.GreenYellow;
            btn_EditProduct.Location = new Point(354, 443);
            btn_EditProduct.Name = "btn_EditProduct";
            btn_EditProduct.Size = new Size(146, 46);
            btn_EditProduct.TabIndex = 41;
            btn_EditProduct.Text = "Edit";
            btn_EditProduct.UseVisualStyleBackColor = false;
            // 
            // btn_SoftDeleteProduct
            // 
            btn_SoftDeleteProduct.BackColor = Color.LightCoral;
            btn_SoftDeleteProduct.Location = new Point(687, 443);
            btn_SoftDeleteProduct.Name = "btn_SoftDeleteProduct";
            btn_SoftDeleteProduct.Size = new Size(146, 46);
            btn_SoftDeleteProduct.TabIndex = 40;
            btn_SoftDeleteProduct.Text = "Soft Delete";
            btn_SoftDeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btn_HardDeleteProduct
            // 
            btn_HardDeleteProduct.BackColor = Color.Red;
            btn_HardDeleteProduct.Location = new Point(854, 443);
            btn_HardDeleteProduct.Name = "btn_HardDeleteProduct";
            btn_HardDeleteProduct.Size = new Size(146, 46);
            btn_HardDeleteProduct.TabIndex = 39;
            btn_HardDeleteProduct.Text = "Hard Delete";
            btn_HardDeleteProduct.UseVisualStyleBackColor = false;
            btn_HardDeleteProduct.Click += button2_Click;
            // 
            // btn_BackToAdminForm
            // 
            btn_BackToAdminForm.BackColor = SystemColors.ActiveCaption;
            btn_BackToAdminForm.Location = new Point(25, 499);
            btn_BackToAdminForm.Name = "btn_BackToAdminForm";
            btn_BackToAdminForm.Size = new Size(100, 35);
            btn_BackToAdminForm.TabIndex = 42;
            btn_BackToAdminForm.Text = "Back";
            btn_BackToAdminForm.UseVisualStyleBackColor = false;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 546);
            Controls.Add(btn_BackToAdminForm);
            Controls.Add(btn_EditProduct);
            Controls.Add(btn_SoftDeleteProduct);
            Controls.Add(btn_HardDeleteProduct);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(btn_AddProduct);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Name = "ProductsForm";
            Text = "Products Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox6;
        private Button btn_AddProduct;
        private Label label6;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label1;
        private Button btn_EditProduct;
        private Button btn_SoftDeleteProduct;
        private Button btn_HardDeleteProduct;
        private Button btn_BackToAdminForm;
    }
}
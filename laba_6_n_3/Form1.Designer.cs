namespace laba_6_n_3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnAddProduct = new Button();
            cmbQuality = new ComboBox();
            label4 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            txtWeight = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnShowUnsorted = new Button();
            btnSortByQuality = new Button();
            btnSortByPrice = new Button();
            btnSortByWeight = new Button();
            txtOutput = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(cmbQuality);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F);
            groupBox1.Location = new Point(20, 23);
            groupBox1.Margin = new Padding(5, 6, 5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 6, 5, 6);
            groupBox1.Size = new Size(543, 604);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Додати новий виріб";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(67, 463);
            btnAddProduct.Margin = new Padding(5, 6, 5, 6);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(408, 104);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Додати виріб до списку";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // cmbQuality
            // 
            cmbQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbQuality.FormattingEnabled = true;
            cmbQuality.Location = new Point(225, 360);
            cmbQuality.Margin = new Padding(5, 6, 5, 6);
            cmbQuality.Name = "cmbQuality";
            cmbQuality.Size = new Size(282, 36);
            cmbQuality.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 365);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 6;
            label4.Text = "Якість:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(225, 267);
            txtPrice.Margin = new Padding(5, 6, 5, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(282, 34);
            txtPrice.TabIndex = 5;
            txtPrice.Text = "800,50";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 273);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 4;
            label3.Text = "Ціна (грн):";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(225, 175);
            txtWeight.Margin = new Padding(5, 6, 5, 6);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(282, 34);
            txtWeight.TabIndex = 3;
            txtWeight.Text = "1,2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 181);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 28);
            label2.TabIndex = 2;
            label2.Text = "Вага (кг):";
            // 
            // txtName
            // 
            txtName.Location = new Point(225, 83);
            txtName.Margin = new Padding(5, 6, 5, 6);
            txtName.Name = "txtName";
            txtName.Size = new Size(282, 34);
            txtName.TabIndex = 1;
            txtName.Text = "Чайник";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 88);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 0;
            label1.Text = "Назва виробу:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnShowUnsorted);
            groupBox2.Controls.Add(btnSortByQuality);
            groupBox2.Controls.Add(btnSortByPrice);
            groupBox2.Controls.Add(btnSortByWeight);
            groupBox2.Font = new Font("Segoe UI", 10F);
            groupBox2.Location = new Point(573, 23);
            groupBox2.Margin = new Padding(5, 6, 5, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 6, 5, 6);
            groupBox2.Size = new Size(740, 604);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Керування списком";
            // 
            // btnShowUnsorted
            // 
            btnShowUnsorted.Location = new Point(37, 71);
            btnShowUnsorted.Margin = new Padding(5, 6, 5, 6);
            btnShowUnsorted.Name = "btnShowUnsorted";
            btnShowUnsorted.Size = new Size(667, 104);
            btnShowUnsorted.TabIndex = 3;
            btnShowUnsorted.Text = "Показати без сортування";
            btnShowUnsorted.UseVisualStyleBackColor = true;
            btnShowUnsorted.Click += btnShowUnsorted_Click;
            // 
            // btnSortByQuality
            // 
            btnSortByQuality.Location = new Point(37, 463);
            btnSortByQuality.Margin = new Padding(5, 6, 5, 6);
            btnSortByQuality.Name = "btnSortByQuality";
            btnSortByQuality.Size = new Size(667, 104);
            btnSortByQuality.TabIndex = 2;
            btnSortByQuality.Text = "Сортувати за ЯКІСТЮ";
            btnSortByQuality.UseVisualStyleBackColor = true;
            btnSortByQuality.Click += btnSortByQuality_Click;
            // 
            // btnSortByPrice
            // 
            btnSortByPrice.Location = new Point(37, 333);
            btnSortByPrice.Margin = new Padding(5, 6, 5, 6);
            btnSortByPrice.Name = "btnSortByPrice";
            btnSortByPrice.Size = new Size(667, 104);
            btnSortByPrice.TabIndex = 1;
            btnSortByPrice.Text = "Сортувати за ЦІНОЮ";
            btnSortByPrice.UseVisualStyleBackColor = true;
            btnSortByPrice.Click += btnSortByPrice_Click;
            // 
            // btnSortByWeight
            // 
            btnSortByWeight.Location = new Point(37, 202);
            btnSortByWeight.Margin = new Padding(5, 6, 5, 6);
            btnSortByWeight.Name = "btnSortByWeight";
            btnSortByWeight.Size = new Size(667, 104);
            btnSortByWeight.TabIndex = 0;
            btnSortByWeight.Text = "Сортувати за ВАГОЮ";
            btnSortByWeight.UseVisualStyleBackColor = true;
            btnSortByWeight.Click += btnSortByWeight_Click;
            // 
            // txtOutput
            // 
            txtOutput.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtOutput.Location = new Point(20, 675);
            txtOutput.Margin = new Padding(5, 6, 5, 6);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(1291, 454);
            txtOutput.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(20, 633);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 3;
            label5.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 1156);
            Controls.Add(label5);
            Controls.Add(txtOutput);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "лаба 6-3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSortByQuality;
        private System.Windows.Forms.Button btnSortByPrice;
        private System.Windows.Forms.Button btnSortByWeight;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnShowUnsorted;
    }
}
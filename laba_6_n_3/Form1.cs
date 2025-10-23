using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace laba_6_n_3
{
    public partial class Form1 : Form
    {
        private List<Product> productDatabase = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            cmbQuality.DataSource = Enum.GetValues(typeof(QualityGrade));
            cmbQuality.SelectedIndex = 0;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                double weight = double.Parse(txtWeight.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                QualityGrade quality = (QualityGrade)cmbQuality.SelectedItem;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Назва не може бути пустою!");
                    return;
                }

                Product newProduct = new Product
                {
                    Name = name,
                    Weight = weight,
                    Price = price,
                    Quality = quality
                };

                productDatabase.Add(newProduct);

                MessageBox.Show($"Виріб '{name}' додано до списку.");

                DisplayProducts(productDatabase, "Поточний список");
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка вводу. Перевірте, чи Вага та Ціна є числами.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }

        private void DisplayProducts(List<Product> products, string title)
        {
            txtOutput.Clear();
            txtOutput.AppendText($"--- {title} ({products.Count} шт.) ---{Environment.NewLine}{Environment.NewLine}");

            foreach (Product p in products)
            {
                txtOutput.AppendText(p.ToString() + Environment.NewLine);
            }
        }

        private void btnSortByWeight_Click(object sender, EventArgs e)
        {
            List<Product> sortedList = new List<Product>(productDatabase);

            sortedList.Sort();

            DisplayProducts(sortedList, "Сортування за ВАГОЮ");
        }

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            List<Product> sortedList = new List<Product>(productDatabase);

            sortedList.Sort(new ProductPriceComparer());

            DisplayProducts(sortedList, "Сортування за ЦІНОЮ");
        }

        private void btnSortByQuality_Click(object sender, EventArgs e)
        {
            List<Product> sortedList = new List<Product>(productDatabase);

            sortedList.Sort(new ProductQualityComparer());

            DisplayProducts(sortedList, "Сортування за ЯКІСТЮ");
        }

        private void btnShowUnsorted_Click(object sender, EventArgs e)
        {
            DisplayProducts(productDatabase, "Список без сортування");
        }
    }
}
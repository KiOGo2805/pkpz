using System;
using System.Collections.Generic;
using System.Linq; // Потрібно для OrderBy, хоча ми будемо використовувати .Sort()
using System.Windows.Forms;

namespace laba_6_n_3
{
    public partial class Form1 : Form
    {
        // "Створіть масив об'єктів"
        // Використовуємо List<T>, який є динамічним масивом і реалізує IEnumerable
        private List<Product> productDatabase = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            // Заповнюємо ComboBox (вибір якості) даними з Enum
            cmbQuality.DataSource = Enum.GetValues(typeof(QualityGrade));
            cmbQuality.SelectedIndex = 0; // За замовчуванням "Low"
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Зчитуємо дані з GUI
                string name = txtName.Text;
                double weight = double.Parse(txtWeight.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                QualityGrade quality = (QualityGrade)cmbQuality.SelectedItem;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Назва не може бути пустою!");
                    return;
                }

                // 2. Створюємо новий виріб
                Product newProduct = new Product
                {
                    Name = name,
                    Weight = weight,
                    Price = price,
                    Quality = quality
                };

                // 3. Додаємо в нашу "базу даних" (список)
                productDatabase.Add(newProduct);

                MessageBox.Show($"Виріб '{name}' додано до списку.");

                // 4. Оновлюємо текстове поле
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

        // Допоміжний метод для виведення списку в txtOutput
        // Він використовує цикл foreach, що можливо завдяки інтерфейсу IEnumerable
        private void DisplayProducts(List<Product> products, string title)
        {
            txtOutput.Clear();
            txtOutput.AppendText($"--- {title} ({products.Count} шт.) ---{Environment.NewLine}{Environment.NewLine}");

            // Використання "IEnumerable" - ми можемо перебрати колекцію
            foreach (Product p in products)
            {
                // Викликаємо наш кастомний ToString()
                txtOutput.AppendText(p.ToString() + Environment.NewLine);
            }
        }

        // Кнопка 1: Сортування за замовчуванням (IComparable)
        private void btnSortByWeight_Click(object sender, EventArgs e)
        {
            // Створюємо КОПІЮ списку, щоб не змінити оригінальний порядок
            List<Product> sortedList = new List<Product>(productDatabase);

            // Викликаємо .Sort() без параметрів.
            // Це автоматично використає наш метод CompareTo(Product other) з класу Product
            sortedList.Sort();

            DisplayProducts(sortedList, "Сортування за ВАГОЮ"); // IComparable
        }

        // Кнопка 2: Сортування за ціною (IComparer)
        // ЦЕ ТАКОЖ ВИКОНУЄ ФІНАЛЬНУ ВИМОГУ ЗАВДАННЯ
        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            // Вимога: "Виведіть на GUI список виробів, впорядкований за ціною."
            List<Product> sortedList = new List<Product>(productDatabase);

            // Викликаємо .Sort() і передаємо йому наш клас-помічник
            // Це використає метод Compare(Product x, Product y) з ProductPriceComparer
            sortedList.Sort(new ProductPriceComparer());

            DisplayProducts(sortedList, "Сортування за ЦІНОЮ"); // IComparer
        }

        // Кнопка 3: Сортування за якістю (IComparer)
        private void btnSortByQuality_Click(object sender, EventArgs e)
        {
            List<Product> sortedList = new List<Product>(productDatabase);

            // Передаємо інший клас-помічник
            sortedList.Sort(new ProductQualityComparer());

            DisplayProducts(sortedList, "Сортування за ЯКІСТЮ"); // IComparer
        }

        // Кнопка 4: Показати як є
        private void btnShowUnsorted_Click(object sender, EventArgs e)
        {
            DisplayProducts(productDatabase, "Список без сортування");
        }
    }
}
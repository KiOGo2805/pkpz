using System;
using System.Collections.Generic;
using System.Linq; // ������� ��� OrderBy, ���� �� ������ ��������������� .Sort()
using System.Windows.Forms;

namespace laba_6_n_3
{
    public partial class Form1 : Form
    {
        // "������� ����� ��'����"
        // ������������� List<T>, ���� � ��������� ������� � ������ IEnumerable
        private List<Product> productDatabase = new List<Product>();

        public Form1()
        {
            InitializeComponent();

            // ���������� ComboBox (���� �����) ������ � Enum
            cmbQuality.DataSource = Enum.GetValues(typeof(QualityGrade));
            cmbQuality.SelectedIndex = 0; // �� ������������� "Low"
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. ������� ��� � GUI
                string name = txtName.Text;
                double weight = double.Parse(txtWeight.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                QualityGrade quality = (QualityGrade)cmbQuality.SelectedItem;

                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("����� �� ���� ���� ������!");
                    return;
                }

                // 2. ��������� ����� ����
                Product newProduct = new Product
                {
                    Name = name,
                    Weight = weight,
                    Price = price,
                    Quality = quality
                };

                // 3. ������ � ���� "���� �����" (������)
                productDatabase.Add(newProduct);

                MessageBox.Show($"���� '{name}' ������ �� ������.");

                // 4. ��������� �������� ����
                DisplayProducts(productDatabase, "�������� ������");
            }
            catch (FormatException)
            {
                MessageBox.Show("������� �����. ��������, �� ���� �� ֳ�� � �������.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� �������: {ex.Message}");
            }
        }

        // ��������� ����� ��� ��������� ������ � txtOutput
        // ³� ����������� ���� foreach, �� ������� ������� ���������� IEnumerable
        private void DisplayProducts(List<Product> products, string title)
        {
            txtOutput.Clear();
            txtOutput.AppendText($"--- {title} ({products.Count} ��.) ---{Environment.NewLine}{Environment.NewLine}");

            // ������������ "IEnumerable" - �� ������ ��������� ��������
            foreach (Product p in products)
            {
                // ��������� ��� ��������� ToString()
                txtOutput.AppendText(p.ToString() + Environment.NewLine);
            }
        }

        // ������ 1: ���������� �� ������������� (IComparable)
        private void btnSortByWeight_Click(object sender, EventArgs e)
        {
            // ��������� ��ϲ� ������, ��� �� ������ ����������� �������
            List<Product> sortedList = new List<Product>(productDatabase);

            // ��������� .Sort() ��� ���������.
            // �� ����������� ��������� ��� ����� CompareTo(Product other) � ����� Product
            sortedList.Sort();

            DisplayProducts(sortedList, "���������� �� �����"); // IComparable
        }

        // ������ 2: ���������� �� ����� (IComparer)
        // �� ����� �����Ӫ Բ������ ������ ��������
        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            // ������: "������� �� GUI ������ ������, ������������� �� �����."
            List<Product> sortedList = new List<Product>(productDatabase);

            // ��������� .Sort() � �������� ���� ��� ����-�������
            // �� ��������� ����� Compare(Product x, Product y) � ProductPriceComparer
            sortedList.Sort(new ProductPriceComparer());

            DisplayProducts(sortedList, "���������� �� ֲ���"); // IComparer
        }

        // ������ 3: ���������� �� ����� (IComparer)
        private void btnSortByQuality_Click(object sender, EventArgs e)
        {
            List<Product> sortedList = new List<Product>(productDatabase);

            // �������� ����� ����-�������
            sortedList.Sort(new ProductQualityComparer());

            DisplayProducts(sortedList, "���������� �� �ʲ���"); // IComparer
        }

        // ������ 4: �������� �� �
        private void btnShowUnsorted_Click(object sender, EventArgs e)
        {
            DisplayProducts(productDatabase, "������ ��� ����������");
        }
    }
}
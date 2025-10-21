using laba_5_n_3;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace laba_5_n_3
{
    public partial class Form1 : Form
    {
        private Person person;

        public Form1()
        {
            InitializeComponent();
            comboType.Items.AddRange(new string[] { "������", "������", "��������" });
            comboType.SelectedIndex = 0;

            comboType.SelectedIndexChanged += ComboType_SelectedIndexChanged;
            UpdateExtraFieldVisibility();
        }

        private void ComboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateExtraFieldVisibility();
        }

        private void UpdateExtraFieldVisibility()
        {
            string selected = comboType.SelectedItem.ToString();

            if (selected == "������")
            {
                labelExtra1.Visible = false;
                txtExtra1.Visible = false;
            }
            else if (selected == "������")
            {
                labelExtra1.Visible = true;
                txtExtra1.Visible = true;
                labelExtra1.Text = "ϲ� ������:";
            }
            else if (selected == "��������")
            {
                labelExtra1.Visible = true;
                txtExtra1.Visible = true;
                labelExtra1.Text = "������ ����������:";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string gender = txtGender.Text;
                double weight = double.Parse(txtWeight.Text);
                double height = double.Parse(txtHeight.Text);
                string extra = txtExtra1.Text;

                switch (comboType.SelectedItem.ToString())
                {
                    case "������":
                        person = new Person(name, age, gender, weight, height);
                        break;

                    case "������":
                        person = new Child(name, age, gender, weight, height, extra);
                        break;

                    case "��������":
                        person = new Pensioner(name, age, gender, weight, height, extra);
                        break;
                }

                MessageBox.Show("�ᒺ�� �������� ������!");
            }
            catch
            {
                MessageBox.Show("������� �������� �����!");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (person != null)
                txtOutput.Text = person.Info();
            else
                MessageBox.Show("�������� ������� �ᒺ��!");
        }
    }
}

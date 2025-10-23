using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace laba_6_n_2
{
    public partial class Form1 : Form
    {
        private object currentAnimal;

        public Form1()
        {
            InitializeComponent();
            cmbType.Items.Add("ʳ�");
            cmbType.Items.Add("������");
            cmbType.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string location = txtLocation.Text;
                int occupants = int.Parse(txtOccupants.Text);
                string type = cmbType.SelectedItem.ToString();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("��'� �� ������� �� ������ ���� �������!");
                    return;
                }

                if (type == "ʳ�")
                {
                    currentAnimal = new Cat
                    {
                        Name = name,
                        Age = age,
                        ShelterLocation = location,
                        Occupants = occupants
                    };
                }
                else
                {
                    currentAnimal = new Dog
                    {
                        Name = name,
                        Age = age,
                        ShelterLocation = location,
                        Occupants = occupants
                    };
                }

                MessageBox.Show($"��'��� '{name}' ({type}) ������ ��������!");
                btnShowInterfaceInfo_Click(null, null);
            }
            catch (FormatException)
            {
                MessageBox.Show("������� �����. ��������, �� ³� �� �-��� � �������.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������� �������: {ex.Message}");
            }
        }

        private void btnShowInterfaceInfo_Click(object sender, EventArgs e)
        {
            if (currentAnimal == null)
            {
                MessageBox.Show("�������� ������� ��'���!");
                return;
            }

            if (currentAnimal is IAnimal animal && currentAnimal is IShelter shelter)
            {
                txtOutput.Text = $"--- ���� ��� ������� ---{Environment.NewLine}";
                txtOutput.AppendText(animal.GetAnimalInfo() + Environment.NewLine);
                txtOutput.AppendText(animal.MakeSound() + Environment.NewLine);

                txtOutput.AppendText(Environment.NewLine);
                txtOutput.AppendText($"--- ���� ��� �������� ---{Environment.NewLine}");
                txtOutput.AppendText(shelter.GetShelterInfo() + Environment.NewLine);
            }
        }

        private void btnShowOwnMethods_Click(object sender, EventArgs e)
        {
            if (currentAnimal == null)
            {
                MessageBox.Show("�������� ������� ��'���!");
                return;
            }

            txtOutput.Text = $"--- ������ ������� ������ ����� ---{Environment.NewLine}";

            if (currentAnimal is Cat cat)
            {
                txtOutput.AppendText(cat.Purr() + Environment.NewLine);
                txtOutput.AppendText(cat.ClimbTree() + Environment.NewLine);
            }
            else if (currentAnimal is Dog dog)
            {
                txtOutput.AppendText(dog.WagTail() + Environment.NewLine);
                txtOutput.AppendText(dog.FetchStick() + Environment.NewLine);
            }
        }
    }
}
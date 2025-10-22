using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace laba_6_n_2
{
    public partial class Form1 : Form
    {
        // Поле для зберігання створеного об'єкта (Кішки або Собаки)
        // Використовуємо 'object' тому що Cat і Dog не мають спільного батьківського класу
        private object currentAnimal;

        public Form1()
        {
            InitializeComponent();
            // Заповнюємо ComboBox
            cmbType.Items.Add("Кіт");
            cmbType.Items.Add("Собака");
            cmbType.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитуємо спільні дані
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string location = txtLocation.Text;
                int occupants = int.Parse(txtOccupants.Text);
                string type = cmbType.SelectedItem.ToString();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Ім'я та Локація не можуть бути пустими!");
                    return;
                }

                // Створюємо об'єкт потрібного типу
                if (type == "Кіт")
                {
                    currentAnimal = new Cat
                    {
                        Name = name,
                        Age = age,
                        ShelterLocation = location,
                        Occupants = occupants
                    };
                }
                else // (type == "Собака")
                {
                    currentAnimal = new Dog
                    {
                        Name = name,
                        Age = age,
                        ShelterLocation = location,
                        Occupants = occupants
                    };
                }

                MessageBox.Show($"Об'єкт '{name}' ({type}) успішно створено!");
                // Одразу показуємо інфо після створення
                btnShowInterfaceInfo_Click(null, null);
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка вводу. Перевірте, чи Вік та К-сть є числами.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}");
            }
        }

        // Кнопка для показу методів з ІНТЕРФЕЙСІВ
        private void btnShowInterfaceInfo_Click(object sender, EventArgs e)
        {
            if (currentAnimal == null)
            {
                MessageBox.Show("Спочатку створіть об'єкт!");
                return;
            }

            // Перевіряємо, чи об'єкт реалізує потрібні інтерфейси
            if (currentAnimal is IAnimal animal && currentAnimal is IShelter shelter)
            {
                txtOutput.Text = $"--- Інфа про тварину ---{Environment.NewLine}";
                txtOutput.AppendText(animal.GetAnimalInfo() + Environment.NewLine);
                txtOutput.AppendText(animal.MakeSound() + Environment.NewLine);

                txtOutput.AppendText(Environment.NewLine);
                txtOutput.AppendText($"--- Інфа про притулок ---{Environment.NewLine}");
                txtOutput.AppendText(shelter.GetShelterInfo() + Environment.NewLine);
            }
        }

        // Кнопка для показу ВЛАСНИХ методів КЛАСУ
        private void btnShowOwnMethods_Click(object sender, EventArgs e)
        {
            if (currentAnimal == null)
            {
                MessageBox.Show("Спочатку створіть об'єкт!");
                return;
            }

            txtOutput.Text = $"--- Виклик власних методів класу ---{Environment.NewLine}";

            // Перевіряємо конкретний тип об'єкта
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
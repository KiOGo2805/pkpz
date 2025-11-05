namespace laba_8_n_1
{
    public partial class Form1 : Form
    {
        private readonly List<PersonInfo> personDatabase = [];

        public Form1()
        {
            InitializeComponent();

            numBirthYear.Maximum = DateTime.Now.Year;
            numBirthYear.Value = 2000;
            numBirthYear.Minimum = 1900;

            // Заповнюємо ComboBox для вибору поля
            cmbFieldSelect.Items.Add("Прізвище");
            cmbFieldSelect.Items.Add("Ім'я");
            cmbFieldSelect.Items.Add("Рік народження");
            cmbFieldSelect.Items.Add("ID Картки");
            cmbFieldSelect.SelectedIndex = 0;
        }

        // Кнопка: Додати особу
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            try
            {
                int newID = (int)numCardID.Value;

                if (personDatabase.Any(person => person.GetCardID() == newID))
                {
                    MessageBox.Show("Особа з таким ID Картки вже існує!");
                    return;
                }

                PersonInfo newPerson = new(
                    txtLastName.Text,
                    txtFirstName.Text,
                    (int)numBirthYear.Value,
                    newID
                );

                if (string.IsNullOrWhiteSpace(newPerson.GetValueByName("Прізвище")))
                {
                    MessageBox.Show("Прізвище не може бути порожнім.");
                    return;
                }

                personDatabase.Add(newPerson);
                MessageBox.Show($"Особу '{txtLastName.Text}' (ID: {newID}) додано.");

                RefreshPeopleList(personDatabase);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        // Кнопка: Підрахувати осіб > 60 років
        private void btnCountFreePassage_Click(object sender, EventArgs e)
        {
            List<PersonInfo> eligiblePeople = [.. personDatabase.Where(person => person.IsEligibleForFreePassage())];

            RefreshPeopleList(eligiblePeople);
            MessageBox.Show($"Знайдено {eligiblePeople.Count} осіб," +
                $" які мають право на безкоштовний проїзд.", "Результат підрахунку");
        }

        // Кнопка: Показати ОДНЕ конкретне значення
        private void btnShowSpecific_Click(object sender, EventArgs e)
        {
            try
            {
                int searchID = (int)numSearchID.Value;

                PersonInfo foundPerson = personDatabase
                    .FirstOrDefault(person => person.GetCardID() == searchID);

                if (foundPerson == null)
                {
                    MessageBox.Show($"Особу з ID {searchID} не знайдено.");
                    return;
                }

                string selectedField = cmbFieldSelect.SelectedItem.ToString();
                string value = foundPerson.GetValueByName(selectedField);

                // --- ЗМІНА ТУТ ---
                // Виводимо в тому ж "стилі", що й інша кнопка
                MessageBox.Show($"Поле: {selectedField}{Environment.NewLine}Значення: {value}",
                                $"Дані для ID: {searchID}");
                // --- ---
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка пошуку: {ex.Message}");
            }
        }

        // Кнопка: Знайти та показати ВСІ дані
        private void btnFindAndShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                int searchID = (int)numSearchID.Value;

                PersonInfo foundPerson = personDatabase
                    .FirstOrDefault(person => person.GetCardID() == searchID);

                if (foundPerson == null)
                {
                    MessageBox.Show($"Особу з ID {searchID} не знайдено.", "Помилка пошуку");
                    return;
                }

                string allInfo = foundPerson.GetAllValues();
                MessageBox.Show(allInfo, $"Повні дані для ID: {searchID}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка пошуку: {ex.Message}");
            }
        }

        // --- Допоміжні методи ---
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshPeopleList(personDatabase);
        }

        private void RefreshPeopleList(List<PersonInfo> people)
        {
            lstPeople.Items.Clear();
            if (people.Count == 0)
            {
                lstPeople.Items.Add("Список порожній.");
            }
            else
            {
                foreach (var person in people)
                {
                    lstPeople.Items.Add(person);
                }
            }
        }
    }
}
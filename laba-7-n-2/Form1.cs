using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace laba_7_n_2
{
    public partial class Form1 : Form
    {
        private List<TimetableEntry> trainDatabase = new List<TimetableEntry>();

        public Form1()
        {
            InitializeComponent();
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.ShowUpDown = true;
        }

        private void btnAddTrain_Click(object sender, EventArgs e)
        {
            try
            {
                string destination = txtDestination.Text;
                int trainNumber = int.Parse(txtTrainNum.Text);
                DateTime datePart = dtpDate.Value.Date;
                TimeSpan timePart = dtpTime.Value.TimeOfDay;

                if (string.IsNullOrEmpty(destination) || trainNumber <= 0)
                {
                    MessageBox.Show("Назва та номер потягу мають бути заповнені коректно.");
                    return;
                }

                // Створюємо об'єкт з властивостями як у завданні
                TimetableEntry newEntry = new TimetableEntry
                {
                    NAZV = destination,
                    NUMR = trainNumber,
                    DATE = datePart,
                    TIME = timePart
                };

                trainDatabase.Add(newEntry);
                MessageBox.Show($"Потяг №{trainNumber} до '{destination}' додано.");

                DisplayTrains(trainDatabase, "Поточний розклад");
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка вводу. Перевірте, чи номер потягу є числом.");
            }
        }

        // Допоміжний метод для виведення
        private void DisplayTrains(List<TimetableEntry> trains, string title)
        {
            txtOutput.Clear();
            txtOutput.AppendText($"--- {title} ({trains.Count} шт.) ---{Environment.NewLine}{Environment.NewLine}");

            if (trains.Count == 0)
            {
                txtOutput.AppendText("Список порожній.");
            }
            else
            {
                foreach (var train in trains)
                {
                    txtOutput.AppendText(train.ToString() + Environment.NewLine);
                }
            }
        }

        // --- Вимога 2: Впорядкування записів ---
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (trainDatabase.Count == 0)
            {
                MessageBox.Show("База даних порожня, нічого сортувати.");
                return;
            }

            // Логіка не змінилась, .Sort() тепер викликає оновлений CompareTo()
            List<TimetableEntry> sortedList = new List<TimetableEntry>(trainDatabase);
            sortedList.Sort();

            DisplayTrains(sortedList, "Розклад, відсортований за датою та часом");
        }

        // --- Вимога 3: Виведення інформації (Пошук) ---
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchDestination = txtSearchDest.Text;
            if (string.IsNullOrEmpty(searchDestination))
            {
                MessageBox.Show("Введіть назву пункту призначення для пошуку.");
                return;
            }

            // Пошук тепер ведеться по полю NAZV
            List<TimetableEntry> results = trainDatabase
                .Where(train => train.NAZV.Equals(searchDestination, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (results.Count > 0)
            {
                DisplayTrains(results, $"Результати пошуку для: '{searchDestination}'");
            }
            else
            {
                txtOutput.Clear();
                txtOutput.AppendText($"--- Результати пошуку для: '{searchDestination}' ---{Environment.NewLine}{Environment.NewLine}");
                txtOutput.AppendText($"Потягів до пункту '{searchDestination}' не знайдено.");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayTrains(trainDatabase, "Повний розклад (як додали)");
        }
    }
}
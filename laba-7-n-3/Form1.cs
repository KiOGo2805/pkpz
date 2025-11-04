namespace laba_7_n_3
{
    public partial class Form1 : Form
    {
        // Наша база даних
        private List<KnockoutStats> knockoutDatabase = new List<KnockoutStats>();

        public Form1()
        {
            InitializeComponent();

            // Налаштування полів вводу дати/часу
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm:ss";
            dtpStartTime.ShowUpDown = true;
        }

        // --- Введення даних ---
        private void btnAddKnockout_Click(object sender, EventArgs e)
        {
            try
            {
                // Зчитуємо час у раунді з двох полів
                int minutes = (int)numRoundMinutes.Value;
                int seconds = (int)numRoundSeconds.Value;
                TimeSpan timeInRound = new TimeSpan(0, minutes, seconds);

                // Перевірка, чи час у раунді не перевищує 3 хвилини
                if (timeInRound.TotalMinutes > 3)
                {
                    MessageBox.Show("Час у раунді не може перевищувати 3 хвилини (03:00).");
                    return;
                }

                // Створюємо новий запис
                KnockoutStats newKO = new KnockoutStats
                {
                    KnockoutDate = dtpDate.Value.Date,
                    BoutStartTime = dtpStartTime.Value.TimeOfDay,
                    WinnerName = txtWinner.Text,
                    LoserName = txtLoser.Text,
                    KnockoutRound = (int)numRound.Value,
                    KnockoutTimeInRound = timeInRound
                };

                knockoutDatabase.Add(newKO);
                MessageBox.Show($"Нокаут ({newKO.WinnerName} vs {newKO.LoserName}) додано.");

                // Оновлюємо вивід
                btnShowAll_Click(null, null); // Викликаємо "Показати всіх"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні: {ex.Message}");
            }
        }

        // --- Допоміжний метод виведення ---
        private void DisplayKnockouts(List<KnockoutStats> knockouts, string title)
        {
            txtOutput.Clear();
            txtOutput.AppendText($"--- {title} ({knockouts.Count} шт.) ---{Environment.NewLine}{Environment.NewLine}");

            if (knockouts.Count == 0)
            {
                txtOutput.AppendText("Немає даних для відображення.");
                return;
            }

            foreach (var ko in knockouts)
            {
                // Вимога 1: вивести інформацію ... із зазначенням часу закінчення бою
                TimeSpan totalTime = ko.CalculateTotalBoutTime();
                string totalTimeStr = totalTime.ToString("hh\\:mm\\:ss");

                txtOutput.AppendText(ko.ToString() + Environment.NewLine);
                txtOutput.AppendText($"     -> Загальний час бою: {totalTimeStr}{Environment.NewLine}");
                txtOutput.AppendText("--------------------------------------------------\n");
            }
        }

        // --- Вимога 1: Вивести всіх (з розрахунком) ---
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayKnockouts(knockoutDatabase, "Всі нокаути (з загальним часом)");
        }

        // --- Вимога 2: Відомості про всі нокаути за останні три місяці ---
        private void btnShowLast3Months_Click(object sender, EventArgs e)
        {
            DateTime threeMonthsAgo = DateTime.Now.AddMonths(-3);

            List<KnockoutStats> results = knockoutDatabase
                .Where(ko => ko.KnockoutDate >= threeMonthsAgo)
                .OrderBy(ko => ko.KnockoutDate) // Сортуємо для зручності
                .ToList();

            DisplayKnockouts(results, "Нокаути за останні 3 місяці");
        }

        // --- Вимога 3: Підрахувати ... нокаутом у третьому раунді ---
        private void btnCountRound3_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpRangeStart.Value.Date;
            DateTime endDate = dtpRangeEnd.Value.Date;

            int count = knockoutDatabase.Count(ko =>
                ko.KnockoutDate >= startDate &&
                ko.KnockoutDate <= endDate &&
                ko.KnockoutRound == 3);

            txtOutput.Clear();
            txtOutput.AppendText($"--- Пошук нокаутів у 3-му раунді ---{Environment.NewLine}{Environment.NewLine}");
            txtOutput.AppendText($"Між {startDate:dd.MM.yyyy} та {endDate:dd.MM.yyyy} знайдено:{Environment.NewLine}");
            txtOutput.AppendText($"-> {count} поєдинків.");
        }

        // --- Вимога 4: Знайти найкоротший поєдинок цього року ---
        private void btnFindShortestThisYear_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;

            // Фільтруємо за роком
            List<KnockoutStats> thisYearKOs = knockoutDatabase
                .Where(ko => ko.KnockoutDate.Year == currentYear)
                .ToList();

            if (thisYearKOs.Count == 0)
            {
                txtOutput.Clear();
                txtOutput.AppendText($"--- Найкоротший поєдинок цього року ({currentYear}) ---{Environment.NewLine}{Environment.NewLine}");
                txtOutput.AppendText("Нокаутів у цьому році ще не було.");
                return;
            }

            // Шукаємо найкоротший, сортуючи за розрахованим часом
            KnockoutStats shortest = thisYearKOs
                .OrderBy(ko => ko.CalculateTotalBoutTime())
                .FirstOrDefault(); // Беремо перший (найменший)

            // Використовуємо наш Display-метод, передавши йому список з 1 елемента
            DisplayKnockouts(new List<KnockoutStats> { shortest }, $"Найкоротший поєдинок {currentYear} року");
        }

        // --- Вимога 5: Вивести інформацію про всі поєдинки на вказану дату ---
        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DateTime searchDate = dtpSearchDate.Value.Date;

            List<KnockoutStats> results = knockoutDatabase
                .Where(ko => ko.KnockoutDate == searchDate)
                .ToList();

            DisplayKnockouts(results, $"Нокаути за {searchDate:dd.MM.yyyy}");
        }
    }
}
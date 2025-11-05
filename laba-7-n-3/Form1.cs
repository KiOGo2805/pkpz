namespace laba_7_n_3
{
    public partial class Form1 : Form
    {
        private readonly List<KnockoutStats> knockoutDatabase = [];

        public Form1()
        {
            InitializeComponent();

            dtpDate.Format = DateTimePickerFormat.Short;
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm:ss";
            dtpStartTime.ShowUpDown = true;
        }

        private void btnAddKnockout_Click(object sender, EventArgs e)
        {
            try
            {
                int minutes = (int)numRoundMinutes.Value;
                int seconds = (int)numRoundSeconds.Value;
                TimeSpan timeInRound = new(0, minutes, seconds);

                if (timeInRound.TotalMinutes > 3)
                {
                    MessageBox.Show("Час у раунді не може перевищувати 3 хвилини (03:00).");
                    return;
                }

                KnockoutStats newKO = new()
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

                btnShowAll_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при додаванні: {ex.Message}");
            }
        }

        private void DisplayKnockouts(List<KnockoutStats> knockouts, string title)
        {
            txtOutput.Clear();
            txtOutput.AppendText($"--- {title} ({knockouts.Count} шт.) ---" +
                $"{Environment.NewLine}{Environment.NewLine}");

            if (knockouts.Count == 0)
            {
                txtOutput.AppendText("Немає даних для відображення.");
                return;
            }

            foreach (var ko in knockouts)
            {
                TimeSpan totalTime = ko.CalculateTotalBoutTime();
                string totalTimeStr = totalTime.ToString("hh\\:mm\\:ss");

                txtOutput.AppendText(ko.ToString() + Environment.NewLine);
                txtOutput.AppendText($"     -> Загальний час бою: {totalTimeStr}" +
                    $"{Environment.NewLine}--------------------------------------------------{Environment.NewLine}");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DisplayKnockouts(knockoutDatabase, "Всі нокаути (з загальним часом)");
        }

        private void btnShowLast3Months_Click(object sender, EventArgs e)
        {
            DateTime threeMonthsAgo = DateTime.Now.AddMonths(-3);

            List<KnockoutStats> results = [.. knockoutDatabase
                .Where(ko => ko.KnockoutDate >= threeMonthsAgo)
                .OrderBy(ko => ko.KnockoutDate)];

            DisplayKnockouts(results, "Нокаути за останні 3 місяці");
        }

        private void btnCountRound3_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpRangeStart.Value.Date;
            DateTime endDate = dtpRangeEnd.Value.Date;

            int count = knockoutDatabase.Count(ko =>
                ko.KnockoutDate >= startDate &&
                ko.KnockoutDate <= endDate &&
                ko.KnockoutRound == 3);

            txtOutput.Clear();
            txtOutput.AppendText($"--- Пошук нокаутів у 3-му раунді ---" +
                $"{Environment.NewLine}{Environment.NewLine}");
            txtOutput.AppendText($"Між {startDate:dd.MM.yyyy} та {endDate:dd.MM.yyyy} знайдено:" +
                $"{Environment.NewLine}");
            txtOutput.AppendText($"-> {count} поєдинків.");
        }

        private void btnFindShortestThisYear_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;

            List<KnockoutStats> thisYearKOs = [.. knockoutDatabase
                .Where(ko => ko.KnockoutDate.Year == currentYear)];

            if (thisYearKOs.Count == 0)
            {
                txtOutput.Clear();
                txtOutput.AppendText($"--- Найкоротший поєдинок цього року ({currentYear}) ---" +
                    $"{Environment.NewLine}{Environment.NewLine}");
                txtOutput.AppendText("Нокаутів у цьому році ще не було.");
                return;
            }

            KnockoutStats shortest = thisYearKOs
                .OrderBy(ko => ko.CalculateTotalBoutTime())
                .FirstOrDefault();

            DisplayKnockouts([shortest], $"Найкоротший поєдинок {currentYear} року");
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            DateTime searchDate = dtpSearchDate.Value.Date;

            List<KnockoutStats> results = [.. knockoutDatabase
                .Where(ko => ko.KnockoutDate == searchDate)];

            DisplayKnockouts(results, $"Нокаути за {searchDate:dd.MM.yyyy}");
        }
    }
}
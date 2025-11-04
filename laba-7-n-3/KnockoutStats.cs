namespace laba_7_n_3
{
    public class KnockoutStats
    {
        // --- Поля зі завдання ---
        public DateTime KnockoutDate { get; set; } // дата нокауту
        public TimeSpan BoutStartTime { get; set; }  // час початку поєдинку
        public string WinnerName { get; set; }     // ПІБ боксера, який завдав удару
        public string LoserName { get; set; }      // ПІБ боксера, який потерпів поразку
        public int KnockoutRound { get; set; }     // номер раунду нокауту
        public TimeSpan KnockoutTimeInRound { get; set; } // час закінчення у хвилинах/секундах відносно початку раунду

        // --- Конструктор ---
        public KnockoutStats()
        {
            KnockoutDate = DateTime.Now.Date;
            BoutStartTime = TimeSpan.Zero;
            WinnerName = "N/A";
            LoserName = "N/A";
            KnockoutRound = 1;
            KnockoutTimeInRound = TimeSpan.Zero;
        }

        // --- Вимога 1: Розрахунок часу закінчення бою ---
        // 1 раунд = 3 хв, 1 перерва = 2 хв
        // Загальний час = (Час (N-1) раундів) + (Час (N-1) перерв) + (Час у поточному раунді)
        public TimeSpan CalculateTotalBoutTime()
        {
            if (KnockoutRound < 1)
            {
                return KnockoutTimeInRound; // Некоректний раунд
            }

            int fullRounds = KnockoutRound - 1;

            // Загальний час за повні раунди (3 хв/раунд)
            TimeSpan fullRoundsDuration = TimeSpan.FromMinutes(fullRounds * 3);

            // Загальний час за перерви (2 хв/перерва)
            TimeSpan breaksDuration = TimeSpan.FromMinutes(fullRounds * 2);

            // Додаємо час у поточному раунді
            return fullRoundsDuration + breaksDuration + KnockoutTimeInRound;
        }

        // --- Допоміжний метод для виведення ---
        public override string ToString()
        {
            // Форматуємо вивід згідно з шаблоном ДДММРРРР та ГГ:ХХ:СС
            string dateStr = KnockoutDate.ToString("dd.MM.yyyy");
            string startTimeStr = BoutStartTime.ToString("hh\\:mm\\:ss");
            string timeInRoundStr = KnockoutTimeInRound.ToString("mm\\:ss");

            return $"Дата: {dateStr} (Початок: {startTimeStr}) | {WinnerName} переміг {LoserName}\n" +
                   $"     -> Раунд: {KnockoutRound} (час у раунді: {timeInRoundStr})";
        }
    }
}
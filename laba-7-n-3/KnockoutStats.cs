namespace laba_7_n_3
{
    public class KnockoutStats
    {
        public DateTime KnockoutDate { get; set; }
        public TimeSpan BoutStartTime { get; set; }
        public string WinnerName { get; set; }
        public string LoserName { get; set; }
        public int KnockoutRound { get; set; }
        public TimeSpan KnockoutTimeInRound { get; set; }

        public KnockoutStats()
        {
            KnockoutDate = DateTime.Now.Date;
            BoutStartTime = TimeSpan.Zero;
            WinnerName = "N/A";
            LoserName = "N/A";
            KnockoutRound = 1;
            KnockoutTimeInRound = TimeSpan.Zero;
        }

        public TimeSpan CalculateTotalBoutTime()
        {
            if (KnockoutRound < 1)
            {
                return KnockoutTimeInRound;
            }

            int fullRounds = KnockoutRound - 1;

            TimeSpan fullRoundsDuration = TimeSpan.FromMinutes(fullRounds * 3);
            TimeSpan breaksDuration = TimeSpan.FromMinutes(fullRounds * 2);

            return fullRoundsDuration + breaksDuration + KnockoutTimeInRound;
        }

        public override string ToString()
        {
            string dateStr = KnockoutDate.ToString("dd.MM.yyyy");
            string startTimeStr = BoutStartTime.ToString("hh\\:mm\\:ss");
            string timeInRoundStr = KnockoutTimeInRound.ToString("mm\\:ss");

            return $"Дата: {dateStr} (Початок: {startTimeStr}) | {WinnerName} переміг {LoserName}\n" +
                   $"     -> Раунд: {KnockoutRound} (час у раунді: {timeInRoundStr})";
        }
    }
}
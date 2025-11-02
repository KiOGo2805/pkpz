using System;

namespace laba_7_n_2
{
    public class TimetableEntry : IComparable<TimetableEntry>
    {
        public string NAZV { get; set; }
        public int NUMR { get; set; }
        public DateTime DATE { get; set; }
        public TimeSpan TIME { get; set; }

        public TimetableEntry()
        {
            NAZV = "Кудась";
            NUMR = 0;
            DATE = DateTime.Now.Date;
            TIME = TimeSpan.Zero;
        }

        public int CompareTo(TimetableEntry? other)
        {
            if (other == null) return 1;

            int dateCompare = this.DATE.CompareTo(other.DATE);

            if (dateCompare == 0)
            {
                return this.TIME.CompareTo(other.TIME);
            }

            return dateCompare;
        }

        public override string ToString()
        {
            string dateStr = DATE.ToString("dd.MM.yyyy");
            string timeStr = TIME.ToString("hh\\:mm");

            return $"Потяг №{NUMR,-5} | Пункт: {NAZV,-20} | Відправлення: {dateStr} o {timeStr}";
        }
    }
}
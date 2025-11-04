namespace laba_8_n_1
{
    public class PersonInfo
    {
        // --- Вимога 1.1: Кортеж з 4 елементів ---
        // (Прізвище, Рік) + (Ім'я, ID Картки)
        private (string LastName, string FirstName, int BirthYear, int CardID) personData;

        // Конструктор
        public PersonInfo(string lastName, string firstName, int birthYear, int cardID)
        {
            personData.LastName = lastName;
            personData.FirstName = firstName;
            personData.BirthYear = birthYear;
            personData.CardID = cardID;
        }

        // --- Метод для виводу конкретного значення (для btnShowSpecific) ---
        public string GetValueByName(string fieldName)
        {
            switch (fieldName)
            {
                case "Прізвище":
                    return personData.LastName;
                case "Ім'я":
                    return personData.FirstName;
                case "Рік народження":
                    return personData.BirthYear.ToString();
                case "ID Картки":
                    return personData.CardID.ToString();
                default:
                    return "Невідоме поле";
            }
        }

        // --- Метод для виводу ВСІХ значень (для btnFindAndShowAll) ---
        public string GetAllValues()
        {
            // Повертаємо форматований рядок з усіма 4 елементами кортежу
            return $"Прізвище: {personData.LastName}{Environment.NewLine}" +
                   $"Ім'я: {personData.FirstName}{Environment.NewLine}" +
                   $"Рік народження: {personData.BirthYear}{Environment.NewLine}" +
                   $"ID Картки: {personData.CardID}";
        }

        // --- Метод для пошуку (повертає ID) ---
        public int GetCardID()
        {
            return personData.CardID;
        }

        // --- Вимога Варіанту: Перевірка на безкоштовний проїзд (> 60 років) ---
        public bool IsEligibleForFreePassage()
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - personData.BirthYear;
            return age > 60;
        }

        // Вивід у ListBox
        public override string ToString()
        {
            // Додаємо ID для кращої ідентифікації
            return $"[ID: {personData.CardID}] {personData.LastName}, {personData.FirstName} (Рік: {personData.BirthYear})";
        }
    }
}
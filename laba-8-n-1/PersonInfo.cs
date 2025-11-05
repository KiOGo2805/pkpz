namespace laba_8_n_1
{
    public class PersonInfo
    {
        private (string LastName, string FirstName, int BirthYear, int CardID) personData;

        public PersonInfo(string lastName, string firstName, int birthYear, int cardID)
        {
            personData.LastName = lastName;
            personData.FirstName = firstName;
            personData.BirthYear = birthYear;
            personData.CardID = cardID;
        }

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

        public string GetAllValues()
        {
            return $"Прізвище: {personData.LastName}{Environment.NewLine}" +
                   $"Ім'я: {personData.FirstName}{Environment.NewLine}" +
                   $"Рік народження: {personData.BirthYear}{Environment.NewLine}" +
                   $"ID Картки: {personData.CardID}";
        }

        public int GetCardID()
        {
            return personData.CardID;
        }

        public bool IsEligibleForFreePassage()
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - personData.BirthYear;
            return age > 60;
        }

        public override string ToString()
        {
            return $"[ID: {personData.CardID}] {personData.LastName}, {personData.FirstName} (Рік: {personData.BirthYear})";
        }
    }
}
using System;

namespace laba_5_n_3
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Person(string name, int age, string gender, double weight, double height)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
            Height = height;
        }

        public virtual double BMI()
        {
            return Math.Round(Weight / (Height * Height), 2);
        }

        public virtual string IsAdult()
        {
            return Age >= 18 ? "Повнолітній" : "Неповнолітній";
        }

        public virtual string Info()
        {
            return $"Ім'я: {Name}{Environment.NewLine}" +
                   $"Вік: {Age}{Environment.NewLine}" +
                   $"Стать: {Gender}{Environment.NewLine}" +
                   $"Індекс маси тіла: {BMI()}{Environment.NewLine}" +
                   $"Статус: {IsAdult()}";
        }
    }
}

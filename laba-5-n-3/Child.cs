using laba_5_n_3;

namespace laba_5_n_3
{
    public class Child : Person
    {
        public string Parents { get; set; }

        public Child(string name, int age, string gender, double weight, double height, string parents)
            : base(name, age, gender, weight, height)
        {
            Parents = parents;
        }

        public override double BMI()
        {
            return Math.Round((Weight / (Height * Height)) * 0.2, 2);
        }

        public string EducationLevel()
        {
            return Age < 6 ? "Дошкільний навчальний заклад" : "Школа";
        }

        public override string Info()
        {
            return base.Info() + Environment.NewLine +
                   $"Батьки: {Parents}{Environment.NewLine}" +
                   $"Заклад: {EducationLevel()}";
        }
    }
}

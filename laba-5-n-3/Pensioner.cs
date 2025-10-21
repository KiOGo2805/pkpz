using laba_5_n_3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace laba_5_n_3
{
    public class Pensioner : Person
    {
        public string Address { get; set; }

        public Pensioner(string name, int age, string gender, double weight, double height, string address)
            : base(name, age, gender, weight, height)
        {
            Address = address;
        }

        public override string IsAdult()
        {
            return "Повнолітній";
        }

        public double Pension()
        {
            if (Age >= 70 && Age < 80)
                return Age * 55.68;
            else if (Age >= 80 && Age < 90)
                return Age * 65.12;
            else if (Age >= 90)
                return Age * 75.50;
            else
                return Age * 50.00;
        }

        public override string Info()
        {
            return base.Info() + Environment.NewLine +
                   $"Адреса: {Address}{Environment.NewLine}" +
                   $"Пенсія: {Pension():0.00} грн";
        }
    }
}

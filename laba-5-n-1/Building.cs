using System;
using System.IO;

namespace laba_5_n_1
{
    public class Building
    {
        private string name;
        private string address;
        private int floors;
        private double height;
        private int yearBuilt;
        private string purpose;
        private bool hasParking;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Floors { get => floors; set => floors = value; }
        public double Height { get => height; set => height = value; }
        public int YearBuilt { get => yearBuilt; set => yearBuilt = value; }
        public string Purpose { get => purpose; set => purpose = value; }
        public bool HasParking { get => hasParking; set => hasParking = value; }

        public Building()
        {
            name = "Невідома будівля";
            address = "Невідомо";
            floors = 0;
            height = 0.0;
            yearBuilt = 0000;
            purpose = "Невідомо";
            hasParking = false;
        }

        public double AverageFloorHeight()
        {
            return Math.Round(height / floors, 2);
        }

        public string GetBuildingInfo()
        {
            return $"Назва: {Name}{Environment.NewLine}" +
                   $"Адреса: {Address}{Environment.NewLine}" +
                   $"Поверхів: {Floors}{Environment.NewLine}" +
                   $"Висота: {Height} м{Environment.NewLine}" +
                   $"Рік будівництва: {YearBuilt}{Environment.NewLine}" +
                   $"Призначення: {Purpose}{Environment.NewLine}" +
                   $"Паркінг: {(HasParking ? "є" : "нема")}{Environment.NewLine}" +
                   $"Середня висота поверху: {AverageFloorHeight()} м";
        }


        public void SaveToFile(string path)
        {
            File.WriteAllText(path, GetBuildingInfo());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_n_3
{
    public enum QualityGrade
    {
        Low,
        Medium,
        High,
        Premium
    }

    public class Product : IComparable<Product>
    {
        private string name;
        private double weight;
        private decimal price;
        private QualityGrade quality;

        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public decimal Price { get => price; set => price = value; }
        public QualityGrade Quality { get => quality; set => quality = value; }

        public Product()
        {
            Name = "Невідомо";
            Weight = 0.0;
            Price = 0.0m;
            Quality = QualityGrade.Low;
        }

        public int CompareTo(Product other)
        {
            if (other == null) return 1;

            return this.Weight.CompareTo(other.Weight);
        }

        public override string ToString()
        {
            return $"Назва: {Name,-20} | Ціна: {Price,8:C2} | Вага: {Weight,5:F1} кг | Якість: {Quality}";
        }
    }
}
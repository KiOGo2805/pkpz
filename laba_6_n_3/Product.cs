using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_n_3
{
    // "Своя шкала якості" (вимога з IComparer)
    public enum QualityGrade
    {
        Low,      // Низька
        Medium,   // Середня
        High,     // Висока
        Premium   // Преміум
    }

    // Клас Виріб
    // Реалізує IComparable для "сортування за замовчуванням" (за вагою)
    public class Product : IComparable<Product>
    {
        // Поля
        private string name;
        private double weight;
        private decimal price;
        private QualityGrade quality;

        // Властивості (у вашому стилі)
        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public decimal Price { get => price; set => price = value; }
        public QualityGrade Quality { get => quality; set => quality = value; }

        // Конструктор
        public Product()
        {
            Name = "Невідомо";
            Weight = 0.0;
            Price = 0.0m;
            Quality = QualityGrade.Low;
        }

        // --- Реалізація IComparable<Product> ---
        // Вимога: "порівняння виробів за вагою"
        public int CompareTo(Product other)
        {
            // Це сортування за замовчуванням
            if (other == null) return 1;

            // Використовуємо вбудований CompareTo для типу double
            return this.Weight.CompareTo(other.Weight);
        }

        // Допоміжний метод для гарного виведення в TextBox
        public override string ToString()
        {
            // Використовуємо форматування для створення "таблиці"
            return $"Назва: {Name,-20} | Ціна: {Price,8:C2} | Вага: {Weight,5:F1} кг | Якість: {Quality}";
        }
    }
}
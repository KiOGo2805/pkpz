using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_n_3
{
    // --- Реалізація IComparer (Критерій 1) ---
    // Вимога: "порівняння виробів за ціною"
    public class ProductPriceComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x == null || y == null) return 0;
            return x.Price.CompareTo(y.Price);
        }
    }

    // --- Реалізація IComparer (Критерій 2) ---
    // Вимога: "порівняння виробів... за якістю"
    public class ProductQualityComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x == null || y == null) return 0;
            // Enum порівнюються за їхніми числовими значеннями (Low=0, Medium=1, ...)
            return x.Quality.CompareTo(y.Quality);
        }
    }
}
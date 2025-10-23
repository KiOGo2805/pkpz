using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_n_3
{
    public class ProductPriceComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x == null || y == null) return 0;
            return x.Price.CompareTo(y.Price);
        }
    }

    public class ProductQualityComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            if (x == null || y == null) return 0;
            return x.Quality.CompareTo(y.Quality);
        }
    }
}
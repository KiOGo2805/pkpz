using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_n_2
{
    public interface IShelter
    {
        // 1-й метод інтерфейсу
        string GetShelterInfo();

        // 2-й метод інтерфейсу (змінює стан)
        void RegisterNewArrival(int count);
    }
}
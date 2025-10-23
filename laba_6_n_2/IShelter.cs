using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_n_2
{
    public interface IShelter
    {
        string GetShelterInfo();

        void RegisterNewArrival(int count);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_6_n_2
{
    public class Dog : IAnimal, IShelter
    {
        private string name;
        private int age;
        private string shelterLocation;
        private int occupants;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string ShelterLocation { get => shelterLocation; set => shelterLocation = value; }
        public int Occupants { get => occupants; set => occupants = value; }

        public Dog()
        {
            Name = "Невідома собака";
            Age = 0;
            ShelterLocation = "Невідомо";
            Occupants = 0;
        }

        public string GetAnimalInfo()
        {
            return $"Тварина: {Name} (Собака){Environment.NewLine}Вік: {Age} р.";
        }
        public string MakeSound()
        {
            return $"{Name} каже: Гав!";
        }

        public string GetShelterInfo()
        {
            return $"Притулок: {ShelterLocation}{Environment.NewLine}Мешканців: {Occupants}";
        }
        public void RegisterNewArrival(int count)
        {
            Occupants += count;
        }

        public string WagTail()
        {
            return $"{Name} махає хвостом.";
        }
        public string FetchStick()
        {
            return $"{Name} приніс палицю!";
        }
    }
}
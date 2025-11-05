namespace laba_8_n_3
{
    public class CarData
    {
        public static Dictionary<string, (string Developer, int Year, string Models)> GetData()
        {
            var data = new Dictionary<string, (string, int, string)>
            {
                { "BMW", ("BMW Group", 1916, "X5, i8, M3") },
                { "Mazda", ("Mazda Motor Corporation", 1920, "CX-5, Mazda3, RX-7") },
                { "Mercedes-Benz", ("Daimler AG", 1926, "C-Class, G-Class, S-Class") },
                { "Opel", ("Adam Opel GmbH", 1862, "Astra, Corsa, Mokka") },
                { "Skoda", ("Skoda Auto", 1990, "Octavia, Kodiaq, Superb") },
                { "Toyota", ("Toyota Motor Corporation", 1937, "Camry, Corolla, Supra") },
                { "Volkswagen", ("Volkswagen AG", 1937, "Caddy, Golf, Passat") }
            };

            return data;
        }
    }
}
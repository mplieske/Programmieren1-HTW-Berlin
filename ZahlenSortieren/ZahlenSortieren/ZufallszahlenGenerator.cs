using System;
using System.Collections.Generic;
using System.Text;

namespace ZahlenSortieren
{
    class ZufallszahlenGenerator
    {
        private readonly int anzahl;
        private readonly int untergrenze;
        private readonly int obergrenze;

        public ZufallszahlenGenerator(int anzahl, int untergrenze, int obergrenze)
        {
            this.anzahl = anzahl;
            this.untergrenze = untergrenze;
            this.obergrenze = obergrenze;
        }

        public int[] ErzeugeZufallszahlen()
        {
            if (anzahl <= 0 || untergrenze >= obergrenze)
            {
                return null;
            }

            Random random = new Random();

            int[] randomNumbers = new int[anzahl];
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = random.Next(untergrenze, obergrenze);
            }

            Array.Sort(randomNumbers);
            return randomNumbers;
        }
    }
}

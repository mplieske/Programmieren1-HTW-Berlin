using System;

namespace KlassenErstellenTeil2
{
    class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt1 = new Punkt(1, 2, 3);
            Punkt punkt2 = new Punkt(3, 2, 1);
            Vektor vektor1 = Punkt.BildeVektor(punkt1, punkt2);
            Vektor vektor2 = punkt1.AlsVektor();
            Console.WriteLine($"punkt1: '{punkt1}'");
            Console.WriteLine($"punkt2: '{punkt2}'");
            Console.WriteLine($"Abstand zwischen punkt1 und punkt2: '{Punkt.AbstandZwischen(punkt1, punkt2)}'");
            Console.WriteLine($"vektor1: '{vektor1}'");
            Console.WriteLine($"vektor2: '{vektor2}'");

            Vektor vektor3 = vektor1.Addiere(vektor2);
            Console.WriteLine($"'{vektor1}' + '{vektor2}' = '{vektor3}'");

            Vektor vektor4 = vektor3.Subtrahiere(vektor2);
            Console.WriteLine($"'{vektor3}' - '{vektor2}' = '{vektor4}'");

            Vektor vektor5 = vektor2.MultipliziereSkalar(2);
            Console.WriteLine($"'{vektor2}'*2 = '{vektor5}'");

            Vektor vektor6 = punkt1.AlsVektor().BildeKreuzprodukt(punkt2.AlsVektor());
            Console.WriteLine($"'{punkt1.AlsVektor()}' x '{punkt2.AlsVektor()}' = '{vektor6}'");

            double skalarprodukt = Vektor.BerechneSkalarprodukt(punkt1.AlsVektor(), punkt2.AlsVektor());
            Console.WriteLine($"'{punkt1.AlsVektor()}' * '{punkt2.AlsVektor()}' = '{skalarprodukt}'");

            Linie linie1 = new Linie(punkt1, punkt2);
            Console.WriteLine(linie1);

            Linie linie2 = linie1.VerschiebeUmVektor(new Vektor(1, 1, 1));
            Console.WriteLine(linie2);
        }
    }
}

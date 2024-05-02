using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _100legmagasabb_KB
{
    class Program
    {
        static List<Epulet> epuletek = new List<Epulet>();
        static void Main(string[] args)
        {
            beolvasas();
            feladat01();
            feladat02();
            feladat04();

            Console.ReadLine();
        }

        private static void feladat04()
        {
            Console.WriteLine("4.feladat: Kérek egy számot:");
            int evszam = int.Parse(Console.ReadLine());
            double magassag = 0;
            for (int i = 0; i < epuletek.Count; i++)
            {
                if (epuletek[i].Epites_eve < evszam)
                {
                    magassag = magassag + epuletek[i].Magassag_m;
                }
            }
            Console.WriteLine($"{evszam} előtt épült épületek összmagassága: {magassag} méter.");
        }

        private static void feladat02()
        {
            int szamlalo = 0;
            for (int i = 0; i < epuletek.Count; i++)
            {
                if (!epuletek[i].Nev.Contains("Tower"))
                {
                    szamlalo++;
                }
            }
            Console.WriteLine($"2.feladat:A 'Tower' szót nem tartalmazza {szamlalo} épület.");
        }

        private static void feladat01()
        {
            Console.WriteLine($"1.feladat: Az épületek száma {epuletek.Count}");
        }

        private static void beolvasas()
        {
            using (StreamReader sr = new StreamReader("100_tallest_javitott4.csv"))
            {
               
                while (!sr.EndOfStream)
                {
                    string[] adatsor = sr.ReadLine().Split(';');
                    Epulet a = new Epulet(int.Parse(adatsor[0]), adatsor[1], adatsor[2], double.Parse(adatsor[3]), int.Parse(adatsor[4]), int.Parse(adatsor[5]), int.Parse(adatsor[6]));
                    epuletek.Add(a);
                }
            }
        }
    }
}

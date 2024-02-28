using Microsoft.Win32.SafeHandles;
using System;

namespace ConsoleAppNeumannMasodikFordulo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. feladat \n");

            // 1a. feladat
            int kezdoszam1 = 21; 
            string eredmeny = RekurzivKetszerezettSzamsortGeneral(kezdoszam1);
            Console.Write("a) ");
            Console.WriteLine(eredmeny); // output: 1681684816816848424848168168481681684842484842421242484842484816816848168168484248481681684816816

            // 1b. feladat
            int legkisebb = Keres();
            Console.Write("b) ");
            Console.WriteLine(legkisebb); // output: 21

            // 1c. feladat
            int kezdoszam3 = 31;
            Console.Write("c) ");
            string eredmeny3 = RekurzivSzamjegyosszegSorozatotGeneral(31);
            Console.WriteLine(eredmeny3 + "\n"); // output: 11248162328384962707791101103107115122127137148161169185199218229242250257271
        }

        public static string RekurzivKetszerezettSzamsortGeneral(int szam)
        {
            if (szam == 1)
            {
                return "1";
            }

            string elozo = RekurzivKetszerezettSzamsortGeneral(szam - 1);
            string ketszerezett = "";

            foreach (char c in elozo)
            {
                int szamjegy = int.Parse(c.ToString());
                ketszerezett += (szamjegy * 2).ToString();
            }

            return ketszerezett;
        }
        public static string RekurzivSzamjegyosszegSorozatotGeneral(int szam)
        {
            if (szam == 1)
            {
                return "11";
            }

            string elozo = RekurzivSzamjegyosszegSorozatotGeneral(szam - 1);

            int osszeg = 0;

            foreach (char c in elozo)
            {
                osszeg += int.Parse(c.ToString());
            }

            return elozo + osszeg.ToString();
        }
        public static int Keres()
        {
            for (int i = 1; i < 100; i++)
            {
                string aktSzam = i.ToString();

                for (int o = 0; o < 30; o++)
                {
                    string ujSzam = "";

                    foreach (char jegy in aktSzam)
                    {
                        ujSzam += (int)char.GetNumericValue(jegy) * 2;
                    }

                    aktSzam = ujSzam;

                    if (aktSzam.EndsWith("216816212162121681684816816"))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}

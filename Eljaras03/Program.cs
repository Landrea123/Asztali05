using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljaras03
{
    internal class Program
    {
        public static List<char> irasjelek = new List<char> { '.', '!', '?' };
        public static void szoveg_statisztika(string szoveg)
        {
            if (szoveg.Trim().Length > 0)
            {
                Console.WriteLine($"Karakterek száma: {szoveg.Length} db");
                int mondatokSzama = 0;
                int szavakSzama = 1;
                foreach (char betu in szoveg)
                {
                    if (irasjelek.Contains(betu))
                    {
                        mondatokSzama++;
                    }
                    if (betu == ' ')
                    {
                        szavakSzama++;
                    }
                }
                Console.WriteLine($"Szavak száma: {szavakSzama} db");
                Console.WriteLine($"Mondatok száma: {mondatokSzama} db");
                //szavakSzáma 2. számláló algoritmus
                //string[] szavak = szoveg.Split(' ');
                Console.WriteLine($"Szavak száma: {szoveg.Split(' ').Length} db");
            }
        } 
        static void Main(string[] args)
        {
            string Szoveg = "Lórum ipse nem kaladkol! Ha vattan, már nem árta többé. Eddig 324 zatos gyele összesen 430 kutykangot vényített a dülésbe. Most 1 tortogás van jelen: 1 orgia. A szuszos fürtetők a szédő 5 törű tulyáját hajozják. A felmező körderés közetei szerint a szédő buláson fölcsön éjszaka a szemerő rotémában bankás csúnyomon belül másodszor is selyesedtek a nylakák. A desztalás nem tozott, a gotentás pedig nem volt csipes arajgásba kapcsolva. (a nylakák állítólag kangással heletették el a tarcsapupát, amely ettől „düllesztett”. A bogós guzsomodásra egy arra pörge és ott borda, lobozott takas, fiáketes rodós márla lett képző.";
            szoveg_statisztika(Szoveg);
        }
    }
}

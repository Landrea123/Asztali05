using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljaras04
{
    internal class Program
    {
        public static void leggyakoribb_szam(List<int> lista)
        {
            Dictionary<int,int> statisztika = new Dictionary<int,int>();
            foreach (int szam in lista)
            {
                if (statisztika.ContainsKey(szam))
                {
                    statisztika[szam] ++;
                }
                else
                {
                    statisztika[szam] = 1;
                }
            }
            //A legtöbbször előforduló szám meghatározása
            int legnagyobbKulcs=0, legnagyobbErtek=0;
            foreach (var kulcsErtekPar in statisztika)
            {
                if (kulcsErtekPar.Value > legnagyobbErtek)
                {
                    legnagyobbErtek=kulcsErtekPar.Value;
                    legnagyobbKulcs = kulcsErtekPar.Key;
                }
            }
            Console.WriteLine($"A(z) {legnagyobbKulcs} ({legnagyobbErtek} alkalommal fordul elő)");
        }
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>() {1, 3, 2, 3, 4, 1, 3, 2, 2, 2};
            leggyakoribb_szam(szamok);
            Console.ReadKey();
        }
    }
}

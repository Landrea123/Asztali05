using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Eljaras05
{
    internal class Program
    {
        public static List<char> irasjelek = new List<char> { '.', '!', '?', ' ', ',', ':',';' };

        public static void PalindromEllenorzes(string Kifejezes)
        {
            bool palindrom = true;
            string palindromSzoveg = "";
            foreach (char betu in Kifejezes)
            {
                if (!irasjelek.Contains(betu))
                {
                    palindromSzoveg += betu.ToString().ToLower();
                }
            }
            Console.WriteLine(palindromSzoveg);
            for (int i = 0; i < palindromSzoveg.Length / 2; i++)
            {
                //if (!(palindromSzoveg[i] == palindromSzoveg[palindromSzoveg.Length - 1 - i]))
                //{
                //    palindrom = false;
                //}

                if (palindromSzoveg[i] != palindromSzoveg[palindromSzoveg.Length - 1 - i])
                {
                    palindrom = false;
                    Console.WriteLine(i);
                    break;
                    
                }
            }

            Console.WriteLine(palindrom);
        }
        static void Main(string[] args)
        {
            Console.Write("Kérek egy szót vagy mondatot: ");
            string kifejezes = Console.ReadLine();
            PalindromEllenorzes(kifejezes);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljaras02
{
    internal class Program
    {
        public static void Koszones(string nev)
        {
            Console.WriteLine($"Szia {nev}!");
        }
        static void Main(string[] args)
        {
            Console.Write("Hogy hívják a nevedet? ");
            Koszones(Console.ReadLine());
            Console.ReadKey();
            /*
             * írjanak egy eljárást (Koszones névvel) amely kap egy szöveg típusú nev azonosítóval rendelkező paramétert.
             * Az eljárás törzsében hozzák létre azt a kódot, amely a paraméterben kapott nevet felhasználva kiírja a képernyőre, hogy Szia név!
             * Kérjenek be egy nevet.
             * 
            */
        }
    }
}

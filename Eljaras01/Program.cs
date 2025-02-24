using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eljaras01
{
    internal class Program
    {
        public static void Kiiras(int sor, int oszlop)
        {
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }



        static void Main(string[] args)
        {
            Kiiras(12,80);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpimTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çarpım Tablosu");
            Console.WriteLine("");
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.WriteLine(i + "x" + j + ":" + (i * j));
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}

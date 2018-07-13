using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDPointWithHash point1 = new TwoDPointWithHash(1, 1);
            TwoDPointWithHash point2 = new TwoDPointWithHash(10, 10);

            Console.WriteLine("Хеш код 1 = " + point1.GetHashCode());
            Console.WriteLine("Хеш код 2 = " + point2.GetHashCode());

            TwoDPointWithHash point3 = new TwoDPointWithHash(3, 3);
            TwoDPointWithHash point4 = new TwoDPointWithHash(4, 4);

            Console.WriteLine("Хеш код 3 = " + point3.GetHashCode());
            Console.WriteLine("Хеш код 4 = " + point4.GetHashCode());

            TwoDPointWithHash point5 = new TwoDPointWithHash(0, 0);
            TwoDPointWithHash point6 = new TwoDPointWithHash(0, 0);

            Console.WriteLine("Хеш код 5 = " + point5.GetHashCode());
            Console.WriteLine("Хеш код 6 = " + point6.GetHashCode());

            Console.ReadKey();
        }
    }
}

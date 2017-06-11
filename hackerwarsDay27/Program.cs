using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwarsDay27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5");

            Console.WriteLine("4 3");           //YES
            Console.WriteLine("-1 3 0 2");

            Console.WriteLine("5 1");           //NO
            Console.WriteLine("0 -1 2 1 4");

            Console.WriteLine("8 3");           //YES
            Console.WriteLine("-3 0 2 3 4 5 6 7");

            Console.WriteLine("7 5");           //NO
            Console.WriteLine("0 -1 -3 -4 -2 3 4 ");

            Console.WriteLine("6 4");           //YES
            Console.WriteLine("-1 0 4 2 9 10");

        }
    }
}

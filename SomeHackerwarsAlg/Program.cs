using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeHackerwarsAlg
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(time, "hh:mm:sstt",
        System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine(dateTime.ToString("HH:mm:ss"));
        }
    }
}

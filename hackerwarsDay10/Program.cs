using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwarsDay10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            //    Integer.toBinaryString(n).split("0+").sorted.last.length; 
            var b = Convert.ToString(n, 2);
            string[] arr = b.Split('0').ToArray();
            int c = arr.Select(x => x.Length).Max();
            Console.WriteLine(c);


        }
    }
}

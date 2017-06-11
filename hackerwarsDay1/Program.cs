using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackwarsDay1
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine()); //string[] arr_temp = "-4 3 -9 0 4 1".Split(' ');
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int neg = 0;
            int pos = 0;
            int zero = 0;
            int count = 0;
            foreach (int num in arr)
            {
                count++;
            if (num > 0)
            {
                pos++;
            }
            else if (num < 0)
            {
                neg++;
            }
            else
            {
                zero++;
            }
            }

        Console.WriteLine("{0:N6}", Decimal.Divide(pos, count));
        Console.WriteLine("{0:N6}", Decimal.Divide(neg, count));
        Console.WriteLine("{0:N6}", Decimal.Divide(zero, count));
        Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackwarsAlgDiagonals
{
    class Program
    {
        static void Main(string[] args)
        { 



            var d1_v = 0;
            var d2_v = 0;

        int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];

            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);


                d1_v += a[a_i][a_i];
                d2_v += a[a_i][(n - 1) - a_i];


            }

            Console.WriteLine(Math.Abs(d1_v - d2_v));

        }
    }
}

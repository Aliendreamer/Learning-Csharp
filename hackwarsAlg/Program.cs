﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackwarsAlg
{
    class Program
    {
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int overZero = 0;
            int underZero = 0;
            int zero = 0;
            int count = 0;
            //string[] arr_temp = "-4 3 -9 0 4 1".Split(' ');

            foreach (int i in arr)
            {
                count++;
                if (i > 0)
                {
                    overZero++;
                }
                else if (i < 0)
                {
                    underZero++;
                }
                else
                {
                    zero++;
                }

            }


            Console.WriteLine("{0:F6}", Decimal.Divide(overZero, count));
            Console.WriteLine("{0:F6}", Decimal.Divide(underZero, count));
            Console.WriteLine("{0:F6}", Decimal.Divide(zero, count));
            Console.ReadLine();




        }
    }
}

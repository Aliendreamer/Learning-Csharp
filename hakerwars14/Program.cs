using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hakerwars14
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;



        public Difference(int[]a)
        {
            elements = a;
        }

       public int computeDifference()
        {
           
            
                int max = elements.Max();
                int min = elements.Min();

                maximumDifference = max - min;



                return maximumDifference;
        }



    }
        class Program
    {
        static void Main(string[] args)
        {

            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
            Console.WriteLine();



        }
    }
}

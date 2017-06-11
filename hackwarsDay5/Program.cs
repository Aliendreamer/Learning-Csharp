using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackwarsDay5
{
    class Program
    {
        static void Main(string[] args)
        {

         int n = Convert.ToInt32(Console.ReadLine());
            // int result=0;
           

        for (int i=1;i<=10;i++)
        {
          int result = n * i;

        Console.WriteLine("{1} x {2} = {0}",result,n,i);
        }


        }
    }
}

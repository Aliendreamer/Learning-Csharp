using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwarsDay17
{
    class Calculator
    {
       
            
        public int  power(int n,int  p)
        {
            
            
                int power = (Int32)Math.Pow(n, p);
                 Exception e =new  ArgumentException();
           
            if(n>=0 && p >=0)
            {
                return  power;
            }
            else
            {
                throw new ArgumentException("n and p should be non-negative",e);
            }

        }
    }   


    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                string[] num = Console.ReadLine().Split();
                int n = int.Parse(num[0]);
                int p = int.Parse(num[1]);
                try
                {
                    int ans = myCalculator.power(n, p);
                    Console.WriteLine(ans);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }

        }
    }
}

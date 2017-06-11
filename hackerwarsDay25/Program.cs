using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwarsDay25
{
    class Program
    {
        static void Main(string[] args)
        {
            int tCases = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < tCases; i++)
            {
                int n = Int32.Parse(Console.ReadLine());
                bool prime = true;
                if (n < 2)
                {
                    prime = false;
                }
                else
                {
                    for (int x = 2; x <= (int)Math.Sqrt(n); x++)
                    {
                        if (n % x == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                }
                Console.WriteLine((prime) ? "Prime" : "Not prime");
            }
        }
    }
}

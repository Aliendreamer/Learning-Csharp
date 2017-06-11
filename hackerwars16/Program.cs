using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwars16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string S = Console.ReadLine();
                int ss = int.Parse(S);
                Console.WriteLine(ss);
            }
            catch(Exception)
            {
                Console.WriteLine("Bad string");
            }
        }
    }
}

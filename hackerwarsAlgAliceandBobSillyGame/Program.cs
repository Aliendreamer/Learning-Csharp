using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwarsAlgAliceandBobSillyGame
{
    class Program
    {
        static void Main(string[] args)
        { 


            // subirame vhodnoto info v games sa vsichki igri

            List<int> games = new List<int>();

            int g = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < g; a0++)
            {
               int n =Convert.ToInt32(Console.ReadLine());

                games.Add(n);
           
            }

            // logic gamesprime subira  sbora na vsichki prime chisla v edna igra kato int odd ili even
            
            List<int> gamesPrime = new List<int>();
            

            foreach (int gg in games)
            {

                int count = 0;

                int num = gg;
                for (int number=1; number<=num; number++)
                {
                   


                    var prime = isPrime(number);
                    if(prime==true)
                    {
                        count += 1;
                    }

                    


                }
                gamesPrime.Add(count);

            }



            foreach (int primesCount in gamesPrime)
            {
                if(primesCount %2==0)
                {
                    Console.WriteLine("Bob");

                }
                else
                {
                    Console.WriteLine("Alice");
                }

            }



        }
        static  bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        
    }
}

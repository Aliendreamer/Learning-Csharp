using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingFundamentalsExam26022017HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        {

            string []beehives =Console.ReadLine().Split(' ');
            int[] beehivesInt = Array.ConvertAll(beehives, Int32.Parse);

            string [] hornets = Console.ReadLine().Split(' ');
            int[] hornetsInt = Array.ConvertAll(hornets, Int32.Parse);

            List<int>alivebees= new List<int>();

            List<int> hornetsLeft = new List<int>(hornetsInt);

            foreach (int item in beehivesInt)
            {
                for (int i = item; i < beehivesInt.Length; i++)
                {
                    //  int totalBeeHives = beehivesInt.Sum();

                    int totalHornets = hornetsInt.Sum();

                    if (item >= totalHornets)
                    {
                        alivebees.Add(item - totalHornets);

                        hornetsInt.Skip(1);
                        hornetsLeft.Remove(0);
                    }
                    else if (item < totalHornets)
                    {
                        continue;

                    }

                    //  Console.WriteLine("{0}", alivebees.First());

                }

                foreach (var survived in hornetsLeft)
                {
                    Console.WriteLine(survived);
                }
                

            }




        }
    }
}

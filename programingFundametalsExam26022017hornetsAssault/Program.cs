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

            string[] beehives = Console.ReadLine().Split(' ');
            int[] beehivesInt = Array.ConvertAll(beehives, Int32.Parse);

            string[] hornets = Console.ReadLine().Split(' ');
            int[] hornetsInt = Array.ConvertAll(hornets, Int32.Parse);

            List<int> alivebees = new List<int>();

            List<int> hornetsLeft = new List<int>(hornetsInt);

            int totalHornets = hornetsInt.Sum();


            foreach (int item in beehivesInt)
            {

                if (item >= totalHornets)
                {
                    int difference = item - totalHornets;

                    if (difference > 0)
                    {
                        alivebees.Add(difference);
                    }

                    totalHornets = totalHornets - hornetsInt[0];

                    hornetsLeft.Remove(hornetsLeft[0]);
                }
                else if (item < totalHornets)
                {
                    continue;

                }
                else if(hornetsLeft.Count ==0)
                    {
                    break;
                }
                //  Console.WriteLine("{0}", alivebees.First());



            }

            if (alivebees.Count != 0)
            {
                string otherfinal = "";
                foreach (int num in alivebees)
                {
                    otherfinal = otherfinal += num + " ";
                }
                Console.WriteLine($"{otherfinal}");

            }
            else
            {
                string final = "";
                foreach (var survived in hornetsLeft)
                {
                    final = final += survived + " ";

                    //     box = box += value + " ";

                }
                Console.WriteLine("{0}", final);
            }





        }
    }
}

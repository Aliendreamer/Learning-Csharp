using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {

            //input

            List<long> beehives = Console.ReadLine().Split(' ').Select(Int64.Parse).ToList();

            List<long> hornets = Console.ReadLine().Split(' ').Select(Int64.Parse).ToList();

            // TODO logic

            long hornetsPower = hornets.Sum();

            List<long> beesAlive = new List<long>();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count != 0)
                {
                    foreach (long item in beehives)
                    {

                        if (item >= hornetsPower)
                        {
                            long difference = item - hornetsPower;

                            if (difference != 0)
                            {
                                beesAlive.Add(difference);
                            }
                            hornetsPower = hornetsPower - hornets[0];

                            hornets.RemoveAt(0);
                        }
                        else
                        {
                            continue;

                        }
                    }
                    break;
                }



            }

            if (beesAlive.Count != 0)
            {
                string otherfinal = "";
                foreach (int num in beesAlive)
                {
                    otherfinal = otherfinal += num + " ";
                }
                Console.WriteLine($"{otherfinal}");
            }
            else
            {
                string final = "";
                foreach (var survived in hornets)
                {
                    final = final += survived + " ";

                    //     box = box += value + " ";

                }
                Console.WriteLine("{0}", final);
            }




        }
    }
}

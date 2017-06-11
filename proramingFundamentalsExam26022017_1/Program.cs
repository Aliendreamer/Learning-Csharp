using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proramingFundamentalsExam26022017_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberofFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());
            const int  wingFlapsPerSecond= 100;

            double totalDistanceTraveled = (numberofFlaps /1000) * distance;

            double traveltime = numberofFlaps /wingFlapsPerSecond;
            double restTime = (numberofFlaps / endurance) * 5;
            double totaltime = traveltime + restTime;

            Console.WriteLine("{0:f2} m. \n{1} s.",totalDistanceTraveled,totaltime);





        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackwars
{
    class Program
    {
        static void Main(string[] args)
        {
             double  mealCost =double.Parse(Console.ReadLine());
            int tipPercent = int.Parse(Console.ReadLine());
            int taxPercent = int.Parse(Console.ReadLine());

                
            double tip = (mealCost * (double)tipPercent) / 100;

            double tax =(mealCost*(double)taxPercent) / 100;

            double totalCost = Math.Round(mealCost + tip + tax);


            Console.WriteLine("The total meal cost is {0} dollars", totalCost);


        }
    }
}

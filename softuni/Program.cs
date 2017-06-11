using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            double price1 = 0;
            double price2 = 0;
            double discount = 0;
            double totalPrice = 0;
            double sumTotalPrice = 0;
            double pricePerPerson = 0;
            string hall = "";
            if (groupSize <= 50)
            {
                price1 = 2500;
                hall = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                price1 = 5000;
                hall = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                price1 = 7500;
                hall = "Great Hall";
            }
            if (package == "Normal")
            {
                price2 = 500;
                discount = 0.05;
            }
            else if (package == "Gold")
            {
                price2 = 750;
                discount = 0.10;
            }
            else if (package == "Platinum")
            {
                price2 = 1000;
                discount = 0.15;
            }
            totalPrice = price1 + price2;
            sumTotalPrice = totalPrice - discount * totalPrice;
            pricePerPerson = sumTotalPrice / groupSize;
            if (groupSize > 120)
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }

        }
    }
}

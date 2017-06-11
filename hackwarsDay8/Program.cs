using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackwarsDay8
{
    class Program
    {
        static void Main(string[] args)
        {

            int entries = int.Parse(Console.ReadLine());

            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            for (int i = 0; i < entries; i++)
            {
                string[] data = Console.ReadLine().Split(' ');

                phoneBook.Add(data[0], Convert.ToInt32(data[1]));
            }

            string name;
            while ((name = Console.ReadLine()) != null)
            {
                if (phoneBook.ContainsKey(name))
                    Console.WriteLine(name + "=" + phoneBook[name]);
                else
                    Console.WriteLine("Not found");
            }


        
        }
    }
}
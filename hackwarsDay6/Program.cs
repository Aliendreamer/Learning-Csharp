using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackwarsDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTastCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfTastCase; i++)
            {
                char[] stringCol = Console.ReadLine().ToCharArray();

                string firstString = string.Empty;
                string lastString = string.Empty;

                for (int j = 0; j < stringCol.Length; j++)
                {
                    firstString += (j % 2) == 0 ? stringCol[j].ToString() : "";
                    lastString += (j % 2) != 0 ? stringCol[j].ToString() : "";
                }

                Console.WriteLine(firstString + " " + lastString);
            }







        }
    }
}

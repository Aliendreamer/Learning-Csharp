using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwarsDay11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);

            }
            List<int> sums = new List<int>();
            int rowSize = arr.Length;
            if (rowSize == 0) Console.WriteLine(0);
            int colSize = arr[0].Length;

            for (int i = 0; i < rowSize - 2; i++)
            {
                for (int j = 0; j < colSize - 2; j++)
                {
                    sums.Add(getSumGlass(arr, i, j));
                }

            }

            Console.WriteLine(sums.Max());
        }
        static int getSumGlass(int[][] arr, int i, int j)
        {
            int result = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
            return result;
        }
    }       
}

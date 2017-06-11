using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
        int N = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < N; a0++)
        {
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];
            var element = new KeyValuePair<string, string>(emailID, firstName);
            list.Add(element);

        }
        var res = from a in list
                  where a.Key.EndsWith("@gmail.com")
                  orderby a.Value ascending
                  select a.Value;
        foreach (var name in res)
        {
            Console.WriteLine(name);
        }
        Console.ReadKey();
    }
}

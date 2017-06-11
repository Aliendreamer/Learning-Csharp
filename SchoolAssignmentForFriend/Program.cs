using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAssignmentForFriend
{
    class Program
    {
        static void Main(string[] args)
        {
          


            Console.OutputEncoding =Encoding.UTF8;

            int n = 10;
            List<string> answeredQuestions = new List <string>();
            string answer = string.Empty;

            Dictionary<int, string> Questions = new Dictionary<int, string>
            {
                { 1,"Как е името ти?"},
                {2,"Where are you from" },
                {3,"How old you are"},
                {4,"From which school" },
                {5,"what is your nickname"},
                {6,"Favorite song"},
                {7,"favorite color"},
                {8,"favorite place"},
                {9,"who is your best friend"},
                {10,"What languages you speak"}
            };

            for(int i=1;i<=n;i++)
            {
                if(Questions.ContainsKey(i))
                {
                    string question = Questions[i];
                    Console.WriteLine(question);
                    answer = Console.ReadLine();
                    answeredQuestions.Add(answer);

                }
               if (answer.Length != 0
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }


        }
    }
}

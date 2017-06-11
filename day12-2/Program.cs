using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_2
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
    class Student : Person
    {
        private int[] testScores;


        public Student(string firstName, string lastName, int identification,int[]scores)
        { 

            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
            this.testScores=scores;
        }

        
            public char Calculate()
            {
                int sum = 0;
                for (int i = 0; i < testScores.Length; i++)
                {
                    sum = sum + testScores[i];
                }

                int result = sum / testScores.Length;

                if (result <= 100 && result >= 90)
                {
                    return 'O';
                }
                if (result < 90 && result >= 80)
                {
                    return 'E';
                }
                if (result < 80 && result >= 70)
                {
                    return 'A';
                }
                if (result < 70 && result >= 55)
                {
                    return 'P';
                }
                if (result < 55 && result >= 40)
                {
                    return 'D';
                }
                else
                    return 'T';

            }



        }


        class Solution
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    
   }
}

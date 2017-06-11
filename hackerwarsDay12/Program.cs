using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwarsDay12
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


    class Student:Person
    {
        

        public Student(string firstName,string lastName,int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void scoreTest(int[] scores, int number)
        {
          int average =(scores.Sum())/number;
            char score=' ';
          if(90<= average && average<=100)
            {
                score = 'O';

                    
            }
          else if(80<=average && average<90)
            {
                score = 'E';
            }
          else if(70<=average && average<80)
            {
                score = 'A';
            }
          else if(60<=average && average<70)
            {
                score = 'P';
            }
          else if(50<=average && average<60)
            {
                score = 'D';
            }
          else if(average<40)
            {
                score = 'F';
            }
          else
            {
                score = '?';
            }

             Console.WriteLine($"Grade: {score}");
        }


    }


        class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ').ToArray();
            int number = int.Parse(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);

            string firstName = input[0];
            string lastName = input[1];
            int identification =Convert.ToInt32(input[2]);


            Student Student = new Student(firstName,lastName,identification);
            Student.printPerson();
            Student.scoreTest(scores,number);




        }
    }
}

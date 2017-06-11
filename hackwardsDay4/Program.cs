using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackwardsDay4
{
    class Person
    {
        public int age;

        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge

            if (initialAge >= 0)
            {
                age = initialAge;
            }
            else
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                age = 0;
            }




        }
        public void amIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (age <= 13)
            {
                Console.WriteLine("You are young.");

            }
            else if (13 <= age && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else if(age>=18)
            {
                Console.WriteLine("You are old.");
            }
        }

        public int  yearPasses()
        {
            // Increment the age of the person in here
            age += 1;

            return age;
        }

    }    


        class Program
    {
        static void Main(string[] args)
        {
                int T = int.Parse(Console.In.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.In.ReadLine());


                Person p = new Person(age);
                p.amIOld();

                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
            }

                
        }
    }
}

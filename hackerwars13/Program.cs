using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerwars13
{

      abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();


    }
      class MyBook : Book
    {
        public int price;


        public MyBook(String t,String a,int price)
            :base( t , a)
        {
            
            this.price = price;
            
        }

       public override void display()
        {
            Console.WriteLine($"Title: {title}\n Author: {author}\n Price: {price}");

        }

    }








        class Program
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        




        }
    }
}

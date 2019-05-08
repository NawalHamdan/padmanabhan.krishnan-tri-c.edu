using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
           

namespace Application

    {

        class Book

        {

            public String title;

            public String author;

            public String year;



            public Book(String Title, String Author, String Year)
            {

                this.title = Title;

                this.author = Author;

                this.year = Year;

            }



            voil Display()
            {

                Console.WriteLine("Title", this.title);



                Console.WriteLine("Author", this.author);

            }

        }

        class BookTest

        {

            static void Main(string[] args)

            {

                Book book = new Book("CS", "Sumit", "2015");

                book.Display();

            }

        }

    }
}
    }
}

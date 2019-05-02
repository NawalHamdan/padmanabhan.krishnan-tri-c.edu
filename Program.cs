using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] array = new int[12];

                Console.WriteLine("{0}{1,15}", "Index", "Month");
                {
                    String[] month = new string[12];
                    month[0] = "January";
                    month[1] = "Febraury";
                    month[2] = "March";
                    month[3] = "April";
                    month[4] = "May";
                    month[5] = "June";
                    month[6] = "July";
                    month[7] = "August";
                    month[8] = "September";
                    month[9] = "October";
                    month[10] = "November";
                    month[11] = "December";
                    {
                        for (int counter = 0; counter < array.Length; ++counter) ;
                        Console.WriteLine("{0}{1,15}", counter, string[month]);

                    }
                }
            }
        }
    }
    namespace Lab06question3
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
                Console.WriteLine("The Four Seasons");
                foreach (string season in seasons)
                {
                    Console.WriteLine(season);

                }
            }
        }
        namespace Lab06question4
        {
            class Program
            {
                static void Main(string[] args)
                {
                    int[] array;
                    array = new int[1000];
                    {
                        Random randomNumbers = new Random(1000);
                        int randomNumber = randomNumber.Next();
                        {
                            foreach (randomNumber in randomNumber.Next(0, 100)) ;  // place this line in the loop
                            Console.WriteLine("{0}");
                        }
                    }
                }
            }

        }
        namespace Lab06questionsnames
        {
            class Program
            {
                static void Main(string[] args)
                {
                    string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

                    int i = 0;
                    {
                        while (i < names.Length)

                            Console.WriteLine(string[names]);

                    }
                }
            }

        }
        namespace Lab06questionsn6
        {
            class Program
            {
                static void Main(string[] args)
                {

                    string[] names = new string[5] { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
                    int i = 0;
                    {
                        for (int i = 0; i < names.Length; ++i) ;

                        Console.WriteLine("{0,2}. {1}", i, names[i]);
                    }
                }
            }
        }
        namespace Lab06questionsn7
        {
            class Program
            {
                static void Main(string[] args)
                {

                    string[] names = new string[5] { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
                    int i = 0;
                    {
                        foreach (string name in names)

                            Console.WriteLine("{0,2}. {1}", i, names[i]);
                    }
                }
            }

        }
    }
}
//1.A one-dimensional array p contains four elements.  The array access expressions to access each of the elements in p are ____[0]___, __[1]_____,___[2]____ and ____[3]__.
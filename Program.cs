using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 11)

                    keepLooping = false;
                i++;
                Console.WriteLine(i);


            }
            int value1 = 2;
            while (value1 <= 64)
            {
                {
                    if ((value1 % 2) == 0)
                    {
                        Console.WriteLine("[{0}]", value1);
                    }
                    else if ((value1 % 2) != 0)
                    {
                        Console.Write("");
                    }
                    value1 *= 2;
                }
            }

            int value2 = 2;
            while (value2 <= 64)
            {
                {
                    if ((value2 % 2) == 0)
                    {
                        Console.WriteLine("[{0}]", i);
                    }
                    else if ((value2 % 2) != 0)
                    {
                        Console.Write("");
                    }
                    value2 *= 2;
                }
            }

            string j = ",";
            int value3;
            for (value3 = 99; value3 >= 1; --value3)
            {
                Console.Write(value3);
                if (value3 >= 2)
                {
                    Console.Write(j);
                }

            }
            int value4 = 1;
            while (value4 <= 21)
            {
                {
                    if ((value4 % 2) == 0)
                    {
                        Console.Write(" ");
                    }
                    else if ((value4 % 2) != 0)
                    {
                        Console.Write(value4);
                    }
                    value4++;
                }
            }

            int n = 8;
            int value5 = 10; // initialize
            do
            {
                Console.Write("*");
                value5++; // update!
            } while (value5 < n); // test condition
            Console.Write("Please enter a whole number from 1-12: ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month == 12)
            {
                Console.WriteLine("The month is December.");
            }
            else if (month == 11)
            {
                Console.WriteLine("The month is November.");
            }
            else if (month == 10)
            {
                Console.WriteLine("The month is October.");
            }
            else if (month == 9)
            {
                Console.WriteLine("The month is September.");
            }
            else if (month == 8)
            {
                Console.WriteLine("The month is August.");
            }
            else if (month == 7)
            {
                Console.WriteLine("The month is July.");
            }
            else if (month == 6)
            {
                Console.WriteLine("The month is June.");
            }
            else if (month == 5)
            {
                Console.WriteLine("The month is May.");
            }
            else if (month == 4)
            {
                Console.WriteLine("The month is April.");
            }
            else if (month == 3)
            {
                Console.WriteLine("The month is March.");
            }
            else if (month == 2)
            {
                Console.WriteLine("The month is February.");
            }
            else if (month == 1)
            {
                Console.WriteLine("The month is January.");
            }

            Console.Write("Please enter a whole number from 1-12: ");
            int Month = Convert.ToInt32(Console.ReadLine());
            switch (Month)
            {
                case 1:
                    Console.WriteLine("The month is January.");
                    break;
                case 2:
                    Console.WriteLine("The month is February.");
                    break;
                case 3:
                    Console.WriteLine("The month is March.");
                    break;
                case 4:
                    Console.WriteLine("The month is April.");
                    break;
                case 5:
                    Console.WriteLine("The month is May.");
                    break;
                case 6:
                    Console.WriteLine("The month is June.");
                    break;
                case 7:
                    Console.WriteLine("The month is July.");
                    break;
                case 8:
                    Console.WriteLine("The month is August.");
                    break;
                case 9:
                    Console.WriteLine("The month is September.");
                    break;
                case 10:
                    Console.WriteLine("The month is October.");
                    break;
                case 11:
                    Console.WriteLine("The month is November.");
                    break;
                case 12:
                    Console.WriteLine("The month is December.");
                    break;

            }
        }
}
}


//1. Different control structures we use are loops, if statements and switch statements. 
// Loops such as while, do while and for will repeat a fragment of code until the terminating sequence is met.If statements, if else and else statements use logic to solve code, and switch statements can be used in replacement of if else statements.
//8.We combine multiple Boolean values by nested if or if else statements. Three primary operators that we use when working with multiple Boolean values are: ||, &&, and !.



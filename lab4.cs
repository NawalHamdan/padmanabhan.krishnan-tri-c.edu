using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class lab4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("Number is even");
                    }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is odd");
                    }
                }
            }
            Console.Write("Please enter a temperature: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp >= 90)
            {
                Console.WriteLine("fish");
            }
            else if (temp >= 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temp >= 70)
            {
                Console.WriteLine("Turle");
            }
            else if (temp >= 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temp >= 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temp >= 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temp >= 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temp >= 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else
            {
                Console.WriteLine("Bug");
            }
            Console.Write("Please enter the exhibit number: ");
            int exhibit = Convert.ToInt32(Console.ReadLine());
            switch (exhibit)
            {
                case 1:
                    Console.WriteLine("Polar Bear");
                    break;
                case 2:
                    Console.WriteLine("Penguin");
                    break;
                case 3:
                    Console.WriteLine("Moose");
                    break;
                case 4:
                    Console.WriteLine("Reindeer");
                    break;
                case 5:
                    Console.WriteLine("Deer");
                    break;
                case 6:
                    Console.WriteLine("Turtle");
                    break;
                case 7:
                    Console.WriteLine("Lion");
                    break;
                case 8:
                    Console.WriteLine("Fish");
                    break;
                case 9:
                    Console.WriteLine("Bug");
                    break;
            }

        }
    }
}
//2. The four basic elements needed for the counter-controlled repetition are: control variable, initial value, increment (decrement) and the loop-continuation condition. The control variable is often referred to as a loop counter. The initial value is the starting point of the control variable, increment or decrement is how the control variable is modified each time it loops, and the loop continuation condition is what determines if the script should continue looping or not. 
// 3. A “for” and “while” statement are almost the same. They both do the same operation. However a “for” statement is a condensed version of a “while” statement. A “while” statement would go as such:  Int i=0   While (i<10)   { Console.writeline(i);  i++   }  But a “for” statement would be written as  uch: For(int i=0; i<10; i++) {Console.writeline(i); }
//4.A do-while statement would be more appropriate to than a while statement, only when the condition at which they run at must run after the loop. An example of such is:
//int sum = 0; int i = 0;  do   { 	sum += i; 	i++; 	} 	while (i< 5); 	return sum;
//7. int i = 10;
//while (i< 21)
//{
  //  Console.WriteLine(i);
 //}

   // the correct int i = 9;
      // while (i< 20)
          //  {
              //  i++;
              //  Console.WriteLine(i);
          //  }
 
    
    
    
    
    //8. for (int i = 0; i < 101; i++)                   
   // Console.WriteLine(i);
    //Console.WriteLine("********"); 

// the correct for (int i = 0; i < 101; i++)
         //   {
           //     Console.WriteLine(i);
             //   Console.WriteLine("********");
            //}
//8.




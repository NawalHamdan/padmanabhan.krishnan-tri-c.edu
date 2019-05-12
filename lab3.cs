using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class lab3
    {
        static void Main(string[] args)
        {
            int Speedlimit;
            int speed;

            Speedlimit = 35;
            speed = 42;

            if (speed > Speedlimit)
            {
                Console.WriteLine("SlowDown!");
            }

            Console.WriteLine("Input temperature in Fahrenheit: ");
            int fah = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int FtoC = ((fah - 32) / 9) * 5;
            Console.WriteLine("Temperature in Celsius is {0}: ", FtoC);
            Console.ReadLine();

            int i = 1;

            while (i < 11)
            {
                Console.Write("While Output: ");
                Console.WriteLine(i);
                i++;
            }

        }
    }
}


// 2. Both if single and while repetition statements share the similarity in which they must evaluate if a given value is either true or false. Requiring they meet a certain condition in order for them to stop executing code. They are different because the “if” condition only does what it is told to, then stops. While the “while” condition repeats over and over until it hits its loop termination. 
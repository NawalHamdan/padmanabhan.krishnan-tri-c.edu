using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; // declare first number to add 
            int number2; // declare second number to add 
            int mult; // declare multiplication of number1 and number2 
            
            Console.Write (" Enter first integer:" ); // promt user 
            // read first number from user
            number1 = int.Parse(Console.ReadLine());

            Console.Write(" Enter second integer:"); // promt user 
            // read first number from user
            number2 = int.Parse(Console.ReadLine());
            mult = number1 * number2; // multiply numbers
            Console.WriteLine($"mult is {mult}"); // disply multiplication 
            
            {
                string person = "Nawal Hamdan";
                Console.WriteLine($"Welcome World!       from { person}");
                //5.a.	At what point in the program does our C# Console Application execution?
               // The main method marks the execution. 

//b.What is the difference between an integer type variable and a double / floating - point variable?
//Integer type variable is any number without decimals.While double/ floating - point variable have decimals in them.The difference between double/ floating - point variables are digit limitations. 
//c.We can create blocks of code that we can call by name using a method.  Give an example of a method from Chapter 4.
//An example of a method shown to us in chapter 4, is the “DisplayMessage” method.

//d.Like we have types double and int, we can create our own custom types using Classes.Each class has variables called instance variables or class members.  To read the value of an instance variable, we create method called a(get) accessor.To assign a value ton instance variable, we use a method called a(set) accessor.

//e.What is the difference between a class and an object? How many instances of a class can we create(please explain your answer)?
//Each object in Visio is defined by a class. A class is used to hold descriptions of variables, properties, instructions and events of an object. Therefor objects are instances of classes.Once you have your class, you can create as many objects as you need.

            }

}
    }
}


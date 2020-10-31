using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLab2
{
    public class Multiplication
    {
   

        // Main method begins execution of C# application 

        public static void Main(string[] args)
        {
            int number1; // declare first number to multiply 
            int number2; // declare second number to multiply
            int product; // declare product of number1 and number2

            Console.WriteLine("Enter first integer: "); // prompt user 
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine() );

            Console.WriteLine("Enter second integer: "); // prompt user 
            // read second number from user 
            number2 = Convert.ToInt32(Console.ReadLine() );

            product =  number1 * number2; // multiply numbers 

            Console.WriteLine("Product is {0}", product); // display product

            Console.WriteLine("{0}\n{1}", "Hello World", "From Steve Farkas!");

            Console.WriteLine("{0}\t{1}", "Hello World", "From Steve Farkas!");

            // a. Our C# Console application execution will occur with the introduction of the main method which is the main entry point of our program that will execute all objects and associated methods.  
           

            // b. An integer type variable is a type of numerical data that deals strictly with whole numbers (7,-42,0,etc.) 
            // (continued...) A double/floating point variable is primarily used to specify numbers with decimal points (12.4, 7.1, 0.0).  These types of variables will store approximations of real numbers in memory.
            
            // c. An example of a method illustarated in Chapter 4 is the GetName Method (Page 114) which "returns a particular Account object's name to the caller, a string, as specified by the method's return type." 
            //  (Continued...) Ex: public string GetName() 
            // {
            // return name; // returns name's value to this method's caller 
            // }

            // d. We would use a method called the Get Accessor in order to read the value of an instance variable and use the Set Accessor to assign a value to an instance variable.  
            
            // e. A class in C# enables us to define properties, fields, events, methods, etc. as well as defining the the type of data and functionality its objects will consist of.  
            // (Continued...) An object represents the actual component of a program or "instance" of a class being defined certain characteristics such as a valid range of values and a default value.  
            // (Continued...) Technically speaking, we can assign as many "instances" to a class as we want while taking into account limitations such as virtual memory capacity and pre-defined paramaters that constitute the use of such objects.    







            
        }
    }
}

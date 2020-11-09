using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    // Main method begins execution of C# app 
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int speed;

             speedLimit = 35;
             speed = 42;

            if (speed >= speedLimit)
            
                Console.WriteLine("SLOW DOWN");
            
        }
    }
}

// Boolean Program Expression (4.)

class Program2
{

}

    bool isTrue = true;
    if (!isTrue)
    {
        Console.WriteLine("It is True!");
    }
    else
    {
        Console.WriteLine("It is False!");

    }

// 5. If Statement Program (Temperature)

namespace Temps
{
    class Program3
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the temperature in F to be converted to C");

            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"C is {celsius}");

            if (fahrenheit < 40)
            {
                Console.WriteLine("It is cold!");
            }
            if (fahrenheit > 90)
            {
                Console.WriteLine("It is hot!");
            }

        }

    }
}

/// While loop (values 10-20, Increment by 2) 


class Program4
{
    static void Main(string[] args)
    {
        int counter = 10;

        do
        {
            Console.WriteLine($"{counter}");
            counter = counter + 2;
        }
        while (counter <= 20);
    }
}

/// While loop (values 60-20, Decrement by 5)


class Program5
{
    static void Main(string[] args)
    {
        int i = 60; // First value of integer i 
        while (i >= 20)
        {
            Console.WriteLine(i);
            i--;
        }
    }
}


/// While loop (values 1-10, Increment by 1) 

class Program6
{
    static void Main(string[] args)
    {
        int i = 1; // first value of integer i 
        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
    }
} 




// 2. An if single-selection statement is characterized by selecting or ignoring a single action depending on if the condition is true (select) or false (ignore).  
// (Continued...) A while-repetition statement is defined by its tendency to loop (iterating) while its pre-determined condition remains true between braces that delimit its body.  
// (Continued...) They are both similar in regards to obeying their defined conditions taking into account the input from the user declares the statment true or eventually terminates when proven false.  
// (Continued...) The difference between the two statements is that our single selection statement will execute the true aspect of the statement and if proven false will eventually skip it however our while statement will continue to execute the code until all determined conditions have been met.   




























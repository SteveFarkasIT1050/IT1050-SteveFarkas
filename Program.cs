using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4

    // 2. The four basic elements of the counter controlled repetition are: The control variable which is responsible for regulating control flow of a certain program, the control variable's initial value which sets the beginning value of the control variable, the increment of the control variable that will be applied for each iteration of the loop and finally the loop-continuation condition which is responsible for determining if the looping should continue to proceed.  
    // 3. The for repetition statement is specifically used to define the elements of counter-controlled iteration within a single line of code.  These for statements are typically used for counter-controlled iteration but can also be utilized for sentiel-controlled iteration as compared to its counterpart the while repetition statement.  The while statement although primarily used for sentinel-controlled iteration can actually be used as well for counter-controlled iteration making both these statements ideal for either iteration.  
    // 4. It would be more appropriate to implement a do while statement in the example of creating a program that outputs values from 1-10 than it would be to use a while statement.  This is the case because although they are similiar, the do while statement will test the loop-continuation condition after executing the loop's body verifying that the body will always execute at least once.  Its counterpart, the while statement will test the same loop-continuation condition rather at the beginning of the loop before execution of the loop's body were to occur.  The body will never execute if the condition is false under the while statement however under the do while statement when termination has occurred, execution will continue onward with the statements further along in the sequence making this option more beneficial especially for a numerical sequence.    
{
    class Program
    {
        static void Main(string[] args)
        {
            // for statement header includes initialization 
            // loop-continuation condition and increment 
            for (int i = 1; i <= 100; i++) 
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
               
               
            }

            
        
        }
    }





  
class Program2
{
    static void Main1(string[] args)
    {
        Console.WriteLine("Please enter a temperature.");

        int temp;
        temp = Convert.ToInt32(Console.ReadLine());

        if (temp < 10)
        {
            Console.WriteLine("Polar Bear");
        }


        else if (temp < 20)
        {
            Console.WriteLine("Penguin");
        }

        else if (temp < 40)
        {
            Console.WriteLine("Moose");
        }

        else if (temp < 50)
        {
            Console.WriteLine("Reindeer");
        }

        else if (temp < 60)
        {
            Console.WriteLine("Deer");
        }

        else if (temp < 70)
        {
            Console.WriteLine("Turtle");
        }

        else if (temp < 80)
        {
            Console.WriteLine("Lion");
        }

        else if (temp < 90)
        {
            Console.WriteLine("Fish");
        }

        else if (temp == default)
        {
            Console.WriteLine("Bug");
        }
        }
        }
        





    class Program3
    {
        static void Main2(string[]args)
        {

            int i = 10;
            {
                while (i < 21)
                {

                    Console.WriteLine(i++);
                }
            }
        }
    }







    class Program4
    {

        static void Main3(string[]args)
        {

            for(int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");

            }
        }
    }

    


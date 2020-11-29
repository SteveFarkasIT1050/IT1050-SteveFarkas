using System;

namespace Lab6
{
    class Program
    {
        /// 1.  Fill in the blank statement: p[0], p[1], p[2] and p[3] are the array access expressions accessing each of the elements.  


        static void Main(string[] args)
        {
            string[] months =

                {

                "1 January", "2 February", "3 March", "4 April", "5 May",
                "6 June", "7 July", "8 August", "9 September", "10 October", "11 November",
                "12 December"

                };
            Console.WriteLine($"{"#"} {"Month"}");
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(months[i]);
            }


        }
    }
}


class Seasons
{
    static void Main(string[] args)
    {
        string[] seasons = { "Winter", "Spring", "Summer", "Fall" };

        foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }


    }
}


class Names
{
    static void Main(string[] args)
    {
        string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

    }
}


class InitArray
{
    static void Main(String[] args)

    {
        int[] integers = new int[1000];

        Random random = new Random();
        int randomNumber;
        foreach (var number in integers)
        {
            
            randomNumber = random.Next(0, 100);
            integers[number] = randomNumber;
        }



    }
}


class InitArray2
{
    static void Main(String[] args)

    {
        int[] integers = new int[1000];

        Random random = new Random();
        int randomNumber;
        foreach (var number in integers)
        {
            Console.WriteLine("{0,2}. {1}", integers, random);
            randomNumber = random.Next(0, 100);
            integers[number] = randomNumber;
        }

       


    }
}

class Names2 
    {
    static void Main(string[] args)
    {
        string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

        foreach (string name in names)
        {
            Console.WriteLine(names);
        }

    }
}








































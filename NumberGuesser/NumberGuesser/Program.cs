using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//name space
namespace NumberGuesser
{
    //main class
    class Program
    {
        //emtru point method
        static void Main(string[] args)
        {
            //String name = "Nico Virgino";
            //int age = 26;

            //Console.WriteLine("{0} is {1}", name, age);



            //changing text color here:
            Console.ForegroundColor = ConsoleColor.Red;
            //set up some varsss
            string appName = "Number Guesser";
            string appVer = "1.0.0";
            string appAuthor = "Nico V";
            //header here
            Console.WriteLine("{0}: version: {1}. Created by: {2}", appName, appVer, appAuthor);


            //rest color here for user
            Console.ResetColor();

            //ask users name here:
            Console.WriteLine("What is your name?");

            //get user input here
            string userInput = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a little game. . .", userInput);

            //set the correct number here
            int correctNum = 7;


            ////init guess var


            int guess = 0;

            while (guess != correctNum)
            {
                try
                {

                    Console.WriteLine("Guess a number between 1 and 10: ");
                    string userIntInput = Console.ReadLine();
                    guess = Int32.Parse(userIntInput);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Wrong number, try again");
                    Console.ResetColor();

                    if (guess == correctNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("nice job, {0}", userInput);
                    }



                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("That wasn't a number!");
                    Console.ResetColor();
                  
                }

            }




            ////convert to integer here
            //int res = Convert.ToInt32(userIntInput);


            //else { Console.WriteLine("try again");  }



        }
    }
}

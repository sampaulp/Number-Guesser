using System;

//Namespace - Like a container
namespace numberGuesser
{
    // Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sampaul";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Display App info
            Console.WriteLine("{0}: Version {1} by {2}",appName, appVersion, appAuthor);
            Console.Beep();

            //Reset color
            Console.ResetColor();

            //Ask user name
            Console.WriteLine("What is your name?");

            //Get the user input
            string userName = Console.ReadLine();

            //Write the message
            Console.WriteLine("Hey {0}, Lets play a game!", userName);

            // Correct number
            int correctNumber = 7;

            //initial guess
            int guess = 0;

            //Ask the user to guess the number
            Console.WriteLine("Please guess a number between 1 and 10");


            while(guess != correctNumber)
            {
                //Get user input
                string initialInput = Console.ReadLine();

                //Make sure it is a number
                if (!int.TryParse(initialInput, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an actual number!!");
                    Console.ResetColor();

                    //Keep going
                    continue;
                }
                guess = Int32.Parse(initialInput);

                if (guess != correctNumber)
                {
                    //Print that the guess is wrong
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong, please guess another number");
                    Console.Beep();
                    Console.ResetColor();
                }
            }

            //Print that the guess is right
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct guess!!");
            Console.ResetColor();
        }
    }
}

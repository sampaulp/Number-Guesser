//******************************************************************************************//                                  
//                                  Some Info                                               //
//Simple Game which lets the player to guess a number from 1 to 10 and get it correct.      //
//It is a tutorial by Brad Traversy, I picked it up to learn the syntax and structure of C# //
//******************************************************************************************//

//equivalent to import in Python
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
            //Print the information about the app
            GetAppInfo();

            //Get user name and greet
            GreetUser();

            while(true)
            {
                //Create a new random object
                Random random = new Random();

                // Correct number
                int correctNumber = random.Next(1, 10);

                //initial guess
                int guess = 0;

                //Ask the user to guess the number
                Console.WriteLine("Please guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //Get user input
                    string initialInput = Console.ReadLine();

                    //Make sure it is a number
                    if (!int.TryParse(initialInput, out guess))
                    {
                        //Error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number!!");

                        //Keep going
                        continue;
                    }
                    guess = Int32.Parse(initialInput);

                    if (guess != correctNumber)
                    {
                        //Print that the guess is wrong
                        PrintColorMessage(ConsoleColor.Red, "Wrong, please guess another number");
                        
                        //Make beep sound 
                        Console.Beep();
                    }
                }

                //Print that the guess is right
                PrintColorMessage(ConsoleColor.Green, "You are CORRECT!!");

                //Play again
                Console.WriteLine("Do you want to play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }

        //Function to print app information
        static void GetAppInfo ()
        {
            //set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sampaul";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Display App info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.Beep();

            //Reset color
            Console.ResetColor();
        }

        //Function to get username and greet 
        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            //Get the user input
            string userName = Console.ReadLine();

            //Write the message
            Console.WriteLine("Hey {0}, Lets play a game!", userName);
        }

        //Function to change the color for messages
        static void PrintColorMessage(ConsoleColor color , string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {

            GetInfo();

            GreetUser();

            while (true)
            {

                Console.WriteLine("Guess a number betwen 1 and 10");

                //int rightNumber = 7;
                Random rand = new Random();

                int rightNumber = rand.Next(1, 10);

                int playerNum = 0;

                while (playerNum != rightNumber)
                {

                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out playerNum))
                    {
                        PrintColor(ConsoleColor.Red, "Must be Number..");

                        continue;
                    }

                    playerNum = Int32.Parse(input);

                    if (playerNum != rightNumber)
                    {
                        PrintColor(ConsoleColor.Red, "Try again....");
                    }
                }

                PrintColor(ConsoleColor.DarkYellow, "You Are Correct..");

                Console.WriteLine("Play Again ?? [Y or N ] ");

                string answ = Console.ReadLine().ToUpper();

                if(answ == "Y"){
                    continue;
                }else if(answ == "N"){
                    return;
                }

            }
        }

        static void GetInfo(){

            string name = "Number Guesser";
            string version = "1.2.3";
            string author = "Eltrolo";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0} : Version {1} by {2}", name, version, author);

            Console.ResetColor();

        }

        static void GreetUser(){
            Console.WriteLine("Say u Name");

            string player = Console.ReadLine();

            Console.WriteLine("Hello, MF {0} , Lets play a Game...", player);
        }

        static void PrintColor(ConsoleColor color, string message){
            
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}

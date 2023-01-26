using System;
using System.Drawing;

namespace RockPaperScissorsByBoyanHad
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scisssors";


            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Choose [r]ock, [p]aper or [s]cisssors: ");
            string inputPlayerMove = Console.ReadLine();

            if (inputPlayerMove == "r" || inputPlayerMove == "rock")
            {
                inputPlayerMove = rock;
            }
            else if (inputPlayerMove == "p" || inputPlayerMove == "paper")
            {
                inputPlayerMove = paper;
            }
            else if (inputPlayerMove == "s" || inputPlayerMove == "scissors")
            {
                inputPlayerMove = scissors;
            }
            else
            {
                Console.WriteLine("Invalid Input. Try again...");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Blue;

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";
            int countHumanWins = 0;
            int countCompWins = 0;
            int countDraws = 0;

            switch (computerRandomNumber)
            {
                case 1: computerMove = rock; break;
                case 2: computerMove = paper; break;
                case 3: computerMove = scissors; break;
                default: break;
            }
            Console.WriteLine($"The computer choose {computerMove}");

            if ((inputPlayerMove == rock && computerMove == scissors) || 
                (inputPlayerMove == paper && computerMove == rock) || 
                (inputPlayerMove == scissors && computerMove == paper))
            {
                Console.WriteLine("You win.");
                countHumanWins++;
            }
            else if ((inputPlayerMove == rock && computerMove == paper) ||
                (inputPlayerMove == paper && computerMove == scissors) || 
                (inputPlayerMove == scissors && computerMove == rock))
            {
                Console.WriteLine("You lose.");
                countCompWins++;
            }
            else
            {
                Console.WriteLine("The game was a draw.");
                countDraws++;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type [yes] to Play Again or [no] to quit:");
            string type = Console.ReadLine();

            if (type == "yes")
            {
              ;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine($"Computer Win Games:{countCompWins}---Human Win Games:{countHumanWins}---Draw Games:{countDraws}");

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
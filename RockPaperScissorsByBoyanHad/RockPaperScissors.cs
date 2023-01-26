using System;

namespace RockPaperScissorsByBoyanHad
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "Scisssors";

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

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);
            string computerMove = "";

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
            }
            else if ((inputPlayerMove == rock && computerMove == paper) ||
                (inputPlayerMove == paper && computerMove == scissors) || 
                (inputPlayerMove == scissors && computerMove == rock))
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("The game was a draw.");
            }
        }
    }
}
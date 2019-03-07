using System;

namespace RPS_Project_AM

{
    public class RPSGame
    {
        private readonly string[] MoveNames = {"Rock", "Paper", "Scissors", "Spock", "Zombie", "Lizard", "Gun"};
        private readonly Random r;
        private string computersChoice;

        public RPSGame()
        {
            r = new Random();
        }

        public string ComputersChoice
        {
            get
            {
                computersChoice = MoveNames[r.Next(7)];
                return computersChoice;
            }
        }

        public string ComparePlays(string playersChoice)
        {
            switch (playersChoice)
            {
                case "Rock":
                    return Result("Rock", "Scissors", "Zombie", "Lizard", "Paper", "Spock", "Gun");
                case "Paper":
                    return Result("Paper", "Rock", "Gun", "Spock", "Scissors", "Zombie", "Lizard");
                case "Scissors":
                    return Result("Scissors", "Paper", "Zombie", "Lizard", "Rock", "Spock", "Gun");
                case "Spock":
                    return Result("Spock", "Scissors", "Gun", "Rock", "Zombie", "Lizard", "Paper");
                case "Zombie":
                    return Result("Zombie", "Paper", "Lizard", "Spock", "Rock", "Gun", "Scissors");
                case "Lizard":
                    return Result("Lizard", "Spock", "Paper", "Gun", "Zombie", "Rock", "Scissors");
                case "Gun":
                    return Result("Gun", "Rock", "Scissors", "Zombie", "Lizard", "Spock", "Paper");
                default:
                    return null;
            }
        }

        private string Result(string Player, string Pwin1, string Pwin2, string Pwin3, string Plose1, string Plose2,
            string Plose3)
        {
            var Pwins = Pwin1 + Pwin2 + Pwin3;
            var Plosses = Plose1 + Plose2 + Plose3;
           
            
            if (computersChoice == Pwin1)
            {
                return "win";
            }
            else if (computersChoice == Pwin2)
            {
                return "win";
            }
            else if (computersChoice == Pwin3)
            {
                return "win";
            }
            else if (computersChoice == Plose1)
            {
                return "lose";
            }
            else if (computersChoice == Plose2)
            {
                return "lose";
            }
            else if (computersChoice == Plose3)
            {
                return "lose";
            }
            else
            {
                return "drawn";
            }
        }
    }
}
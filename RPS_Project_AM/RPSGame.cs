using System;

namespace RPS_Project_AM

{

    public class RPSGame
    {
        private readonly string[] Objects = {"Rock", "Paper", "Scissors", "Spock", "Zombie", "Lizard", "Gun"}; // Die Namen von den Objekten
        private readonly Random r;
        private string cChoice;

        public RPSGame()
        {
            r = new Random();
        }

        public string CChoice
        {
            get
            {
                cChoice = Objects[r.Next(7)];
                return cChoice;
            }
        }

        public string Compare(string playersChoice)
        {
            switch (playersChoice) //Auswahl vom Spieler
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

        private string Result(string Player, string Playerwin1, string Playerwin2, string Playerwin3, string Playerlose1, string Playerlose2,
            string Playerlose3)
        {

            if (cChoice == Playerwin1) //
            {
                return "win";
            }

            if (cChoice == Playerwin2)
            {
                return "win";
            }
            if (cChoice == Playerwin3)
            {
                return "win";
            }
            if (cChoice == Playerlose1)
            {
                return "lose";
            }
            if (cChoice == Playerlose2)
            {
                return "lose";
            }
            if (cChoice == Playerlose3)
            {
                return "lose";
            }
            return "drawn";
        }
    }
}
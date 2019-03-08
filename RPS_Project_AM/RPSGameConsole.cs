using System;
namespace RPS_Project_AM
{
    public class RPSGameConsole
    {
        public void Go()
        {
            var game = new RPSGame();
            int wins, draws, losses, round;
            wins = 0;
            draws = 0;
            losses = 0;
            round = 0;
            string computersChoice;
            string result;

            for (;;)
            {
                computersChoice = game.CChoice;
                string pChoice = null;
                do
                {
                    Console.Write(
                        "Enter r (Rock), p (Paper), s (Scissors), sp (Spock), z (Zombie), l (Lizard), g (Gun)" +
                        " or Q (Quit) :");
                    var b = Console.ReadLine();

                    switch (b)
                    {
                        case "r":
                            pChoice = "Rock";
                            break;
                        case "p":
                            pChoice = "Paper";
                            break;
                        case "s":
                            pChoice = "Scissors";
                            break;
                        case "sp":
                            pChoice = "Spock";
                            break;
                        case "z":
                            pChoice = "Zombie";
                            break;
                        case "l":
                            pChoice = "Lizard";
                            break;
                        case "g":
                            pChoice = "Gun";
                            break;
                        case "q":
                            pChoice = "Quit";
                            Console.WriteLine("\n");
                            Console.WriteLine("You quit the game: ");
                            Console.WriteLine("Result: {0} wins, {1} draws, {2} losses", wins, draws, losses);
                            break;
                    }
                } while (pChoice == null);

                if (pChoice == "Quit") break;
                result = game.Compare(pChoice);
                round++;
                Console.WriteLine("\nRound " + round);
                Console.WriteLine("The player chose = " + pChoice);
                Console.WriteLine("The computer chose = " + computersChoice);
                
                switch (result)
                {
                    case "drawn":
                        Console.WriteLine("\n");
                        Console.WriteLine("*** This round is drawn. ***");
                        Console.WriteLine("\n");
                        draws++;
                        break;
                    case "lose":
                        Console.WriteLine("\n");
                        Console.WriteLine("*** You lost. " + computersChoice + " wins against " + pChoice + " ***");
                        Console.WriteLine("\n");
                        losses++;
                        break;
                    case "win":
                        Console.WriteLine("\n");
                        Console.WriteLine("*** You won. " + pChoice + " wins against " + computersChoice + " ***");
                        Console.WriteLine("\n");
                        wins++;
                        break;
                }
                Console.WriteLine("Status: {0} wins, {1} draws, {2} losses", wins, draws, losses);
            }
        }
    }
}
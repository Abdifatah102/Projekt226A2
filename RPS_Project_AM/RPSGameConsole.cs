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
                computersChoice = game.ComputersChoice;
                string playersChoice = null;
                do
                {
                    Console.Write(
                        "Enter r (Rock), p (Paper), s (Scissors), S (Spock), z (Zombie), l (Lizard), g (Gun)" +
                        " or Q (Quit) :");
                    var b = Console.ReadLine();

                    switch (b)
                    {
                        case "r":
                            playersChoice = "Rock";
                            break;
                        case "p":
                            playersChoice = "Paper";
                            break;
                        case "s":
                            playersChoice = "Scissors";
                            break;
                        case "sp":
                            playersChoice = "Spock";
                            break;
                        case "z":
                            playersChoice = "Zombie";
                            break;
                        case "l":
                            playersChoice = "Lizard";
                            break;
                        case "g":
                            playersChoice = "Gun";
                            break;
                        case "q":
                            playersChoice = "Quit";
                            break;
                    }
                } while (playersChoice == null);

                if (playersChoice == "Quit") break;
                result = game.ComparePlays(playersChoice);
                round++;
                Console.WriteLine("Round " + round);
                Console.WriteLine("The computer's choice = " + computersChoice);
                Console.WriteLine("The player's choice = " + playersChoice);

                switch (result)
                {
                    case "draw":
                        Console.WriteLine("\n");
                        Console.WriteLine("***This round is drawn.***");
                        Console.WriteLine("\n");
                        draws++;
                        break;
                    case "lose":
                        Console.WriteLine("\n");
                        Console.WriteLine("***Sorry, you lose this round.***");
                        Console.WriteLine("\n");
                        losses++;
                        break;
                    case "win":
                        Console.WriteLine("\n");
                        Console.WriteLine("***Well done, you win this round.***");
                        Console.WriteLine("\n");
                        wins++;
                        break;
                }

                Console.WriteLine("Status: {0} wins, {1} draws," + "{2} losses", wins, draws, losses);
            }
        }
    }
}
using System;

class RockPaperScissors
{
    static void Main()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors Game!");
        string[] choices = { "Rock", "Paper", "Scissors" };

        while (true)
        {
            Console.WriteLine("\nEnter your move (Rock, Paper, Scissors) or type 'exit' to quit:");
            string playerChoice = Console.ReadLine();

            // Exit condition
            if (playerChoice.ToLower() == "exit")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }

            // Validate player input
            if (Array.Exists(choices, choice => choice.Equals(playerChoice, StringComparison.OrdinalIgnoreCase)))
            {
                Random rand = new Random();
                int computerChoiceIndex = rand.Next(0, choices.Length);
                string computerChoice = choices[computerChoiceIndex];

                Console.WriteLine($"Computer chose: {computerChoice}");

                // Determine the winner
                string result = GetGameResult(playerChoice, computerChoice);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid move! Please choose Rock, Paper, or Scissors.");
            }
        }
    }

    // Method to determine the game result
    static string GetGameResult(string playerChoice, string computerChoice)
    {
        if (playerChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
        {
            return "It's a tie!";
        }
        else if (
            (playerChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase)) ||
            (playerChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase)) ||
            (playerChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase))
        )
        {
            return "You win!";
        }
        else
        {
            return "You lose!";
        }
    }
}

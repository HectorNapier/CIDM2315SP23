namespace Bunus;
class RockPaperScissors
{
    static void Main(string[] args)
    {
        Console.WriteLine("****Rock Paper Scissors, Start!!****");

        HumanPlayer human = new HumanPlayer(5);
        ComputerPlayer computer = new ComputerPlayer();

        while (true)
        {
            Console.WriteLine($"You have {human.GetPoints()} points");

            string humanChoice = human.HumanDecision();
            string computerChoice = computer.ComputerDecision();

            Console.WriteLine($"\n--> Your Decision: {humanChoice}\n\n--> Computer Decision: {computerChoice}\n");

            if (humanChoice == computerChoice)
            {
                Console.WriteLine("It's a Tie!\n");
                continue;
            }
            else if (humanChoice == "rock" && computerChoice == "scissors" ||
                     humanChoice == "paper" && computerChoice == "rock" ||
                     humanChoice == "scissors" && computerChoice == "paper")
            {
                Console.WriteLine("You win!\n");
                human.WinRound();
            }
            else
            {
                Console.WriteLine("You Lose!\n");
                human.LoseRound();
            }

            if (human.GetPoints() <= 0)
            {
                Console.WriteLine("Sorry, you don't have enough points, thanks for playing.");
                break;
            }

            Console.WriteLine("-> Play again? Input y to continue, or n to exit");
            string choice = Console.ReadLine().ToLower();

            if (choice != "y")
            {
                Console.WriteLine("Thank you for playing!");
                break;
            }

            Console.WriteLine("****Rock Paper Scissors, Start!!****\n");
        }
    }
}

class HumanPlayer
{
    private int points;

    public HumanPlayer(int initial)
    {
        points = initial;
    }

    public int GetPoints()
    {
        return points;
    }

    public void WinRound()
    {
        points += 5;
    }

    public void LoseRound()
    {
        points -= 5;
    }

    public string HumanDecision()
    {
        Console.WriteLine("Please input your choice: rock, paper or scissors.");
        return Console.ReadLine().ToLower();
    }
}

class ComputerPlayer
{
    public string ComputerDecision()
    {
        Random rnd = new Random();
        int rnd_num = rnd.Next(0, 3);

        if (rnd_num == 0)
        {
            return "rock";
        }
        else if (rnd_num == 1)
        {
            return "paper";
        }
        else
        {
            return "scissors";
        }
    }
}

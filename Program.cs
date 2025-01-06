public class Program
{
    private static int round, yourScore, theirScore, yourDie, theirDie;
    private static Random minecraft = new Random();

    public static void Main()
    {
        yourScore = 0;
        theirScore = 0;

        Console.WriteLine("Dice Game\n");
        Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
        Console.WriteLine("where you will each roll a 6-sided dice, and the player");
        Console.WriteLine("with the highest dice value will win the round. The player");
        Console.WriteLine("who wins the most rounds wins the game. Good luck!\n");
        Console.Write("Press any key to start...");
        Console.ReadKey();

        for (round = 1; round <= 10; round++)
        {
            Console.WriteLine($"\n\nRound {round}");

            theirDie = minecraft.Next(1, 7);
            Console.Write($"Rival rolled a {theirDie}\nPress any key to roll the dice...");
            Console.ReadKey();

            yourDie = minecraft.Next(1, 7);
            Console.WriteLine($"\nYou rolled a {yourDie}");

            if (yourDie > theirDie)
            {
                yourScore++;
                Console.WriteLine("You won this round.");
            }
            else if (yourDie < theirDie)
            {
                theirScore++;
                Console.WriteLine("The Rival won this round.");
            }
            else
                Console.WriteLine("This round is a draw!");

            Console.Write($"The score is now - You : {yourScore}. Rival : {theirScore}.\nPress any key to continue...");
            Console.ReadKey();
        }

        Console.WriteLine($"\n\nGame over.\nThe score is now - You : {yourScore}. Rival : {theirScore}.");

        if (yourScore > theirScore)
            Console.WriteLine("You won!");
        else if (yourScore < theirScore)
            Console.WriteLine("You lost!");
        else
            Console.WriteLine("This game is a draw.");

        Console.Write("Press any key to exit...");
        Console.ReadKey();

        Console.Clear();
        Console.Write("Dice Game was closed.");
    }
}
namespace NHT;

public class Program
{
    public static void Main()
    {
        Board board = new Board();
        int[] turns = new int[4];
        string[] players = {"Yellow", "Green", "Red", "Blue"};
        board.CreateBoard();
        board.PrintBoard();

        while (true)
        {
            Random random = new Random();
            int dice = 0;
            int playerTurn = 0;
            for (int i = 0; i < turns.Length; i++)
            {
                if (turns[i] == 0)
                {
                    playerTurn = i;
                    turns[i] = 1;
                    return;
                }
            }
            Console.WriteLine($"Player {players[playerTurn]}, your turn to roll the dice!");
            Console.WriteLine("Press Enter to roll the dice!");
            Console.ReadLine();
            dice = random.Next(0,6);
            Console.WriteLine($"Your number is : {dice}");


        }
    }
}


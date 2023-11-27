namespace TicTacToe
{
    class Program
    {
        static char[] pos = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void DrawBoard()
        {
            Console.WriteLine($"   {pos[0]}  |  {pos[1]}  |  {pos[2]}   ");
            Console.WriteLine($"-------------------");
            Console.WriteLine($"   {pos[3]}  |  {pos[4]}  |  {pos[5]}   ");
            Console.WriteLine("-------------------");
            Console.WriteLine($"   {pos[6]}  |  {pos[7]}  |  {pos[8]}   ");
        }
        static void Main(string[] args)
        {
            bool isPlayerX = true;
            string playerX, playerO;
            int moves = 0;
            int choice;

            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.Write("What is the name of player 'X': ");
            playerX = Console.ReadLine();
            Console.Write("What is the name of player 'O': ");
            playerO = Console.ReadLine();

            while (true)
            {
                Console.Clear();
                DrawBoard();

                while (true)
                {
                    Console.WriteLine((isPlayerX ? playerX : playerO) + " is moving");
                    Console.Write("Choose position on the board ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (choice >= 1 && choice <= 9 && pos[choice - 1] != 'X' && pos[choice - 1] != 'O')
                        break;
                    else
                        Console.WriteLine("Wrong choice, try again.");
                }
                if (isPlayerX)
                {
                    pos[choice - 1] = 'X';
                }
                else
                {
                    pos[choice - 1] = 'O';
                }

                moves++;

                if ((pos[0] == pos[1] && pos[1] == pos[2]) ||
                    (pos[3] == pos[4] && pos[4] == pos[5]) ||
                    (pos[6] == pos[7] && pos[7] == pos[8]) ||
                    (pos[0] == pos[3] && pos[3] == pos[6]) ||
                    (pos[1] == pos[4] && pos[4] == pos[7]) ||
                    (pos[2] == pos[5] && pos[5] == pos[8]) ||
                    (pos[0] == pos[4] && pos[4] == pos[8]) ||
                    (pos[2] == pos[4] && pos[4] == pos[6]))
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("Congratulations! The winner is " + (isPlayerX ? playerX : playerO));
                    break;
                }
                else if (moves == 9)
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("It's a draw the board is full");
                    break;
                }
                else
                {
                    isPlayerX = !isPlayerX;
                }
            }
        }
    }
}
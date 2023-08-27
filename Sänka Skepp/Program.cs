namespace Sänka_Skepp
{
    internal class Program
    {
        class Ship
        {
            int Size;

            public Ship(int size)
            {
                Size = size;
            }

        }
        
        
        class GameBoard
        {
            int BoardLenght;
            int BoardHeight;
            string[,] PlayerBoard;
            string[,] CompBoard;
            string[,] PrintBoard;

            public GameBoard(int boardLenght, int boardHeight)
            {
                //Read Only? Fråga Kalle
                BoardLenght = boardLenght;
                BoardHeight = boardHeight;

                PlayerBoard = new string[BoardLenght, BoardHeight];
                CompBoard = new string[BoardLenght, BoardHeight];

                for (int i = 0; i < BoardHeight; i++)
                {
                    for (int j = 0; j < BoardLenght; j++)
                    {
                        PlayerBoard[i,j] = "0";
                        CompBoard[i, j] = "0";
                    }
                }

                Ship[] playerShips = new Ship[3];
                Ship[] compShips = new Ship[3];
                
                for (int i = 0; i < 3; i++)
                {
                    playerShips[i] = new Ship(1);
                    compShips[i] = new Ship(1);
                }
                
                
            }

            public void PlaceShips()
            {
                Random random = new Random();

               

                for (int i = 0; i < 3; i++)
                {
                    int xCord = random.Next(0, 5);
                    int yCord = random.Next(0, 5);

                    if (CompBoard[xCord, yCord] != "1")
                    {
                        CompBoard[xCord, yCord] = "1";
                    }
                    else
                    {
                        xCord = random.Next(0, 6);
                        yCord = random.Next(0, 6);

                        CompBoard[xCord, yCord] = "1";
                    }
                }
                Console.WriteLine("The computers four ships has been placed.");
                Console.WriteLine("Where would you like to place yours?");

                for (int i = 1; i < 4; i++)
                {
                    Console.WriteLine($"Ship{i}: ");
                    Console.Write("X coordinate: ");
                    int xCord = int.Parse(Console.ReadLine());
                    Console.Write("Y coordinate: ");
                    int yCord = int.Parse(Console.ReadLine());

                    PlayerBoard[xCord, yCord] = "1";
                }
                Console.WriteLine("Your ships have been placed, prepare for battle!");

            }

            public void PrintField()
            {
                
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("0");
                    }

                    Console.WriteLine();
                }
            }

            public void Shoot()
            {
                Console.WriteLine("Where would you like to shoot?");
                Console.Write("X coordinate: ");
                int xCord = int.Parse(Console.ReadLine());
                Console.Write("Y coordinate: ");
                int yCord = int.Parse(Console.ReadLine());

            }

        }


        static void Main(string[] args)
        {
           
            GameBoard gameBoard = new GameBoard(5, 5);
            gameBoard.PlaceShips();
            gameBoard.PrintField();

        }
    }
}
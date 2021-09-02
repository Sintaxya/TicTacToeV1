using System;

namespace Array_Challange_TicTacToe
{
    class Program
    {
        public static string[,,] PlayField = new string[3, 3, 1] // i,j,k
        {
                { {"1"},
                  {"2"},
                  {"3"} },

                { {"4"},
                  {"5"},
                  {"6"} },

                { {"7"},
                  {"8"},
                  {"9"} }
        };
        public static void ChangeField()
        {

            {
                for (int i = 0; i < PlayField.GetLength(0); i++)
                {
                    for (int j = 0; j < PlayField.GetLength(1); j++)
                    {
                        for (int k = 0; k < PlayField.GetLength(2); k++)
                        {
                            if (j % 3 == 0)
                            {
                                Console.Write("\n" + PlayField[i, j, k] + " ");
                            }
                            else
                            {
                                Console.Write(" " + PlayField[i, j, k] + " ");
                            }

                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string P2 = " ";
            string P1 = " ";
            bool playerWin = false;
            Console.WriteLine("Welcome to GREGORY's Tic-Tac-Toe!");
            {
                for (int i = 0; i < PlayField.GetLength(0); i++)
                {
                    for (int j = 0; j < PlayField.GetLength(1); j++)
                    {
                        for (int k = 0; k < PlayField.GetLength(2); k++)
                        {
                            if (j % 3 == 0)
                            {
                                Console.Write("\n" + PlayField[i, j, k] + " ");
                            }
                            else
                            {
                                Console.Write(" " + PlayField[i, j, k] + " ");
                            }

                        }
                    }
                }
            }
            Console.WriteLine("\n");
            while (playerWin == false)
            {
                P1 = Player1();
                Console.Clear();
                if (P1.Equals(P2))
                {
                    Console.WriteLine("\n Another player already chose that zone! Please choose another one!");
                    ChangeField();
                    P1 = Player1();
                }
                switch (P1)
                {
                    case "1":
                        PlayField[0, 0, 0] = "X";
                        ChangeField();
                        break;
                    case "2":
                        PlayField[0, 1, 0] = "X";
                        ChangeField();
                        break;
                    case "3":
                        PlayField[0, 2, 0] = "X";
                        ChangeField();
                        break;
                    case "4":
                        PlayField[1, 0, 0] = "X";
                        ChangeField();
                        break;
                    case "5":
                        PlayField[1, 1, 0] = "X";
                        ChangeField();
                        break;
                    case "6":
                        PlayField[1, 2, 0] = "X";
                        ChangeField();
                        break;
                    case "7":
                        PlayField[2, 0, 0] = "X";
                        ChangeField();
                        break;
                    case "8":
                        PlayField[2, 1, 0] = "X";
                        ChangeField();
                        break;
                    case "9":
                        PlayField[2, 2, 0] = "X";
                        ChangeField();
                        break;
                    case "X":
                        break;
                    case "O":
                        break;
                    default:
                        Console.WriteLine("NOT VALID VALUE!");
                        ChangeField();
                        P1 = Player1();
                        break;
                }
                if (PlayField[0, 0, 0].Equals("X") && PlayField[0, 1, 0].Equals("X") && PlayField[0, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 0, 0].Equals("X") && PlayField[1, 0, 0].Equals("X") && PlayField[2, 0, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 0, 0].Equals("X") && PlayField[1, 1, 0].Equals("X") && PlayField[2, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 2, 0].Equals("X") && PlayField[1, 1, 0].Equals("X") && PlayField[2, 0, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 1, 0].Equals("X") && PlayField[1, 1, 0].Equals("X") && PlayField[2, 1, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 2, 0].Equals("X") && PlayField[1, 2, 0].Equals("X") && PlayField[2, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[1, 0, 0].Equals("X") && PlayField[1, 1, 0].Equals("X") && PlayField[1, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[2, 0, 0].Equals("X") && PlayField[2, 1, 0].Equals("X") && PlayField[2, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                /*/**/

                if (PlayField[0, 0, 0].Equals("O") && PlayField[0, 1, 0].Equals("O") && PlayField[0, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 0, 0].Equals("O") && PlayField[1, 0, 0].Equals("O") && PlayField[2, 0, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 0, 0].Equals("O") && PlayField[1, 1, 0].Equals("O") && PlayField[2, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 2, 0].Equals("O") && PlayField[1, 1, 0].Equals("O") && PlayField[2, 0, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 1, 0].Equals("O") && PlayField[1, 1, 0].Equals("O") && PlayField[2, 1, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 2, 0].Equals("O") && PlayField[1, 2, 0].Equals("O") && PlayField[2, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (O) VICTORY!");
                    break;
                }
                if (PlayField[1, 0, 0].Equals("O") && PlayField[1, 1, 0].Equals("O") && PlayField[1, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (O) VICTORY!");
                    break;
                }
                if (PlayField[2, 0, 0].Equals("O") && PlayField[2, 1, 0].Equals("O") && PlayField[2, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (O) VICTORY!");
                    break;
                }
                P2 = Player2();
                Console.Clear();
                if (P2.Equals(P1))
                {
                    Console.WriteLine("\n Another player already chose that zone! Please choose another one!");
                    ChangeField();
                    P2 = Player2();
                }
                switch (P2)
                {
                    case "1":
                        PlayField[0, 0, 0] = "O";
                        ChangeField();
                        break;
                    case "2":
                        PlayField[0, 1, 0] = "O";
                        ChangeField();
                        break;
                    case "3":
                        PlayField[0, 2, 0] = "O";
                        ChangeField();
                        break;
                    case "4":
                        PlayField[1, 0, 0] = "O";
                        ChangeField();
                        break;
                    case "5":
                        PlayField[1, 1, 0] = "O";
                        ChangeField();
                        break;
                    case "6":
                        PlayField[1, 2, 0] = "O";
                        ChangeField();
                        break;
                    case "7":
                        PlayField[2, 0, 0] = "O";
                        ChangeField();
                        break;
                    case "8":
                        PlayField[2, 1, 0] = "O";
                        ChangeField();
                        break;
                    case "9":
                        PlayField[2, 2, 0] = "O";
                        ChangeField();
                        break;
                    case "X":
                        break;
                    case "O":
                        break;
                    default:
                        Console.WriteLine("NOT VALID VALUE!");
                        ChangeField();
                        P2 = Player2();
                        break;

                }
                if (PlayField[0, 0, 0].Equals("X") && PlayField[0, 1, 0].Equals("X") && PlayField[0, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 0, 0].Equals("X") && PlayField[1, 0, 0].Equals("X") && PlayField[2, 0, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 0, 0].Equals("X") && PlayField[1, 1, 0].Equals("X") && PlayField[2, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 2, 0].Equals("X") && PlayField[1, 1, 0].Equals("X") && PlayField[2, 0, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 1, 0].Equals("X") && PlayField[1, 1, 0].Equals("X") && PlayField[2, 1, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[0, 2, 0].Equals("X") && PlayField[1, 2, 0].Equals("X") && PlayField[2, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[1, 0, 0].Equals("X") && PlayField[1, 1, 0].Equals("X") && PlayField[1, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                if (PlayField[2, 0, 0].Equals("X") && PlayField[2, 1, 0].Equals("X") && PlayField[2, 2, 0].Equals("X"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 1 (X) VICTORY!");
                    break;
                }
                /*/**/

                if (PlayField[0, 0, 0].Equals("O") && PlayField[0, 1, 0].Equals("O") && PlayField[0, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 2 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 0, 0].Equals("O") && PlayField[1, 0, 0].Equals("O") && PlayField[2, 0, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 2 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 0, 0].Equals("O") && PlayField[1, 1, 0].Equals("O") && PlayField[2, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 2 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 2, 0].Equals("O") && PlayField[1, 1, 0].Equals("O") && PlayField[2, 0, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 2 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 1, 0].Equals("O") && PlayField[1, 1, 0].Equals("O") && PlayField[2, 1, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 2 (O) VICTORY!");
                    break;
                }
                if (PlayField[0, 2, 0].Equals("O") && PlayField[1, 2, 0].Equals("O") && PlayField[2, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 2 (O) VICTORY!");
                    break;
                }
                if (PlayField[1, 0, 0].Equals("O") && PlayField[1, 1, 0].Equals("O") && PlayField[1, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 2 (O) VICTORY!");
                    break;
                }
                if (PlayField[2, 0, 0].Equals("O") && PlayField[2, 1, 0].Equals("O") && PlayField[2, 2, 0].Equals("O"))
                {
                    playerWin = true;
                    Console.WriteLine("\n Player 2 (O) VICTORY!");
                    break;
                }
            }
            Console.WriteLine("Press ENTER to play again!");
            string ENTER = Console.ReadLine();
            if (ENTER.Equals(""))
            {
                Console.Clear();
                PlayField[0, 0, 0] = "1";
                PlayField[0, 1, 0] = "2";
                PlayField[0, 2, 0] = "3";
                PlayField[1, 0, 0] = "4";
                PlayField[1, 1, 0] = "5";
                PlayField[1, 2, 0] = "6";
                PlayField[2, 0, 0] = "7";
                PlayField[2, 1, 0] = "8";
                PlayField[2, 2, 0] = "9";
                Main(args);
            }
            else
            {
                Environment.Exit(0);
            }
        }
        public static string Player1()
        {
            Console.WriteLine("\n PLAYER 1 (X)'s turn - please type a field's number: ");
            string player1_choice = Console.ReadLine();
            return player1_choice;
        }
        public static string Player2()
        {
            Console.WriteLine("\n PLAYER 2 (O)'s turn - please type a field's number: ");
            string player2_choice = Console.ReadLine();
            return player2_choice;
        }
    }
}

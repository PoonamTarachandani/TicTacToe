using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tictackoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "1";
            string B = "2";
            string C = "3";
            string D = "4";
            string E = "5";
            string F = "6";
            string G = "7";
            string H = "8";
            string I = "9";
            string J = "|";
            string player1, player2, move;
            string chance = "player1";
            Console.WriteLine("Name of player1");
            player1 = Console.ReadLine();
            Console.WriteLine("Name of player2");
            player2 = Console.ReadLine();
            bool isGameNotOver = true;
            string winner = "";
            List<string> Player1Selection = new List<string>();
            List<string> Player2Selection = new List<string>();

            int step = 0;
            int oldStep = 9;
            while (isGameNotOver && step<9)
            {
                if (step != oldStep)
                {
                    Console.Clear();
                }
                Console.WriteLine(chance);
                if (chance == "player1")
                {
                    if (step != oldStep)
                    {
                        Console.WriteLine(A + J + B + J + C);
                        Console.WriteLine(D + J + E + J + F);
                        Console.WriteLine(G + J + H + J + I);
                    }
                    oldStep = step;
                    Console.WriteLine("make a move by typing any number between 1 to 9");
                    move = Console.ReadLine();
                    if (move == "1")
                    {
                        if (A == "1")
                        {
                            A = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken");
                            Console.WriteLine("try again");
                            continue;

                        }
                    }
                    if (move == "2")
                    {
                        if (B == "2")
                        {
                            B = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }
                    }
                    if (move == "3")
                    {
                        if (C == "3")
                        {
                            C = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }

                    if (move == "4")
                    {
                        if (D == "4")
                        {
                            D = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }
                    if (move == "5")
                    {
                        if (E == "5")
                        {
                            E = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }
                    if (move == "6")
                    {
                        if (F == "6")
                        {
                            F = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }
                    }
                    if (move == "7")
                    {
                        if (G == "7")
                        {
                            G = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }
                    }
                    if (move == "8")
                    {
                        if (H == "8")
                        {
                            H = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }
                    if (move == "9")
                    {
                        if (I == "9")
                        {
                            I = "x";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }
                    }
                    Player1Selection.Add(move);
                    //bool declarewinner = IsWinner(Player1Selection);
                    //Console.WriteLine(declarewinner);
                    if (Player1Selection.Count >= 3 && IsWinner(Player1Selection))
                    {
                        isGameNotOver = false;
                        winner = player1;
                    }
                    else
                    {
                        chance = "player2";
                    }
                }
                else
                {
                    if (step != oldStep)
                    {
                        Console.WriteLine(A + J + B + J + C);
                        Console.WriteLine(D + J + E + J + F);
                        Console.WriteLine(G + J + H + J + I);
                    }
                    oldStep = step;
                    Console.WriteLine("make a move by typing any number between 1 to 9");
                    move = Console.ReadLine();
                    if (move == "1")
                    {
                        if (A == "1")
                        {
                            A = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken");
                            Console.WriteLine("try again");
                            continue;
                        }
                    }
                    if (move == "2")
                    {
                        if (B == "2")
                        {
                            B = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }
                    }
                    if (move == "3")
                    {
                        if (C == "3")
                        {
                            C = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }

                    if (move == "4")
                    {
                        if (D == "4")
                        {
                            D = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }
                    if (move == "5")
                    {
                        if (E == "5")
                        {
                            E = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }
                    if (move == "6")
                    {
                        if (F == "6")
                        {
                            F = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }

                    if (move == "7")
                    {
                        if (G == "7")
                        {
                            G = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }

                    if (move == "8")
                    {
                        if (H == "8")
                        {
                            H = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }
                    if (move == "9")
                    {
                        if (I == "9")
                        {
                            I = "o";
                        }
                        else
                        {
                            Console.WriteLine("this is taken ");
                            Console.WriteLine("try again");
                            continue;
                        }

                    }

                    Player2Selection.Add(move);
                    //bool declarewinner = IsWinner(Player1Selection);
                    //Console.WriteLine(declarewinner);
                    if (Player2Selection.Count >= 3 && IsWinner(Player2Selection))
                    {
                        isGameNotOver = false;
                        winner = player2;
                    }
                    else {
                        chance = "player1";

                    }
                }
                step++;
            }
            if(string.IsNullOrEmpty(winner))
                Console.WriteLine("No winner.");
            else
                Console.WriteLine(winner+" is winner.");
        }
        
        static bool IsWinner(List<string> userSelections)
        {
            bool winner = false;
            string[] winningCombinations = {"1 2 3","4 5 6","7 8 9","1 4 7","2 5 8","3 6 9","1 5 9","3 5 7" };
            foreach(string combo in winningCombinations)
            {
                string[] Combonumbers = combo.Split();
                int i = 0;
                foreach (var nums in Combonumbers)
                {
                    if (!userSelections.Contains(nums))
                        break;
                    i++;
                }            
                if (i==3)
                {
                    winner = true;
                }                
             }
             return winner;
        }
    } 

}

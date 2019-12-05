using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while(scorePlayer < 3 && scoreCPU < 3) 
                {


                    Console.WriteLine("Choose between ROCK PAPER and SCISSORS:   ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    // computer chooses random number between 0 and 4
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);
                    // switch statment for different choices rock, paper, or scissors
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("TIE!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("YOU WIN!!\n\n");
        
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                    {
                                Console.WriteLine("CPU WINS!!\n\n");
        
                                scoreCPU++;
                            }
                            break;

                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("TIE!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                    {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                    {
                                Console.WriteLine("YOU WIN!!\n\n");
        
                                scorePlayer++;
                            }
                            break;

                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("TIE!!\n\n");
                            }
                            else if (inputPlayer == "ROCK");
                            {
                                Console.WriteLine("YOU WIN!!\n\n");
        
                                scorePlayer++;
                            }

                             if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\r\n");

                                scoreCPU++;
                            } 
                   
                            break;
                        default:
                            Console.WriteLine("Invailid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);

            }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("WAY TO GO YOU WIN!!!");

                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!! TRY AGAIN..");

                }
                else
                {

                }

                Console.WriteLine("Do you want to play agian?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();

                }
                else if (loop == "n")
                {
                    playAgain = false;

                }

                else
                {

                }


            }
        }
    }
}

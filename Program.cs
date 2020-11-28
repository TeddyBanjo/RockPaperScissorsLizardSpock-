using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU; //initialises player and computer input variables//
            int randomInt; //initialises random computer choice variable 

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0; // player score to 0// 
                int scoreCPU = 0; //  computer score to 0//
                int paperCount = 0; // paper count to 0 //
                int scissorCount = 0; // scissors count initialised at 0 //
                int rockCount = 0; // rock count initialised at 0 //
                int spockCount = 0; //spock count initialised at 0 //
                int lizardCount = 0; //lizard count initialised at 0 //



                while (scorePlayer < 5 && scoreCPU < 5) //game will run whilst player and computer score is less than 5//
                {


                    Console.Write("Choose between ROCK, PAPER , SCISSORS, LIZARD and SPOCK:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper(); 
                    //prompts user for input and standardises input//
                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 6); //random number between 1 and 5//

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            rockCount++;
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                rockCount++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                paperCount++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                scissorCount++;
                            }
                            else if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                lizardCount++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                spockCount++;
                            }
                             break;
                        case 2:
                            inputCPU = "PAPER";
                            paperCount++;
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                paperCount++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                rockCount++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                scissorCount++;
                            }
                            else if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                lizardCount++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                spockCount++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            scissorCount++;
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                scissorCount++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                rockCount++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                paperCount++;
                            }
                            else if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                lizardCount++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                spockCount++;
                            }
                            break;
                        case 4:
                            inputCPU = "LIZARD";
                            lizardCount++;
                            Console.WriteLine("Computer chose LIZARD");
                            if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                lizardCount++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                rockCount++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                paperCount++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                scissorCount++;
                            }
                            else if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                spockCount++;
                            }
                            break;                            
                        case 5:
                            inputCPU = "SPOCK";
                            spockCount++;
                            Console.WriteLine("Computer chose SPOCK");
                            if (inputPlayer == "SPOCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                                spockCount++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                rockCount++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                paperCount++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                                scissorCount++;
                            }
                            else if (inputPlayer == "LIZARD")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                                lizardCount++;
                            }
                            break;

                            default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU); //keeps track of score within game//

                }
                int totalNum = scorePlayer + scoreCPU; //initialises new variable for total number of moves in game//
                if (scorePlayer == 5)
                {
                    Console.WriteLine("Player WON!\nThis game had a total of " + totalNum + " of turns.");
                    Console.WriteLine("Number of total uses during game by both Player and Computer: Rock:" + rockCount + "  Paper:" + paperCount + "  Scissors:" + scissorCount + "  Lizard:" + lizardCount + "  Spock:" + spockCount); //Game report generated//
                }
                else if (scoreCPU == 5)
                {
                    Console.WriteLine("CPU WON!\nThis game had a total of " + totalNum + " of turns.");
                    Console.WriteLine("Number of total uses during game by both Player and Computer: Rock:" + rockCount + "  Paper:" + paperCount + "  Scissors:" + scissorCount + "  Lizard:" + lizardCount + "  Spock:" + spockCount); //Game report generated//
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;  //game begins from top//
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false; //game ends//
                }
                else
                {

                }

            }
        }
    }
}

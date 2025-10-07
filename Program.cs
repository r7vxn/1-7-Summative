using System.Collections.Generic;

namespace _1_7_Summative
{
    internal class Program
    {
        static int money = 100;

        static int rpsbot;

        static int bet = 0;
        static int BetLoop()
        {
            int Bet = 0;
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "all")
                {
                    Bet = money;
                }
                int.TryParse(input, out Bet);
                if (Bet <= 0 || Bet > money)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try to give a positive input or an input that is not over your current balance.");
                    Console.WriteLine($"How much do you want to bet, you currently own {money.ToString("c")} (Enter numbers, ex. 100)");
                }
                else
                {
                    break;
                }
            }
            
            return Bet;
        }
        static string rps;
        static void RPSloop()
        {
            while (true)
            {
                string rpsinput = Console.ReadLine().ToLower();
                if (rpsinput == "rock" || rpsinput == "r")
                {
                    rps = "r";
                    break;
                }
                else if (rpsinput == "paper" || rpsinput == "p")
                {
                    rps = "p";
                    break;
                }
                else if (rpsinput == "scissor" || rpsinput == "s")
                {
                    rps = "s";
                    break;
                }
                Console.Clear() ;
                Console.WriteLine("Invalid input, just enter rock paper or scissor bruh...it ain't that hard");
            }
        }
        static void rpsoutput()
        {
            if (rpsbot == 0)
            {
                if (rps == "r") 
                {
                    Console.WriteLine("The computer picked rock, you tied");
                }
                else if (rps == "p")
                {
                    Console.WriteLine("The computer picked paper, you tied");
                }
                else if (rps == "s")
                {
                    Console.WriteLine("The computer picked scissors, you tied");
                }
            }
            else if (rpsbot == 1)
            {
                if (rps == "r")
                {
                    Console.WriteLine("The computer picked scissor, you won");
                }
                else if (rps == "p")
                {
                    Console.WriteLine("The computer picked rock, you won");
                }
                else if (rps == "s")
                {
                    Console.WriteLine("The computer picked paper, you won");
                }
                money = money + bet;
            }
            else if (rpsbot == 2)
            {
                if (rps == "r")
                {
                    Console.WriteLine("The computer picked paper, you lost");
                }
                else if (rps == "p")
                {
                    Console.WriteLine("The computer picked scissor, you lost");
                }
                else if (rps == "s")
                {
                    Console.WriteLine("The computer picked rock, you lost");
                }
                money = money - bet;
            }
        }
        static void moneygain()
        {
            int gain;
            gain = money - 100;
            if (gain < 0)
            {
                Console.WriteLine("Too Bad Too Sad, you lost " + Math.Abs(gain).ToString("C"));
            }
            else if (gain > 0)
            {
                Console.WriteLine("Nice job, you won " + gain.ToString("c"));
            }
            else if (gain == 0)
            {
                Console.WriteLine("Atleast you didn't lose money...");
            }
        }
        static void Main(string[] args)
        {
            Random generator;
            generator = new Random();

            
            bool done = false;

            string project = "";

            bool menu = false;

            while (!done)
            {
                if (menu == false)
                {
                    Console.WriteLine(@"
Welcome to my Rock Paper Scissor game, this game is literally Rock Paper Scissor, just with a little gambling element in it.
RULE | NO CENTS ALLOWED
1. Rock Paper Scissor
2. Quit
3. Rules
");
                    menu = true;
                }
                else
                {
                    Console.WriteLine("1. Rock Paper Scissor\r\n2. Quit\r\n3. Rules");
                }
                    project = Console.ReadLine();

                if (project == "1" && money != 0)
                {
                    Console.WriteLine("Enter the amount of money you want to bet, you currently have " + money.ToString("c"));
                    bet = BetLoop();
                    Console.WriteLine("Enter your input, Rock(r), Paper(p), Scissor(s)");
                    RPSloop();
                    rpsbot = generator.Next(3);
                    rpsoutput();
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (project == "2")
                {
                    moneygain();
                    done = true;
                }
                else if (project == "3") 
                {
                    Console.Clear ();
                    Console.WriteLine("THE ONLY RULE IS ONLY INPUT INTEGERSSSS, because my system is not too intelligented.\n By the way, the game work by just you inputting your bet and your choice and then I will tell you how much I scam you for.");
                }
                else if (money == 0)
                {
                    Console.WriteLine("Your broke loser, come back another time.");
                    done = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, enter \"1\" or \"2\", it's not that hard.");
                }
            }
        }
    }
}

namespace _1_7_Summative
{
    internal class Program
    {
        static int money = 100;
        static int BetLoop()
        {
            int Bet = 0;
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                if (input == "all")
                {
                    Bet = money;
                    break;
                }
                if (int.TryParse(input, out Bet))
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Invalid input, try again (I don't take cents)");
                Console.WriteLine($"How much do you want to bet, you currently own {money.ToString("c")} (Enter numbers, ex. 100)");
            }
            if (Bet <= 0 || Bet > money)
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try to give a positive input or an input that is not over your current balance.");
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
        static void Main(string[] args)
        {
            int bet = 0;
            bool done = false;

            string project = "";

            while (!done)
            {
                Console.WriteLine(@"
Welcome to my Rock Paper Scissor game, this game is literally Rock Paper Scissor, just with a little gambling element in it.
RULE | NO CENTS ALLOWED
1. Rock Paper Scissor
2. Quit
");
                project = Console.ReadLine();

                if (project == "1" && money != 0)
                {
                    Console.WriteLine("Enter the amount of money you want to bet, you currently have " + money);
                    bet = BetLoop();
                    Console.WriteLine("Enter your input, Rock(r), Paper(p), Scissor(s)");
                    RPSloop();

                }
                else if (project == "2")
                {
                    Console.WriteLine("Thank you for playing, never see you again.");
                    done = true;
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

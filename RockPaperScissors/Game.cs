/*******************************
 * 
 *  Clarke Benedict T. Plumo
 *  BSCS 3-1N
 *  
 *******************************/


using System;

namespace RockPaperScissors
{
    public static class Game
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (exit == false)
            {
                DrawTitle();
                DrawMainMenu();
                switch (Mode())
                {
                    case "play": Play(); break;
                    case "rules": Rules(); break;
                    case "exit": Exit(); exit = true; break;
                }
            }
        }
        public static void DrawTitle()
        {
            Console.Clear();
            Console.WriteLine("########################");
            Console.WriteLine("#                      #");
            Console.WriteLine("# Rock Paper Scissors! #");
            Console.WriteLine("#                      #");
            Console.WriteLine("########################");
        }
        static void DrawMainMenu()
        {
            Console.Write("\n   ###########");
            Console.Write("\n   #         #");
            Console.Write("\n   #  Menu   #");
            Console.Write("\n   #         #");
            Console.Write("\n########################");
            Console.Write("\n#                      #");
            Console.Write("\n#  [1] Play!           #");
            Console.Write("\n#  [2] Rules           #");
            Console.Write("\n#  [3] Exit            #");
            Console.Write("\n#                      #");
            Console.Write("\n########################");
            Console.WriteLine();
            Console.Write("\n >> ");
        }
        static string Mode()
        {
            switch (Console.ReadLine())
            {
                case "1": return "play";
                case "2": return "rules";
                case "3": return "exit";
                default: Console.WriteLine("    Invalid Answer!\n"); 
                            Console.ReadLine(); return "?";
            }
        }
        static void Play()
        {
            Match match = new Match();
            for(int round = 1; round <= 5; round++)
            {
                match.Battle();
            }
            match.DrawStats();
            if (TryAgain(match)) Play();
        }
        static void Rules()
        {
            DrawTitle();
            Console.WriteLine();
            Console.WriteLine("   ###########");
            Console.WriteLine("   #         #");
            Console.WriteLine("   #  Rules  #");
            Console.WriteLine("   #         #");
            Console.WriteLine("########################################################");
            Console.WriteLine("#                                                      #");
            Console.WriteLine("# For each round, both players will have to set their  #");
            Console.WriteLine("# moves. A move can be either ROCK, PAPER or SCISSORS. #");
            Console.WriteLine("# Once each has chosen, you will then watch the battle #");
            Console.WriteLine("# for that round. There are 5 rounds.                  #");
            Console.WriteLine("#                                                      #");
            Console.WriteLine("#    ROCK     beats SCISSORS.                          #");
            Console.WriteLine("#    PAPER    beats ROCK.                              #");
            Console.WriteLine("#    SCISSORS beat  PAPER.                             #");
            Console.WriteLine("#                                                      #");
            Console.WriteLine("# Have Fun!                                            #");
            Console.WriteLine("#                                                      #");
            Console.WriteLine("########################################################");
            Console.ReadLine();
        }

        static void Exit()
        {
            DrawTitle();
            Console.WriteLine();
            Console.WriteLine("   ###########");
            Console.WriteLine("   #         #");
            Console.WriteLine("   #  Exit   #");
            Console.WriteLine("   #         #");
            Console.WriteLine("########################");
            Console.WriteLine("#                      #");
            Console.WriteLine("#  Good bye!           #");
            Console.WriteLine("#                      #");
            Console.WriteLine("########################");
            Console.ReadLine();
        }

        static bool TryAgain(Match match)
        {
            Console.WriteLine();
            Console.WriteLine("   ################");
            Console.WriteLine("   #              #");
            Console.WriteLine("   # Confirmation #");
            Console.WriteLine("   #              #");
            Console.WriteLine("##############################");
            Console.WriteLine("#                            #");

            if (match.player1_score > match.player2_score)
                Console.WriteLine("# Player 1 wins!             #");
            else if (match.player1_score < match.player2_score)
                Console.WriteLine("# Player 2 wins!             #");
            else
                Console.WriteLine("# It's a tie!                #");

            Console.WriteLine("# Play again?                #");
            Console.WriteLine("#                            #");
            Console.WriteLine("##############################");

            do
            {
                Console.Write("\n  >> ");
                switch (Console.ReadLine().ToLower())
                {
                    case "yes": return true;
                    case "no": return false;
                    default: Console.WriteLine("    Invalid Answer! Please type only \"yes\" or \"no\""); break;
                }
            }
            while (true);
        }
    }
}
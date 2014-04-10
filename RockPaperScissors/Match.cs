/*******************************
 * 
 *  Clarke Benedict T. Plumo
 *  BSCS 3-1N
 *  
 *******************************/

using System;
using System.Threading;

namespace RockPaperScissors
{
    public class Match
    {
        public int player1_score;
        public int player2_score;
        public int draw_score;
        int round;

        public Match()
        {
            player1_score = 0;
            player2_score = 0;
            draw_score = 0;
            round = 0;
        }
        public void Battle()
        {
            round++;

            string choice1 = Choice(1, round);
            string choice2 = Choice(2, round);

            string[] default_hand = Hand.Rock();
            string[] hand1 = Hand.Image(choice1);
            string[] hand2 = Hand.Image(choice2);

            for (int j = 0; j < 6; j++)
            {
                if (j == 5)
                {
                    DrawBattle(j, hand1, hand2);
                }
                else
                {
                    DrawBattle(j, default_hand, default_hand);
                }
            }

            switch (Hand.Winner(choice1, choice2))
            {
                case 1:
                    Console.Write("\n  Victory!");
                    player1_score++;
                    break;

                case 2:
                    Console.Write("\n\t\t\t\t  Victory!");
                    player2_score++;
                    break;

                default:
                    Console.Write("\n  Draw\t\t\t  Draw");
                    draw_score++;
                    break;
            }

            Console.ReadLine();
        }

        public string Choice(int player, int round)
        {
            do
            {
                DrawStats();
                DrawBattleMenu(player);

                Console.Write("\n  Player 1: ");

                if (player == 2)
                {
                    Console.Write("*\n");
                    Console.Write("  Player 2: ");
                }

                switch (Console.ReadLine())
                {
                    case "1": return "rock";
                    case "2": return "paper";
                    case "3": return "scissors";
                    default: Console.Write("   Invalid!"); Console.ReadLine(); break;
                }
            }
            while (true);
        }

        void DrawBattleMenu(int player)
        {
            Console.WriteLine("#          #");
            Console.WriteLine("# Player " + player + " #");
            Console.WriteLine("#          #");
            Console.WriteLine("#################");
            Console.WriteLine("#               #");
            Console.WriteLine("# [1] Rock      #");
            Console.WriteLine("# [2] Paper     #");
            Console.WriteLine("# [3] Scissors  #");
            Console.WriteLine("#               #");
            Console.WriteLine("#################");
        }

        void DrawRoundsAndScores()
        {
            Console.WriteLine("#               #");
            Console.WriteLine("# Round " + round + "\t#");
            Console.WriteLine("# Score " + Scores() + "\t#");
            Console.WriteLine("#               #");
            Console.WriteLine("#################");
        }

        void DrawBattle(int i, string[] hand1, string[] hand2)
        {
            DrawStats();
            Console.WriteLine(Hand.BatoBatoPik(i));
            Console.WriteLine("\n  Player1\t\t\t  Player2");
            if (i % 2 == 1) Console.WriteLine();
            DrawHands(hand1, hand2);
        }

        void DrawHands(string[] hand1, string[] hand2)
        {
            Console.WriteLine();
            for (int i = 0; i < hand1.Length; i++)
            {
                Console.Write(String.Reverse(hand1[i]));
                Console.Write("\t");
                Console.Write(hand2[i]);
                Console.Write("\n");
            }
            Thread.Sleep(250);
        }
        public void DrawStats()
        {
            Game.DrawTitle();
            DrawRoundsAndScores();
        }
        public string Scores()
        {
            return player1_score + "-" + player2_score + "-" + draw_score;
        }
    }
}

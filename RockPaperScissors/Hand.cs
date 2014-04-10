/*******************************
 * 
 *  Clarke Benedict T. Plumo
 *  BSCS 3-1N
 *  
 *******************************/

namespace RockPaperScissors
{
     class Hand
    {
        public static string[] Image(string hand)
        {
            switch (hand)
            {
                case "rock": return Rock();
                case "paper": return Paper();
                case "scissors": return Scissors();
                default: return Rock();
            }
        }
        public static string[] Rock()
        {
            return new string[]
            {
                "            #####      ",
                "          #########    ",
                "         ###########   ",
                "          #########    ",
                "            #####      ",
            };
        }
        public static string[] Scissors()
        {
            return new string[]
            {
                "            #####      ",
                " ##################    ",
                "        ############   ",
                "    ####  #########    ",
                "            #####      ",
            };
        }
        public static string[] Paper()
        {
            return new string[]
            {
                "            #####      ",
                "    ###############    ",
                "   #################   ",
                "    ###############    ",
                "        #########      ",
            };
        }

        public static int Winner(string hand1, string hand2)
        {
            if (hand1 == "rock")
            {
                if (hand2 == "rock") return 0;
                if (hand2 == "paper") return 2;
                if (hand2 == "scissors") return 1;
            }
            if (hand1 == "paper")
            {
                if (hand2 == "rock") return 1;
                if (hand2 == "paper") return 0;
                if (hand2 == "scissors") return 2;
            }
            if (hand1 == "scissors")
            {
                if (hand2 == "rock") return 2;
                if (hand2 == "paper") return 1;
                if (hand2 == "scissors") return 0;
            }
            return 0;
        }

        public static string BatoBatoPik(int i)
        {
            string bbp = "\n ";
            if (i >= 0) bbp += "Ba";
            if (i >= 1) bbp += "to ";
            if (i >= 2) bbp += "Ba";
            if (i >= 3) bbp += "to ";
            if (i == 5) bbp += "Pik!";

            return bbp;
        }
    }
}

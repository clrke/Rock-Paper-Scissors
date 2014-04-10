/*******************************
 * 
 *  Clarke Benedict T. Plumo
 *  BSCS 3-1N
 *  
 *******************************/

using System;

namespace RockPaperScissors
{
    class String
    {
        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}

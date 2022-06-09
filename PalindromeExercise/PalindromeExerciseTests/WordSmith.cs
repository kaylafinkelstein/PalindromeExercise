using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExerciseTests
{
    public class WordSmith
    {

        public bool IsAPalindrome(string word)
        {
            char[] charsArray = word.ToCharArray();
            Array.Reverse(charsArray);
            var reversed = new string(charsArray);

            if (reversed == word)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
    }
}

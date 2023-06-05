using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            string wordReversed = new string(word.Reverse().ToArray());
            return word.Equals(wordReversed);
           
        }

    }
}

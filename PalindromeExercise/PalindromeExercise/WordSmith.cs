using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            string wordReversed = new string (word.Reverse().ToArray());
            return word.ToLower().Equals(wordReversed.ToLower());



            // string wordReversed = "";
            // for (int i = word.Length - 1; i >= 0; i--)
            // {
            //     wordReversed += word[i];  
            // }
            //if (word == wordReversed)
            // {
            //     return true;
            // }
            // else
            // {
            //     return false;
            // }

            //var wordChar = word.ToCharArray();
            //Array.Reverse(wordChar);
            //var wordReversed = new string(wordChar);

            //if(word.ToLower() == wordReversed.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            
        }
        public static bool IsValidWord(string word)
        {
            return !string.IsNullOrWhiteSpace(word) && word.All(char.IsLetter);
        }
        public static string PalindromeChecker(string userWord)
        {
          if(!IsValidWord(userWord))
            {
                return ($"{userWord} is an invalid entry.");
            }
            string wordReversed = new string (userWord.Reverse().ToArray());

            if (userWord.ToLower().Equals(wordReversed.ToLower()))
                {
                return ($"{userWord} is a palindrome");
                }
            else
            {
                return ($"{userWord} is not a palindrome");
            }


            
        }

    }
}

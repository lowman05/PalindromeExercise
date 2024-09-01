using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a word to check if it is a palindrome, or type 'exit' to leave.");
                string userWord = Console.ReadLine();
                if (userWord.ToLower() == "exit")
                {
                    break;
                }
                Console.WriteLine(WordSmith.PalindromeChecker(userWord));
                
            }
        }
    }
    

}

using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("deified", true)]
        [InlineData("mom", true)]
        [InlineData("rotator", true)]
        [InlineData("true", false)]
        public void PalindromeTest1(string word, bool expected)
        {
            var palindrome = new WordSmith();
            var actual = palindrome.IsAPalindrome(word);
            Assert.Equal(expected, actual);
        }
    }
}

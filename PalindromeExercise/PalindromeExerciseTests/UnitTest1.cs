using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)] //Add test data <-------
        [InlineData("notapalindrome", false)]
        [InlineData("emordnilappalindrome", true)]
        //[InlineData(0, -3, -2, -5)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var palindrome = new WordSmith();
            //act
            var actual = palindrome.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);

        }
    }
}

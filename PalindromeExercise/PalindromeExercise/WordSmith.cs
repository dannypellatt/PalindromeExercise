using System;
using System.Linq;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            

            return word == null || word.Length == 0 ? false : word.ToLower().SequenceEqual(word.ToLower().Reverse());
        }
    }
}


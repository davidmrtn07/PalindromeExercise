using System;
using PalindromeExercise;
using PalindromeExerciseTests;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("hello", false)]
        [InlineData("Racecar", true)]
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();
            //act
            var actual = wordSmith.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);

        }
    }
}

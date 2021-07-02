using System;
using Xunit;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("race car", true)]
        [InlineData("taco cat", true)]
        [InlineData("civic", true)]
        [InlineData("afternoon", false)]
        [InlineData("14741", true)]
        [InlineData("4893759475", false)]
        public void Test1(string test, bool expected)
        {
            //Arrange
            var word = new WordSmith();
            //Act
            bool actual = word.IsAPalindrome(test);
            //Assert
            Assert.Equal(expected, actual);
        }
        // Remove [Fact]
       // Replace with[Theory]

       // [InlineData(“racecar”, true)]
       // Add more InlineData tests like the one above
       // Finish the test with arrange, act, assert and make your IsAPalindrome method pass the tests
    }
}

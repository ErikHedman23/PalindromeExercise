using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("bob", true)]
        [InlineData("deified", true)]
        [InlineData("toot", true)]
        [InlineData("Do Geese See God", true)]
        [InlineData("dad", true)]
        [InlineData("cat", false)]
        [InlineData("don't do that", false)]
        [InlineData("grateful", false)]
        [InlineData("mad hatter", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void PalindromeTest(string palin, bool expected)
        {
            var wordsmith = new WordSmith();

            var actual = wordsmith.IsAPalindrome(palin);

            Assert.Equal(expected, actual);
        }
    }
}

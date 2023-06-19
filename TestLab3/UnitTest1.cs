

using Lab3;
using Xunit;

namespace TestLab3
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 5, 2, 5 }, 50)]
        [InlineData(new int[] { 1, 2 }, 0)]
        [InlineData(new int[] { -2, -2, -3 }, -12)]
        public void TestChallenge1(int[] arr, int expected)
        {
         
            var result = Challenge.Challenge1(arr);

            Assert.Equal(expected, result);
        }




        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, 2)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { -1, -2, -3 }, 0)]
        public void Challenge2T(int[] numbers, int expected)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(new StringReader($"{numbers.Length}\n{string.Join("\n", numbers)}"));

            // Act
            int actual = Challenge.Challenge2(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

     




        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 3 }, 1)]
        [InlineData(new int[] { 1, 2, 3, 3 }, 3)]
        public void Challenge4T(int[] numbers, int expected)
        {
            // Act
            int actual = Challenge.Challenge4(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { -1, -2, -3 }, -1)]
        [InlineData(new int[] { 1, 1, 1 }, 1)]
        public void Challenge5T(int[] numbers, int expected)
        {
            Assert.Equal(expected, Challenge.Challenge5(numbers));
        }







        [Theory]
        [InlineData("Hey Iam Odai", new string[] { "\"Hey\": 3", "\"Iam\": 3", "\"Odai\": 4" })]
        [InlineData("This is a test", new string[] { "\"This\": 4", "\"is\": 2", "\"a\": 1", "\"test\": 4" })]
        public void Challenge9T(string input, string[] expected)
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            Console.SetIn(new StringReader(input));

            // Act
            string[] actual = Challenge.Challenge9();

            // Assert
            Assert.Equal(expected, actual);
        }







    }
}

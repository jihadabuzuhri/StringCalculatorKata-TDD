using Xunit;

namespace StringCalculatorKataSolution
{
    public class CalculatorAddTest
    {

        [Fact]
        public void ReturnZeroWithEmptyStringTest()
        {
            String InputString = "";
            
            int result = StringCalculatorKata.Add(InputString);
            
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void ReturnsNumberWithOneNumberTest(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,4", 6)]
        public void ReturnsSumOfNumberWithTwoCommaSeparatedNumberTest(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2,4", 7)]
        [InlineData("2,4,5,7", 18)]
        public void ReturnsSumOfNumberWithManyCommaSeparatedNumberTest(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("1\n2,4", 7)]
        [InlineData("2,4\n5\n7", 18)]
        public void ReturnsSumOfNumberWithManyCommaOrNewLinesSeparatedNumberTest(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("//,\n2,4,1", 7)]
        [InlineData("//;\n1;2", 3)]
        public void ReturnsSumOfNumberWithManySeparatedNumberWithDifferentDelimitersTest(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
         
        [Theory]
        [InlineData("-4,8,7", "Negatives not allowed: -4")]
        [InlineData("-21,-32", "Negatives not allowed: -21,-32")]
        public void ThrowsGivenNegativeInputsTest(string numbers, string expectedMessage)
        {

            Action action = () => StringCalculatorKata.Add(numbers);

            var exception = Assert.Throws<Exception>(action);

            Assert.Equal(expectedMessage, exception.Message);

        }

        [Theory]
        [InlineData("3,4,5,6000", 12)]
        [InlineData("1000,2", 1002)]
        [InlineData("1002,5", 5)]
        public void ReturnsSumGivenStringIgnoringValuesOverThan1000(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }




    }
}
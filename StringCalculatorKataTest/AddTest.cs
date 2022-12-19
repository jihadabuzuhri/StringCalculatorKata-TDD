using Xunit;

namespace StringCalculatorKataSolution
{
    public class AddTest
    {

        [Fact]
        public void EmptyStringTest()
        {
            String InputString = "";
            
            int result = StringCalculatorKata.Add(InputString);
            
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void ReturnsNumberWithOneNumber(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,4", 6)]
        public void ReturnsSumOfNumberWithTwoCommaSeparatedNumber(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2,4", 7)]
        [InlineData("2,4,5,7", 18)]
        public void ReturnsSumOfNumberWithManyCommaSeparatedNumber(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("1\n2,4", 7)]
        [InlineData("2,4\n5\n7", 18)]
        public void ReturnsSumOfNumberWithManyCommaOrNewLinesSeparatedNumber(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }


        [Theory]
        [InlineData("//,\n2,4,1", 7)]
        [InlineData("//;\n1;2", 3)]
        public void ReturnsSumOfNumberWithManySeparatedNumberWithDifferentDelimiters(string numbers, int expectedResult)
        {
            int result = StringCalculatorKata.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
        
    }
}
namespace StringCalculatorKataSolution
{
    public class StringCalculatorKata
    {
        public static int Add(string numbers)
        {   if(String.IsNullOrEmpty(numbers) ) return 0;

            var Splitednumbers = numbers.Split( ',' );

            return Splitednumbers.Select(num => int.Parse(num)).Sum();

        }
    }
}
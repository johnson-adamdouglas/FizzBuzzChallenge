namespace FizzBuzzChallange
{
    internal class Program
    {
        public static string FizzBuzz(int num)
        {
            if (num % 15 == 0)
            {
                return "fizzbuzz";
            }
            else if (num % 5 == 0)
            {
                return "buzz";
            }
            else if (num % 3 == 0)
            {
                return "fizz";
            }
            else return "N/A";


        }

        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(75));
        }
    }
}
using TwistedFizzBuzz;

/* Write a C# console application that uses the TwistedFizzBuzz library to 
 * solve the standard FizzBuzz Problem. */
class Program
{
    static void Main(String[] args)
    {
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //String fizzBuzzSolution = TwistedFizzBuzz.Util.FizzBuzzDiscrete(arr);
        String fizzBuzzSolution = TwistedFizzBuzz.Util.FizzBuzz(1, 100);
        Console.WriteLine(fizzBuzzSolution);
    }
}
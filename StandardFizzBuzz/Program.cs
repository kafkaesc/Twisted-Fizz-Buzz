using TwistedFizzBuzz;

/* Write a C# console application that uses the TwistedFizzBuzz library to 
 * solve the standard FizzBuzz Problem. */
class Program
{
    static void Main(String[] args)
    {
        String fizzBuzzSolution = TwistedFizzBuzz.Util.FizzBuzz(1, 100);
        //String fizzBuzzSolution = TwistedFizzBuzz.Util.FizzBuzz(-2, -37);
        Console.WriteLine(fizzBuzzSolution);
    }
}
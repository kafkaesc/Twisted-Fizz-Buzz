using TwistedFizzBuzz;

/* Write another C# console application that uses the TwistedFizzBuzz library 
 * to do the following:
 * 
 * - Output values from -20 to 127
 * - For multiples of 5 print "Fizz"
 * - For multiples of 9 print "Buzz"
 * - For multiples of 27 print "Bar"
 * - For multiples where more than one number from above matches, print the 
 *   appropriate concatenated tokens
 */
class Program
{
    static void Main(String[] args)
    {
        TwistedFizzBuzz.Util.SetFizzBuzz("Fizz", 5, "Buzz", 9, "Bar", 27);
        Console.WriteLine(TwistedFizzBuzz.Util.FizzBuzz(-20, 127));
        TwistedFizzBuzz.Util.ResetFizzBuzz();
    }
}
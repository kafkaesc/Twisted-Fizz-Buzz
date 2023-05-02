namespace TwistedFizzBuzz;
public static class Util
{
    static String buzz = "buzz";
    static int buzzDivisor = 5;
    static String fizz = "fizz";
	static int fizzDivisor = 3;
	
    /* TODO: Accept user input for a range of numbers and returns their 
     * FizzBuzz output.For example, 1-50, 1-2,000,000,000, or (-2)-(-37) 
     */
	public static String FizzBuzz(int start, int end)
	{
		String output = "";
		for (var i = start; i < end; i++)
		{
			String fizzBuzzInt = "";
			if (i % fizzDivisor == 0)
                fizzBuzzInt += fizz;
			if (i % buzzDivisor == 0)
                fizzBuzzInt += buzz;
			if (fizzBuzzInt.Length == 0)
                fizzBuzzInt += i;
			output += fizzBuzzInt + ", ";
		}
		return output.Substring(0, output.Length - 2);
	}

	/* TODO: Accept user input of a non-sequential set of numbers and returns 
	 * their FizzBuzz output.For example: -5, 6, 300, 12, 15 
	 */
	public static String FizzBuzzDiscrete(int[] userInput)
	{
		String output = "";
		for (var i = 0; i < userInput.Length; i++)
		{
			String fizzBuzzInt = "";
			if (userInput[i] % fizzDivisor == 0)
				fizzBuzzInt += fizz;
			if (userInput[i] % buzzDivisor == 0)
				fizzBuzzInt += buzz;
			if (fizzBuzzInt.Length == 0)
				fizzBuzzInt += userInput[i];
			output += fizzBuzzInt + " ";
		}
        return output.Substring(0, output.Length - 2);
    }

	public static void ResetFizzBuzz()
	{
        buzz = "buzz";
        buzzDivisor = 5;
		fizz = "fizz";
        fizzDivisor = 3;
	}

	public static void SetFizzBuzz(String buzzName, int? buzzDiv, String fizzName, int? fizzDiv)
	{
		if (buzzName != null)
			buzz = buzzName;
		if (buzzDiv != null)
			buzzDivisor = buzzDiv.Value;
		if (fizzName != null)
			fizz = fizzName;
		if (fizzDiv != null)
			fizzDivisor = fizzDiv.Value;
    }

	/* TODO: Accept user input for alternative tokens instead of "Fizz" and 
	 * "Buzz" and alternative divisors instead of 3 and 5. For example, 7, 17, 
	 * and 3 would use "Poem", "Writer", and "College". 119 would output 
	 * "PoemWriter", 51 would output "WriterCollege", 21 would output 
	 * "PoemCollege, and 357 would output "PoemWriterCollege" 
	 */

	/* TODO: Accept user input for API generated tokens provided by 
	 * https://rich-red-cocoon-veil.cyclic.app/) 
	 */
}


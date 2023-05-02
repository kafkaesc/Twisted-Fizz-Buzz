namespace TwistedFizzBuzz;
public static class Util
{
    static String buzz = "Buzz";
    static int buzzDivisor = 5;
    static String fizz = "Fizz";
	static int fizzDivisor = 3;
    static String tern = "Tern";
    static int? ternDivisor = null;
	
    /* Accept user input for a range of numbers and returns their FizzBuzz 
     * output.For example, 1-50, 1-2,000,000,000, or (-2)-(-37) 
     */
	public static String FizzBuzz(int start, int end)
	{
		String output = "";
		if (start < end)
			for (var i = start; i < end; i++)
				output += FizzBuzzString(i) + ", ";
		else if (start > end)
			for (var i = start; i > end; i--)
                output += FizzBuzzString(i) + ", ";
		else
			output += FizzBuzzString(start) + ", ";
		return output.Substring(0, output.Length - 2);
	}

	private static String FizzBuzzString(int n)
	{
        String fizzBuzzString = "";
        if (n % fizzDivisor == 0)
            fizzBuzzString += fizz;
        if (n % buzzDivisor == 0)
            fizzBuzzString += buzz;
        if (ternDivisor != null && n % ternDivisor.Value == 0)
            fizzBuzzString += tern;
        if (fizzBuzzString.Length == 0)
            fizzBuzzString += n;
        return fizzBuzzString;
	}

	/* Accept user input of a non-sequential set of numbers and returns 
	 * their FizzBuzz output, e.g., -5, 6, 300, 12, 15.
	 */
	public static String FizzBuzzDiscrete(int[] userInput)
	{
		String output = "";
		for (var i = 0; i < userInput.Length; i++)
			output += FizzBuzzString(userInput[i]) + ", ";
        return output.Substring(0, output.Length - 2);
    }

	public static void ResetFizzBuzz()
	{
        buzz = "buzz";
        buzzDivisor = 5;
		fizz = "fizz";
        fizzDivisor = 3;
		tern = "tern";
		ternDivisor = null;
	}

    /* Accept user input for alternative tokens instead of "Fizz" and "Buzz" 
     * and alternative divisors instead of 3 and 5. For example, 7, 17, and 3 
     * would use "Poem", "Writer", and "College". 119 would output "PoemWriter",
     * 51 would output "WriterCollege", 21 would output "PoemCollege, and 357 
     * would output "PoemWriterCollege" 
     */
    public static void SetFizzBuzz(
		String buzzName,
		int? buzzDiv,
		String fizzName,
		int? fizzDiv,
		String ternName,
		int? ternDiv
	) {
		if (buzzName != null)
			buzz = buzzName;
		if (buzzDiv != null)
			buzzDivisor = buzzDiv.Value;
		if (fizzName != null)
			fizz = fizzName;
		if (fizzDiv != null)
			fizzDivisor = fizzDiv.Value;
		if (ternName != null)
			tern = ternName;
		if (ternDiv != null)
			ternDivisor = ternDiv.Value;
    }


	/* TODO: Accept user input for API generated tokens provided by 
	 * https://rich-red-cocoon-veil.cyclic.app/) 
	 */
}

